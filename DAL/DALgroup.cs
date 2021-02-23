using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALgroup
    {
        public static List<groups> getallgroups()
        {
            using (DB_GIFTGROUPEntities41 db = new DB_GIFTGROUPEntities41())
            {
                try
                {
                    return db.groups.ToList();

                }
                catch (Exception e)
                {
                    throw e;

                }
            }
        }
        public static groups getById(string id)
        {
            using (DB_GIFTGROUPEntities41 db = new DB_GIFTGROUPEntities41())
            {
                return db.groups.First(g => g.id_manager_group == id);
            } 
        }
        public static groups getByPWD(string pwd)
        {
            using (DB_GIFTGROUPEntities41 db = new DB_GIFTGROUPEntities41())
            {
              return db.groups.First(g => g.password_group == pwd);
            }
        }


        public static groups updateGroup(DAL.groups g)
        {
            using (DB_GIFTGROUPEntities41 db=new DB_GIFTGROUPEntities41())
            {

                var g1 = db.groups.First(g2 => g2.id_manager_group == g.id_manager_group);
                g1.name_group = g.name_group;
                g1.password_group = g.password_group;
                
                db.SaveChanges();
                return g1;

            }

        }

        public static List<groups> addgroup(groups g)
        {
            Guid idm = System.Guid.NewGuid();
            g.id_group = idm.ToString();

            using (DB_GIFTGROUPEntities41 db = new DB_GIFTGROUPEntities41())
            {
                var id_m1 = db.manager.ToArray().Last();
                
                g.id_manager_group = id_m1.id_manager;
                try
                {

                    
                    db.groups.Add(g);
                    db.SaveChanges();
                    return db.groups.ToList();

                }
                catch (Exception e)
                {
                    throw e;
                }


            }
        }
    }
}
