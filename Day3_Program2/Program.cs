// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
ElectronicProduct newObj1 = new ElectronicProduct();
newObj1.ProductID = 101;
newObj1.ProductName = "TV";
newObj1.DisplayProduct_Name_Details();
newObj1.ShowElectronicProductDetails();
Console.WriteLine("Abstract classs in action");


class ElectronicProduct:Product
{
    public override void DisplayProduct_Name_Details()
    {
        Console.WriteLine("Electronic Product name:" + ProductName);
        Console.WriteLine("Electronic Product name:" + ProductID);
    }
    public void ShowElectronicProductDetails()
    {
        Console.WriteLine("This is an electronic product from child class");
    }
}


