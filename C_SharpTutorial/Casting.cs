using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpTutorial
{
     class Casting
    {
        //parsing-convert string value to numerical type...but string value must only contaion digit.
        public void castingTutorial()
        {
            string a = "100";
            int b = int.Parse(a);
            Console.WriteLine(b);

            //tryParse method avoids Format exception
            string s;
            System.Console.WriteLine("Enter a number");
            s= Console.ReadLine();

            //using tryparse
          bool bl=  int.TryParse(s, out int n);
            if (bl) {
                Console.WriteLine("Conversion Successfull");
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Conversion Failed");

            }

            //conversion can be done using conversion method....
            string ch = "20010";
            int con=System.Convert.ToInt32(ch);
            System.Console.WriteLine(con);


        }



        



    }
}
