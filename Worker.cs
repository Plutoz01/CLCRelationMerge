using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GraphTools;
using GraphTools.OSM;
using System.Xml.Linq;
using System.Xml;

namespace CLCRelationMerge
{
    public class Worker
    {
        public static String CLCid = "CLC:id";

        public String DataFile { get; set; }
        public String CLCFile { get; set; }
        public String OutputFile { get; set; }

        IEnumerable<OSMNode> originalNodes;
        IEnumerable<OSMWay> originalWays;
        IEnumerable<OSMRelation> originalRelations;
        IDictionary<string, string> rootAttributes;

        IEnumerable<OSMNode> clcNodes;
        IEnumerable<OSMWay> clcWays;
        IDictionary<string, OSMRelation> clcRelations;

        public IEnumerable<OSMNode> OriginalNodes
        {
            get { return originalNodes; }
        }
        public IEnumerable<OSMWay> OriginalWays
        {
            get { return originalWays; }
        }
        public IEnumerable<OSMRelation> OriginalRelations
        {
            get { return originalRelations; }
        }
        public IEnumerable<OSMNode> CLCNodes
        {
            get { return clcNodes; }
        }
        public IEnumerable<OSMWay> CLCWays
        {
            get { return clcWays; }
        }
        public IEnumerable<OSMRelation> CLCRelations
        {
            get { return clcRelations.Values; }
        }

        public BoundingBox BoundingBox { get; set; }




        public Worker(String DataFile, String CLCFile, String OutputFile)
        {
            this.DataFile = DataFile;
            this.CLCFile = CLCFile;
            this.OutputFile = OutputFile;
        }

        public void LoadFromFiles()
        {
            IDictionary<string, string> tmpRootAttributes;
            OSMFileHandler.ReadFile(DataFile, out originalNodes, out originalWays, out originalRelations, out tmpRootAttributes, true, true, true, false);
            //OSMFileHandler.ReadFile(DataFile, out originalNodes, out originalWays, out originalRelations, true, true, true);

            IEnumerable<OSMRelation> tmpCLCRelations;
            
            OSMFileHandler.ReadFile(CLCFile, out clcNodes, out clcWays, out tmpCLCRelations, out rootAttributes, true, true, true, true);
            clcRelations = tmpCLCRelations.ToDictionary(r => r.Tags[CLCid]);
            GC.Collect();
        }

        public void DoJob()
        {  
            //Collect the CLC relations from the original
            var clcRelationsFromOriginal = originalRelations.Where(r => r.Tags.ContainsKey(CLCid))
                                                            .Distinct(new ClcIdRelationEqualityComparer())
                                                            .ToDictionary(r => r.Tags[CLCid]);
            //var clcRelationsFromOriginal = .Distinct().ToDictionary(r => r.Tags[CLCid]);
            //IDictionary<string,OSMRelation> clcRelationsFromOriginal = new Dictionary<string,OSMRelation>();


            HashSet<OSMRelation> duplications = new HashSet<OSMRelation>(); //relations already exists in the original file, don't need to copy to outputFile
            //merge new relations with olds
            foreach (var newRel in clcRelations)
            {                
                if (clcRelationsFromOriginal.ContainsKey(newRel.Key))
                {
                    //merge new members
                    OSMRelation originalRelation = clcRelationsFromOriginal[newRel.Key];                    
                    foreach(var newMember in newRel.Value.Members){
                        originalRelation.Members.Add(newMember);
                    }

                    //merge new tags
                    foreach (var newTag in newRel.Value.Tags)
                    {
                        if (!originalRelation.Tags.ContainsKey(newTag.Key)){
                            originalRelation.Tags.Add(newTag.Key,newTag.Value);
                        }
                    }

                    //add to duplicated
                    duplications.Add(newRel.Value);
                }                
            }

            //creating root Attributes
            List<KeyValuePair<string, string>> attributes = new List<KeyValuePair<string, string>>();
            attributes.Add(new KeyValuePair<string,string>(OSMKeys.Version,"0.6"));
            attributes.Add(new KeyValuePair<string, string>(OSMKeys.Generator, "CLCRelationMerge by Plutoz"));

            //union original nodes withList
            OSMFileHandler.WriteFile(filename: OutputFile,
                                     nodes: Enumerable.Concat(OriginalNodes, CLCNodes),
                                     ways: Enumerable.Concat(originalWays, CLCWays),
                                     //union original relations with new CLC relations that are not in duplications
                                     relations: Enumerable.Concat(OriginalRelations,clcRelations.Values.Where(r => !duplications.Contains(r))),
                                     boundingBox: BoundingBox,
                                     rootAttributes: attributes);
        }


    }
}
