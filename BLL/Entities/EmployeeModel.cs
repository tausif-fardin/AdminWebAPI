using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class EmployeeModel
    {
        public int employeeid { get; set; }
        public string employeename { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public double salary { get; set; }
        public string mobilenumber { get; set; }
        public string address { get; set; }
        public int adminid { get; set; }
        public Nullable<bool> status { get; set; }
    }
}
