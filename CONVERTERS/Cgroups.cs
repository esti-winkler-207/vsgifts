using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace CONVERTERS
{
     public class Cgroups
    {
        public static DAL.groups ConvertToDALgroup(DTO.groups g)
        {
            DAL.groups g1 = new DAL.groups();
            g1.collect_end = g.collect_end;
            g1.id_manager_group = g.id_manager_group;
            g1.name_group = g.name_group;
            g1.id_group = g.id_group;
            g1.password_group = g.password_group;

            return g1;
        }
        public static DTO.groups ConvertToDTOgroup(DAL.groups g)
        {
            DTO.groups g1 = new DTO.groups();
            g1.collect_end = g.collect_end;
            g1.id_manager_group = g.id_manager_group;
            g1.name_group = g.name_group;
            g1.id_group = g.id_group;
            g1.password_group = g.password_group;
            return g1;
        }
        public static List<DTO.groups> ConvertToDTOgroupList(List<DAL.groups> Listg)
        {
            List<DTO.groups> Listg1 = new List<DTO.groups>();
            foreach(var item in Listg)
            {
                Listg1.Add(ConvertToDTOgroup(item));
            }
            return Listg1;

        }
        public static List<DAL.groups> ConvertToDALgroupList(List<DTO.groups> Listg)
        {
            List<DAL.groups> Listg1 = new List<DAL.groups>();
            foreach (var item in Listg)
            {
                Listg1.Add(ConvertToDALgroup(item));
            }
            return Listg1;

        }
    }
}
