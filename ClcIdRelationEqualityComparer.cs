using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphTools.OSM;

namespace CLCRelationMerge
{
    public class ClcIdRelationEqualityComparer : IEqualityComparer<OSMRelation>
    {
        public bool  Equals(OSMRelation x, OSMRelation y)
        {
 	        return x.Tags[Worker.CLCid].Equals(y.Tags[Worker.CLCid]);
        }

        public int  GetHashCode(OSMRelation obj)
        {
 	        return obj.Tags[Worker.CLCid].GetHashCode();
        }
    }
}
