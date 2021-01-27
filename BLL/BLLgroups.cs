using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLgroups
    {
        public static List<DTO.groups> getallgroups()
        {
            return CONVERTERS.Cgroups.ConvertToDTOgroupList(DAL.DALgroup.getallgroups());
        }

        public static List<DTO.groups> Addgroup(DTO.groups g1)
        {
            var g2 = DAL.DALgroup.addgroup(CONVERTERS.Cgroups.ConvertToDALgroup(g1));
            var g3 = CONVERTERS.Cgroups.ConvertToDTOgroupList(g2);
            return g3;

        }
        public static DTO.groups updateGroup(DTO.groups g)
        {
            var g1= DAL.DALgroup.updateGroup(CONVERTERS.Cgroups.ConvertToDALgroup(g));
            var g2 = CONVERTERS.Cgroups.ConvertToDTOgroup(g1);
            return g2;
            
        }
    }
}
