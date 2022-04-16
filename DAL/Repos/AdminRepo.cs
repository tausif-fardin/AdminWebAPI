using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class AdminRepo: IAdminRepository<Admin, int, string>
    {
        TMS1Entities1 db;

        public AdminRepo(TMS1Entities1 db)
        {
            this.db = db;
        }

        public bool ChangePassword(string Newpassword, int id)
        {
            var a = (from u in db.Users where u.userid == id select u).FirstOrDefault();
            a.password = Newpassword;
            if (db.SaveChanges() != 0) return true;
            return false;
        }
        public bool EditProfile(Admin e)
        {
            var a = (from u in db.Admins where u.adminid == e.adminid select u).FirstOrDefault();

            a.adminname = e.adminname;
            a.image = e.image;
            if (db.SaveChanges() != 0) return true;
            return false;
        }
        public string GetPass(int id)
        {
            var data = (from u in db.Users where u.userid == id select u.password).FirstOrDefault();
            return data;
        }

        public int[] number()
        {
            var User_data = (from u in db.Users where u.role == "customer" select u).ToList().Count;
            var Advertiser_data = (from u in db.Users where u.role == "advertiser" select u).ToList().Count;
            var Employee_data = (from u in db.Users where u.role == "employee" select u).ToList().Count;
            var Package_data = db.Packages.ToList().Count;
            int[] num = new int[4];
            num[0] = User_data;
            num[1] = Advertiser_data;
            num[2] = Employee_data;
            num[3] = Package_data;
            return num;
        }
    }

}
