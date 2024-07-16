using C_SharpTutorial;

class Solution
{
    static void Main()
    {

       // ExamplePro example = new ExamplePro();
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
        p1.setProductID(1001);
        p1.setProductName("Mobile");
        p1.setCost(20000);
        p1.setQuantityInStock(1200);
        p1.calculateTax();


        p2.setProductID(1002);
        p2.setProductName("Laptop");
        p2.setCost (45000);
        p2.setQuantityInStock (3400);
        p2.calculateTax();


        p3.setProductID(1003);
        p3.setProductName ("Speakers");
        p3.setCost (36000);
        p3.setQuantityInStock(800);
        p3.calculateTax();


        System.Console.WriteLine("Total Quantity:"+ Product.totalQuantityProduct(p1,p2,p3));


        double per = 54.22;

        new MethodsTutorial().checkingRef(ref double per);


        // System.Console.WriteLine(p1);
        p1.printProduct();
        p2.printProduct();
        p3.printProduct();


    }
}