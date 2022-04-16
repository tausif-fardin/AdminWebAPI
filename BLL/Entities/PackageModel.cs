using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class PackageModel
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public string ptype { get; set; }
        public string plocation { get; set; }
        public double pprice { get; set; }
        public System.DateTime creationdate { get; set; }
        public System.DateTime expiredate { get; set; }
        public int employeeid { get; set; }

    }
}
