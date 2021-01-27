using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERTERS
{
  public  class Cpictures
    {
        public static DAL.pictures ConvertToDALpictures(DTO.pictures p)
        {
            DAL.pictures p1 = new DAL.pictures();
            p1.id_pictures = p.id_pictures;
            p1.url_pic = p.url_pic;


            return p1;
        }
        public static DTO.pictures ConvertToDTOpictures(DAL.pictures p)
        {
            DTO.pictures p1 = new DTO.pictures();
            p1.id_pictures = p.id_pictures;
            p1.url_pic = p.url_pic;

            return p1;
        }
        public static List<DTO.pictures> ConvertToDTOpicturesList(List<DAL.pictures> Listp)
        {
            List<DTO.pictures> Listp1 = new List<DTO.pictures>();
            foreach (var item in Listp)
            {
                Listp1.Add(ConvertToDTOpictures(item));
            }
            return Listp1;

        }
        public static List<DAL.pictures> ConvertToDALpicturesList(List<DTO.pictures> Listp)
        {
            List<DAL.pictures> Listp1 = new List<DAL.pictures>();
            foreach (var item in Listp)
            {
                Listp1.Add(ConvertToDALpictures(item));
            }
            return Listp1;

        }
    }
}
