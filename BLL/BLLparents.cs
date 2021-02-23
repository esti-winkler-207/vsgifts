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
                DAL.DALparents.addparent(CONVERTERS.Cparents.ConvertToDALparents(p))
                );

        } 
        public static List<DTO.parents> getByIdGroup(string id)
        {
            return CONVERTERS.Cparents.ConvertToDTOparentsList(DAL.DALparents.getByIdGroup(id));
        }
    }
}
