using C_SharpTutorial;

class Solution
{
    static void Main()
    {

        //ExamplePro example = new ExamplePro();
        //another way of declearing object
        //SwitchCase sc =new();
        //sc.usingSwitch();

        //GotoStatement gs = new();
        //gs.testingGoto();

        //new LoopAssignment().iterateUsingLoop();

        //new Example().checkingInternalClass();

        Product.totalNoOfProduct = 0;

        Product p1, p2, p3;
        p1 = new Product();
        Product.totalNoOfProduct++;
        p2 = new Product();
        Product.totalNoOfProduct++;
        p3 = new Product();
        Product.totalNoOfProduct++;


        //initializong fields from main only....not a good practice.
        p1.productID = 1001;
        p1.productName = "Mobile";
        p1.cost = 20000;
        p1.quantitylnStock = 1200;


        p2.productID = 1002;
        p2.productName = "Laptop";
        p2.cost = 45000;
        p2.quantitylnStock = 3400;

        p3.productID = 1003;
        p3.productName = "Speakers";
        p3.cost = 36000;
        p3.quantitylnStock = 800;

       // System.Console.WriteLine(p1);
        p1.printProduct();
        p2.printProduct();
        p3.printProduct();


    }
}