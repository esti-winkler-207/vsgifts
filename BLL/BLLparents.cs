using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class BLLparents
    {
        public static List<DTO.parents> addParent(DTO.parents p)
        {
            return CONVERTERS.Cparents.ConvertToDTOparentsList(
                DAL.DALparents.addgroup(CONVERTERS.Cparents.ConvertToDALparents(p))
                );

        } 
    }
}
