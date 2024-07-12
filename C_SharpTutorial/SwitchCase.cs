using System;
namespace C_SharpTutorial
{
	public class SwitchCase
	{
		
     public  void usingSwitch()
		{
            int number = 2;

            switch (number)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                    Console.WriteLine("Number is 3");
                    break;
                default:
                    Console.WriteLine("Number is not 1, 2, or 3");
                    break;
            }
        }
    }
}

