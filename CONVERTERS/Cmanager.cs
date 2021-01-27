using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CONVERTERS
{
   public class Cmanager
    {
        public static DAL.manager ConvertToDALmanager(DTO.manager m)
        {

            DAL.manager m1 = new DAL.manager();
            m1.email_manager = m.email_manager;
            m1.name_manager = m.name_manager;
            m1.password_manager = m.password_manager;
            m1.phone_number_manager = m.phone_number_manager;
            m1.id_manager = m.id_manager;

            return m1;
        }
        public static DTO.manager ConvertToDTOmanager(DAL.manager m)
        {
            DTO.manager m1 = new DTO.manager();
            m1.email_manager = m.email_manager;
            m1.name_manager = m.name_manager;
            m1.password_manager = m.password_manager;
            m1.phone_number_manager = m.phone_number_manager;
            m1.id_manager = m.id_manager;
            return m1;
        }
        public static List<DTO.manager> ConvertToDTOmanagerList(List<DAL.manager> Listm)
        {
            List<DTO.manager> Listm1 = new List<DTO.manager>();
            foreach (var item in Listm)
            {
                Listm1.Add(ConvertToDTOmanager(item));
            }
            return Listm1;

        }
        public static List<DAL.manager> ConvertToDALmanagerList(List<DTO.manager> Listm)
        {
            List<DAL.manager> Listm1 = new List<DAL.manager>();
            foreach (var item in Listm)
            {
                Listm1.Add(ConvertToDALmanager(item));
            }
            return Listm1;

        }
    }
}
