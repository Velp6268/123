using System;

namespace Recursia
{
    class Program
    {
       
        static int Foo(int value)
        {

            if (value < 10)
                return value;

            return value % 10 + Foo(value / 10); 
         

           
        }

        static void Main(string[] args)
        {
            


            Console.WriteLine(Foo(561));


        }
    }
}