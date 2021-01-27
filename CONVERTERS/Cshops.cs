using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERTERS
{
     public class Cshops
    {
        public static DAL.shops ConvertToDALshops(DTO.shops s)
        {
            DAL.shops s1 = new DAL.shops();
            s1.email_shop = s.email_shop;
            s1.id_shop = s.id_shop;
            s1.logo = s.logo;
            s1.name_shop = s.name_shop;
            s1.password_shop = s.phone_shop;
         

            return s1;
        }
        public static DTO.shops ConvertToDTOshops(DAL.shops s)
        {
            DTO.shops s1 = new DTO.shops();
            s1.email_shop = s.email_shop;
            s1.id_shop = s.id_shop;
            s1.logo = s.logo;
            s1.name_shop = s.name_shop;
            s1.password_shop = s.phone_shop;

            return s1;
        }
        public static List<DTO.shops> ConvertToDTOshopsList(List<DAL.shops> Lists)
        {
            List<DTO.shops> Lists1 = new List<DTO.shops>();
            foreach (var item in Lists)
            {
                Lists1.Add(ConvertToDTOshops(item));
            }
            return Lists1;

        }
        public static List<DAL.shops> ConvertToDALshopsList(List<DTO.shops> Lists)
        {
            List<DAL.shops> Lists1 = new List<DAL.shops>();
            foreach (var item in Lists)
            {
                Lists1.Add(ConvertToDALshops(item));
            }
            return Lists1;

        }
    }
}
