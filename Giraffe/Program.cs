using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    /*
     * Internal, in C#, is a keyword used to declare the accessibility, the access is limited to the assembly in which it is declared
     * Class is just a container to store bunch of codes
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring arrays
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            string[] friends = new string[2];
            //Declaring the variables
            string name = "Akash" + " Das";
            char n = 'a';
            float k = 0;//accurate
            double l = 0.5;//more accurate
            decimal m = 0; //most accurate
            int age = 22;
            bool flag = false;
            Console.Write("Enter your name ");
            name = Console.ReadLine();
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            //Lines of Code
            Console.WriteLine("Hello " + name); //Console is the window where we can see the output
            Console.WriteLine("Length " + name.Length);
            Console.WriteLine("I am " + age + " years old");
            add(1, 2);
            Console.ReadLine();
        }
        static void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
