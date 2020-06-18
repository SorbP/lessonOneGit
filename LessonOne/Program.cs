using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace LessonOne
{
     public class Program 
    {
        static int[] array = new int[3];
        public static int IntValue = 9;

        

        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter size of Array:-");
            a = int.Parse(Console.ReadLine());

            Program.array = new int[a];
            Console.WriteLine("Enter the Elements of the Array:-");
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    int v = int.Parse(Console.ReadLine());
                    Console.WriteLine("ok");
                    Program.ArrayInput(i, v);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
            Console.WriteLine("\nThe Elemets of the Array are:-");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }

            Program.SortArray();

            Array.ForEach(array, Console.WriteLine);


            Console.ReadLine();
        }

        public static void SortArray()
        {
            Array.Sort(array);
        }

        public static void ArrayInput(int index, int value)
        {
            Program.array[index] = value;
        }

        public static int[] GetArray()
        {
            return Program.array; 
        }
    }
}
