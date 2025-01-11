using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class PrintedBook : Book
    {
        #region Property
        // Additional property for PrintedBook
        public int PageCount { get; set; }
        #endregion

        #region Constructor
        // Constructor for PrintedBook
        public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
        {
            PageCount = pageCount;
        }
        #endregion

        #region Method
        // Override DisplayInfo to include PageCount
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Page Count: {PageCount}");
        } 
        #endregion

    }
}
