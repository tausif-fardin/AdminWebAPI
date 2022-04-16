using DAL.Database;
using DAL.Interface;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static TMS1Entities1 db;
        static DataAccessFactory()
        {
            db = new TMS1Entities1();
        }

        public static IAdminRepository<Admin, int, string> AdminDataAccess()
        {
            return new AdminRepo(db);
        }
        public static IPackageRepository<Package, int> PackageDataAccess()
        {
            return new PackageRepo(db);
        }
        public static IEmployeeRepository<Employee, int> EmployeeDataAccess()
        {
            return new EmployeeRepo(db);
        }
    }
}
