using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALproducts
    {
        public static List<DAL.products> getAllproducts()
        {
            using (DB_GIFTGROUPEntities41 db= new DB_GIFTGROUPEntities41())
            {
                return db.products.ToList();

            }
                 
        }
    }
}
