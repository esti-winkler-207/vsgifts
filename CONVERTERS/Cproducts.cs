using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERTERS
{
   public class Cproducts
    {
        public static DAL.products ConvertToDALproducts(DTO.products p)
        {
            DAL.products p1 = new DAL.products();
            p1.id_pictures = p.id_pictures;
            p1.id_product = p.id_product;
            p1.id_shop = p.id_shop;
            p1.name_product = p.name_product;
            p1.pic_product = p.pic_product;
            p1.price_product = p.price_product;
            

            return p1;
        }
        public static DTO.products ConvertToDTOproducts(DAL.products p)
        {
            DTO.products p1 = new DTO.products();
            p1.id_pictures = p.id_pictures;
            p1.id_product = p.id_product;
            p1.id_shop = p.id_shop;
            p1.name_product = p.name_product;
            p1.pic_product = p.pic_product;
            p1.price_product = p.price_product;
            return p1;
        }
        public static List<DTO.products> ConvertToDTOproductsList(List<DAL.products> Listp)
        {
            List<DTO.products> Listp1 = new List<DTO.products>();
            foreach (var item in Listp)
            {
                Listp1.Add(ConvertToDTOproducts(item));
            }
            return Listp1;

        }
        public static List<DAL.products> ConvertToDALproductsList(List<DTO.products> Listp)
        {
            List<DAL.products> Listp1 = new List<DAL.products>();
            foreach (var item in Listp)
            {
                Listp1.Add(ConvertToDALproducts(item));
            }
            return Listp1;

        }
    }
}
