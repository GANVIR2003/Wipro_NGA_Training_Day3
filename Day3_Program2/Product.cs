using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_Program2
{
    abstract class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public abstract void DisplayProduct_Name_Details()
   }
      
    

    void displayProductDetailsonly()
        {
            Console.WriteLine("product name" + ProductName);
        }
    }
}

