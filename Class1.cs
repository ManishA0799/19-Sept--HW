using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class__Rectangle_HW
{
    internal class Class1
    {

        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap(ref a, ref b); // call by ref / address
            Console.WriteLine($"a = {a}  b= {b}");
        }




    out
    static void Calculation(int a, int b, out int sum, out int sub, out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;
        }
        static void Main(string[] args)
        {
            int a = 30, b = 40, sum, multiply, sub;
            Calculation(a, b, out sum, out sub, out multiply);
            Console.WriteLine($"sum ={sum}  sub={sub}  multiplication {multiply}");
        }





        // params
       
            static void AcceptNames(params string[] names)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }
            static void Main(string[] args)
            {
                AcceptNames("Manish", "Jack", "Hill");
                AcceptNames("Manish", "Jack");
                AcceptNames("Manish", "Jack", "Hill", "Jill");
            }

       


    }


    
}
