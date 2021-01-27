using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERTERS
{
   public  class Cparents

    {
        public static DAL.parents ConvertToDALparents(DTO.parents p)
        {
            DAL.parents p1 = new DAL.parents();
            p1.email_parent = p.email_parent;
            p1.id_group = p.id_group;
            p1.id_parent = p.id_parent;
            p1.name_parent = p.name_parent;
            p1.paid_up = p.paid_up;
            p1.phone_number = p.phone_number;
            


            return p1;
        }
        public static DTO.parents ConvertToDTOparents(DAL.parents p)
        {
            DTO.parents p1 = new DTO.parents();
            p1.email_parent = p.email_parent;
            p1.id_group = p.id_group;
            p1.id_parent = p.id_parent;
            p1.name_parent = p.name_parent;
            p1.paid_up = p.paid_up;
            p1.phone_number = p.phone_number;
            return p1;
        }
        public static List<DTO.parents> ConvertToDTOparentsList(List<DAL.parents> Listp)
        {
            List<DTO.parents> Listp1 = new List<DTO.parents>();
            foreach (var item in Listp)
            {
                Listp1.Add(ConvertToDTOparents(item));
            }
            return Listp1;

        }
        public static List<DAL.parents> ConvertToDALparentsList(List<DTO.parents> Listp)
        {
            List<DAL.parents> Listp1 = new List<DAL.parents>();
            foreach (var item in Listp)
            {
                Listp1.Add(ConvertToDALparents(item));
            }
            return Listp1;

        }

    }
}
