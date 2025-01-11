using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment04
{
    internal class Program
    {
        #region Methods

        // Bubble Sort implementation
        public static void BubbleSort(Employee[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Compare HireDate of adjacent employees
                    if (arr[j].HireDate > arr[j + 1].HireDate)
                    {
                        // Swap if they are in the wrong order
                        Employee temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        #endregion
        static void Main(string[] args)
        {
            #region Q1.1. Design and implement a Class for the employees in a company:
            /// Notes:
            /* 
            ● Employee is identified by an ID, Name, security level,
            salary, hire date and Gender.
            ● Weneedtorestrict the Gender field to be only M or F[Male
            or Female]
            ● Assign the following security privileges to the employee
            (guest, Developer, secretary and DBA) in a form of Enum.
            ● Wewanttoprovide the Employee Class to represent
            Employee data in a string Form(override ToString()),
            display employee salary in a currency format. [Use
            String.Format() Function].
            */

            //try
            //{
            //    Employee emp = new Employee(1, "Haneen Mahmoud", "F", 50000m, DateTime.Now, SecurityLevel.Developer);
            //    Console.WriteLine(emp.ToString());
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Q2. 2.Develop a Class to represent the Hiring Date Data:
            //● Consisting of fields to hold the day, month and Years.

            //try
            //{
            //    HiringDate hireDate = new HiringDate(15, 8, 2022);
            //    Console.WriteLine(hireDate.ToString()); // Output: 15/08/2022
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Exception : " + ex.Message);
            //}

            //Another Example

            //try
            //{
            //    // Attempt to create a HiringDate with an invalid date (e.g., February 30th)
            //    HiringDate invalidHireDate = new HiringDate(30, 2, 2022);
            //    Console.WriteLine(invalidHireDate.ToString()); // This line will not be executed
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Exception : " + ex.Message);
            //}

            #endregion

            #region Q3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
            ///Notes:
            /*
            ● Implement All the Necessary Member Functions on the
             Class(Getters, Setters)
            ● Define all the Necessary Constructors for the Class
            ● Allow NORUNTIMEerrors if the user inputs any data
            ● Write down all the necessary Properties(Instead of setters
             and getters)
            */

            //try
            //{
            //    // Create an array of Employees with size three
            //    Employee[] EmpArr = new Employee[3];

            //    // Initialize the array with different roles
            //    EmpArr[0] = new Employee(1, "Haneen Elfaioumy", "F", 75000m, DateTime.Now, SecurityLevel.DBA);
            //    EmpArr[1] = new Employee(2, "Rawan Mohsen", "F", 50000m, DateTime.Now, SecurityLevel.Guest);
            //    EmpArr[2] = new Employee(3, "Aser Younis", "M", 90000m, DateTime.Now, SecurityLevel.SecurityOfficer);

            //    // Display each employee's details
            //    foreach (Employee emp in EmpArr)
            //    {
            //        Console.WriteLine(emp.ToString());
            //    }
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Exception : " + ex.Message);
            //}
            #endregion

            #region Q4.4.Sort the employees based on their hire date then Print the sorted array.
            /// ● While sorting (how many times Boxing and Unboxing process has occurred)

            //// Create an array of Employees with different hire dates
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(1, "Haneen Elfaioumy", "F", 75000m, new DateTime(2021, 5, 1), SecurityLevel.DBA);
            //EmpArr[1] = new Employee(2, "Rawan Mohsen", "F", 50000m, new DateTime(2020, 3, 15), SecurityLevel.Guest);
            //EmpArr[2] = new Employee(3, "Aser Younis", "M", 90000m, new DateTime(2022, 8, 20), SecurityLevel.SecurityOfficer);

            //// Perform Bubble Sort based on HireDate
            //BubbleSort(EmpArr);

            //// Print the sorted array
            //Console.WriteLine("Sorted Employees by Hire Date:");
            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp.ToString());
            //}

            #endregion

            #region Q5.Design a program for a library management system where:
            /*
             ● Bookisabase class with properties like Title, Author, and ISBN.
             ● EBookandPrintedBook are derived classes with additional properties like FileSize for 
               EBook and PageCount for PrintedBook.
             Demonstrate how inheritance simplifies the design
            */

            //// Create instances of EBook and PrintedBook
            //EBook ebook = new EBook("Digital Fortress", "Dan Brown", "1234567890", 1.5);
            //PrintedBook printedBook = new PrintedBook("The Da Vinci Code", "Dan Brown", "0987654321", 689);

            //// Display information for each book
            //Console.WriteLine("EBook Info:");
            //ebook.DisplayInfo();

            //Console.WriteLine("\nPrinted Book Info:");
            //printedBook.DisplayInfo();

            #region how inheritance simplifies the design
            /*
             *** Benefits of Inheritance:
            Code Reusability: 
            Common properties (Title, Author, ISBN) and methods (DisplayInfo) are defined in the base class 
            Book,reducing code duplication.
            Extensibility:
            New types of books (e.g., AudioBook) can be easily added by creating new derived classes.
            Maintainability:
            Any changes to common properties or methods need to be updated only in the base class.
            Specialization:
            Each derived class can add or override functionality specific to its type, demonstrating the 
            power of polymorphism.
            */
            #endregion

            #endregion


        }
    }
}

