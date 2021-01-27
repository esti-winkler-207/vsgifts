using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BLLmanager
    {
        public static List<DTO.manager> getallmanager()
        {
            return CONVERTERS.Cmanager.ConvertToDTOmanagerList(DAL.DALmanager.getallmanager());
        }

        public static DTO.manager AddManager(DTO.manager m1)
        {
            var m2 = DAL.DALmanager.addmanager(CONVERTERS.Cmanager.ConvertToDALmanager(m1));
            var m3 = CONVERTERS.Cmanager.ConvertToDTOmanager(m2);
            return m3;

        }


    }
}
