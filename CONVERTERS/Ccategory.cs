using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERTERS
{
    public class Ccategory
    {
        public static DTO.category ConvertToDTOCategoy(DAL.category c)
        {
            DTO.category c1 = new DTO.category();
            c1.id_category = c.id_category;
            c1.name_category = c.name_category;
            return c1;

        }
        public static DAL.category ConvertToDALCategoy(DTO.category c)
        {
            DAL.category c1 = new DAL.category();
            c1.id_category = c.id_category;
            c1.name_category = c.name_category;
            return c1;

        }
        public static List<DAL.category> ConvertToDALCategoyList(List<DTO.category> cList)
        {
            List<DAL.category> cList1 = new List<DAL.category>();
            foreach(var item in cList)
            {
                cList1.Add(ConvertToDALCategoy(item));
            }
            return cList1;
        }
        public static List<DTO.category> ConvertToDTOCategoyList(List<DAL.category> cList)
        {
            List<DTO.category> cList1 = new List<DTO.category>();
            foreach (var item in cList)
            {
                cList1.Add(ConvertToDTOCategoy(item));
            }
            return cList1;
        }
    }
}
