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

        public void printProduct()
        {
            System.Console.WriteLine(productID);
            System.Console.WriteLine(productName);
            System.Console.WriteLine(cost);
            System.Console.WriteLine(quantitylnStock);

        }

    }

    public class DomesticProduct : Product
    {

    }
}

