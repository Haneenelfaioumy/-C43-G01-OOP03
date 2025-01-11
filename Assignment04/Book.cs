using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Book
    {
        #region Properties
        // Base class properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        #endregion

        #region Constructor
        // Constructor for the base class
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        #endregion

        #region Method
        // Method to display book details
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        } 
        #endregion
    }
}
