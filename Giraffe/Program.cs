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
            // using try catch and finally block for our program
            try
            {
                //Creating an object - an instance of a class
                Book bk = new Book("AD");
                bk.title = "Theory";
                bk.author = "Hey";
                bk.pages = 225;

                //Declaring arrays
                int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
                //Declaring a 2D array
                int[,] arr2 =
                {
                    { 2, 3},
                    { 4, 5}
                };
                int[,] arr3 = new int[2, 3]; //2 - rows, 3 coloumns
                Console.WriteLine(arr2[0, 1]);
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
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //no matter what this will be executed
                Console.WriteLine("In Finally Block");

            }
            Console.ReadLine();
        }
        static void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
