using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLproducts
    {
        public static List<DTO.products> getAllproducts()
        {
            return CONVERTERS.Cproducts.ConvertToDTOproductsList(DAL.DALproducts.getAllproducts());
        }
    }
}
