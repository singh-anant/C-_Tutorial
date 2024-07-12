using System;
namespace C_SharpTutorial
{
	public class GotoStatement
	{
		public void testingGoto()
		{
			System.Console.WriteLine("Luffy");
            System.Console.WriteLine("Ayanokoji");
            System.Console.WriteLine("Ao Asahi");
            goto myLabel;// actually goto is going to give control to the myLabel
            System.Console.WriteLine("Minato");
            System.Console.WriteLine("Sakura");
            System.Console.WriteLine("Itadori");
            myLabel:
            System.Console.WriteLine("Gojo");
            System.Console.WriteLine("Saturn");

        }
        //you can make a infinity loop out of it as well..
        //if we interchange both myLabel and goto myLabel...just think if it

    }
}

