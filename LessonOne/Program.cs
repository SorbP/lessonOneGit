using System;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = new int[3];
            string line = Console.ReadLine();
            int value;
            value = Convert.ToInt32(line);
            array1[0] = value;
            line = Console.ReadLine();

            value = Convert.ToInt32(line);
            array1[1] = value;
            value = Convert.ToInt32(line);
            line = Console.ReadLine();
            
            value = Convert.ToInt32(line);
            array1[2] = value;
            value = Convert.ToInt32(line);
            line = Console.ReadLine();


            Array.ForEach(array1, Console.WriteLine);

            Array.Sort(array1);

            Array.ForEach(array1, Console.WriteLine);


            Console.ReadLine();
        }
    }
}
