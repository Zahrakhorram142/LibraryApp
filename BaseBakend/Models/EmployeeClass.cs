using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{
    public class EmployeeClass:PersonClass
    {
        public int EmployeeID { get; set; }
        public string NationalCode { get; set; }
        public DateTime EmployeementDate { get; set; }
    }
}
