using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using System.Data.Entity.Validation;

namespace DAL.Repos
{
    public class EmployeeRepo : IEmployeeRepository<Employee, int>
    {
        TMS1Entities1 db;

        public EmployeeRepo(TMS1Entities1 db)
        {
            this.db = db;
        }
        public bool Add(Employee e)
        {
            db.Employees.Add(e);
            return (db.SaveChanges() > 0);
        }

        public bool delete(int id)
        {
            var emp_data = (from u in db.Employees where u.employeeid == id select u).FirstOrDefault();
            if(emp_data != null)
            {
                db.Employees.Remove(emp_data);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Edit(Employee e)
        {
            var emp = (from u in db.Employees where u.employeeid == e.employeeid select u).FirstOrDefault();
            emp.employeename = e.employeename;
            emp.password = e.password;
            emp.type = e.type;
            emp.salary = e.salary;
            emp.mobilenumber = e.mobilenumber;
            emp.address = e.address;
            if (db.SaveChanges() != 0) return true;
            return false;
        }

        public List<Employee> Get()
        {
            var data = db.Employees.ToList();
            return data;
        }

        public Employee Get(int id)
        {
            var data = (from u in db.Employees where u.employeeid == id select u).FirstOrDefault();
            return data;
        }
    }
}
