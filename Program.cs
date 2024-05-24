using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! ");

            Console.Write("Write your name: ");
            string str1 = Console.ReadLine();

            Console.Write("Write your second name: ");
            string str2 = Console.ReadLine();

            Console.Write("Write your age: ");
            string str3 = Console.ReadLine();

            Console.Write("Write your weight: ");
            string str4 = Console.ReadLine();

            Console.Write("Write your height: ");
            string str5 = Console.ReadLine();

            Console.WriteLine("Name: " + str1 + "," + "Second name: " + str2 + "," + "Age: " + str3 + "," + "Weight: " + str4 + "," + "Height: " + str5);

            Console.Write("All the best! ");

            Console.ReadLine();

            double weight;
            double height;


            Console.Write("Enter your weight in killogrammes: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in meteres: ");
            string str = Console.ReadLine();
            height = Convert.ToDouble(str);
            double I = height / (weight * weight);

            Console.WriteLine("Your body mass index is: " + I);

            Console.ReadLine();
        }
    }
}