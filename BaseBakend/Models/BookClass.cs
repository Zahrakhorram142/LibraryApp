using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{
    public class BookClass
    {
        public int BookID { get; set; }
        public string Name { get; set; }   
        public string Writer { get; set; } 
        public string Subject { get; set; } 
        public string Publishers { get; set; }  
        public int YearOfPublication { get; set; }
        public string Edition { get; set; }
    }
}
