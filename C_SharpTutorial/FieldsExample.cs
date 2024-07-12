using System;
namespace C_SharpTutorial
{
	public class Product
	{
        //fields
        public int productID;
        public string productName;
        public double cost;
        public int quantitylnStock;
        public static int totalNoOfProduct;
        public const string CategoryName = "Electronics";
        public readonly string dateOfPurchase;//readonly field should be decleared inline or either inside constructor

        public Product()
        {
            dateOfPurchase = System.DateTime.Now.ToShortDateString();
        }

        public void printProduct()
        {
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine(productID);
            System.Console.WriteLine(productName);
            System.Console.WriteLine(cost);
            System.Console.WriteLine(quantitylnStock);
            System.Console.WriteLine(dateOfPurchase);
            System.Console.WriteLine("Total No. Of Product are:"+totalNoOfProduct);
            System.Console.WriteLine("-------------------------------------------------------------------");
        }

    }

    public class DomesticProduct : Product
    {

    }
}

