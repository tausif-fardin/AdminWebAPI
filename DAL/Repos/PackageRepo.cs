using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PackageRepo : IPackageRepository<Package, int>
    {
        TMS1Entities1 db;
        public  PackageRepo(TMS1Entities1 db)
        {
            this.db = db;
        }
        public bool Add(Package e)
        {
            db.Packages.Add(e);
            return (db.SaveChanges() > 0);
        }

        public bool Delete(int id)
        {
            var e = db.Packages.FirstOrDefault(x=>x.pid == id);
            db.Packages.Remove(e);
            return (db.SaveChanges() > 0);
        }

        public bool Edit(Package e)
        {
            var p = db.Packages.FirstOrDefault(x => x.pid == e.pid);
            db.Entry(p).CurrentValues.SetValues(e);
            return db.SaveChanges() > 0;
        }

        public List<Package> Get()
        {
            var data = db.Packages.ToList();
            return data;
        }

        public Package Get(int id)
        {
            var data = (from u in db.Packages where u.pid == id select u).FirstOrDefault();
            return data;
        }

        public List<Package> GetByDate(DateTime dateTime)
        {
            var e = (from Package in db.Packages where Package.creationdate == dateTime select Package).ToList();
            return e;
        }
    }
}
