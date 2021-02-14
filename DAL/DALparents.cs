using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALparents
    {
        public static List<parents> addgroup(parents p)
        {
            Guid idm = System.Guid.NewGuid();
            p.id_parent = idm.ToString();
            p.paid_up = false;
            using (DB_GIFTGROUPEntities41 db = new DB_GIFTGROUPEntities41())
            {  
                try
                {
                    db.parents.Add(p);
                    db.SaveChanges();
                    return db.parents.ToList();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
