using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class DALmanager
    {
        public static List<manager> getallmanager()
        {
             using (DB_GIFTGROUPEntities41 db = new DB_GIFTGROUPEntities41()) {
                try
                {
                    return db.manager.ToList();

                }
                catch(Exception e)
                {
                    throw e;

                }
        } }

        public static manager addmanager(manager m)
        {
            Guid idm = System.Guid.NewGuid();
            m.id_manager = idm.ToString();

            using (DB_GIFTGROUPEntities41 db = new DB_GIFTGROUPEntities41())
            {
                try
                {
                    Guid idg = System.Guid.NewGuid();

                    m.groups.Add(new groups()
                    {
                        id_group = idg.ToString(),
                        id_manager_group = m.id_manager,
                        collect_end = false,
                        password_group="adminstator",
                        name_group="adminstator"
                        
                        
                        
                    }) ;
                    
                    db.manager.Add(m);
                    
                    db.SaveChanges();
                    return db.manager.ToList().First(m4 => m4.id_manager == m.id_manager);

                }
                catch (Exception e)
                {
                    throw e;
                }
                

            }
        }
    }
}
