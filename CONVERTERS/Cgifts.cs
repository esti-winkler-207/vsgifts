using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERTERS
{
   public class Cgifts

    {
        public static DAL.gifts ConvertToDALgifts(DTO.gifts g)
        {
            DAL.gifts g1 = new DAL.gifts();
            g1.id_gift = g.id_gift;
            g1.id_group = g.id_group;
            g1.id_product = g.id_product;
            g1.receiving_gift = g.receiving_gift;
           

            return g1;
        }
        public static DTO.gifts ConvertToDTOgifts(DAL.gifts g)
        {
            DTO.gifts g1 = new DTO.gifts();

            g1.id_gift = g.id_gift;
            g1.id_group = g.id_group;
            g1.id_product = g.id_product;
            g1.receiving_gift = g.receiving_gift;
            return g1;
        }
        public static List<DTO.gifts> ConvertToDTOgiftsList(List<DAL.gifts> Listg)
        {
            List<DTO.gifts> Listg1 = new List<DTO.gifts>();
            foreach (var item in Listg)
            {
                Listg1.Add(ConvertToDTOgifts(item));
            }
            return Listg1;

        }
        public static List<DAL.gifts> ConvertToDALgiftsList(List<DTO.gifts> Listg)
        {
            List<DAL.gifts> Listg1 = new List<DAL.gifts>();
            foreach (var item in Listg)
            {
                Listg1.Add(ConvertToDALgifts(item));
            }
            return Listg1;

        }
    }
}
