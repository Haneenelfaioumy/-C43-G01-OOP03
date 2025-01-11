using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class EBook : Book
    {
        #region Property
        // Additional property for EBook
        public double FileSize { get; set; } // File size in MB

        #endregion

        #region Constructor
        // Constructor for EBook
        public EBook(string title, string author, string isbn, double fileSize) : base(title, author, isbn)
        {
            FileSize = fileSize;
        }
        #endregion

        #region Method
        // Override DisplayInfo to include FileSize
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB");
        } 
        #endregion

    }
}
