using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{
    public class BorrowClass
    {
        public int BorrowID { get; set; }
        public string BorrowedBookName{ get; set;}
        public DateTime BorrowingDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
