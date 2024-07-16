using System;
namespace C_SharpTutorial
{
	public class Product
	{
        //fields
        public int productID;
        public string productName;
        public double cost;
        public int quantityInStock;
        public static int totalNoOfProduct;
        public const string CategoryName = "Electronics";
        public readonly string dateOfPurchase;//readonly field should be decleared inline or either inside constructor
        public double tax;

        public Product()
        {
            dateOfPurchase = System.DateTime.Now.ToShortDateString();
        }

        //creating setters and getters
        public int getProductID()
        {
            return productID;
        }

        public void setProductID(  int productID)
        {
            this.productID = productID;
        }

        public string getProductName()
        {
            return productName;
        }

        public void setProductName(string productName)
        {
            this.productName = productName;
        }

       
        public double getCost()
        {
            return cost;
        }

        public void setCost(double cost)
        {
            this.cost = cost;
        }

        public int getQuantityInStock()
        {
            return quantityInStock;
        }

        public void setQuantityInStock(int quantityInStock)
        {
            this.quantityInStock = quantityInStock;
        }

        public void calculateTax()
        {
            if (cost <= 20000)
                tax = cost * 10 / 1000;

            else
                tax = cost * 12.5 / 1000;
        }

        public static  int totalQuantityProduct(Product p1, Product p2, Product p3)
        {
            return p1.getQuantityInStock() + p2.getQuantityInStock()+ p3.getQuantityInStock();
        }

        public void printProduct()
        {
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine(productID);
            System.Console.WriteLine(productName);
            System.Console.WriteLine(cost);
            System.Console.WriteLine(quantityInStock);
            System.Console.WriteLine(dateOfPurchase);
            System.Console.WriteLine("Total No. Of Product are:"+totalNoOfProduct);
            System.Console.WriteLine("-------------------------------------------------------------------");
        }

    }

    public class DomesticProduct : Product
    {

    }
}

