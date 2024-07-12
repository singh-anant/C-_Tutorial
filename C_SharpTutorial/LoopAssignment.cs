using System;
namespace C_SharpTutorial
{
	public class LoopAssignment
	{
		public void iterateUsingLoop()
		{
			// 1 2 3 4 7 8 9 10
			// 1 2 3 4 7 8 9 10
			// 1 2 3 4 7 8 9 10
			// 10 9 8 7 6 5 4 3 2 1
			// 10 9 8 7 6 5 4 3 2 1
			// 10 9 8 7 6 5 4 3
			// 10 9 8 7 6 5 4 3 2 1
			// 1 2 3 4 5 6 7 9 10
			for (int i = 1; i <=10; i++)
				System.Console.Write(i + " ");

            System.Console.WriteLine();

            for (int i = 1; i <=10; i++)
                System.Console.Write(i + " ");
            System.Console.WriteLine();


            for (int i = 1; i <=10; i++)
                System.Console.Write(i + " ");
            System.Console.WriteLine();


            for (int i = 10; i >=1; i--)
                System.Console.Write(i + " ");
            System.Console.WriteLine();


            for (int i = 10; i >= 1; i--)
                System.Console.Write(i + " ");
            System.Console.WriteLine();



            for (int i = 10; i >= 1; i--)
			{
				if (i == 2)
					break;
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();


            for (int i = 10; i >= 1; i--)
                System.Console.Write(i + " ");

            System.Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                if (i == 8)
                    continue;
                System.Console.Write(i + " ");
            }
        }
	}
}

