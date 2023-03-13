using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[31];
            Random random = new Random();
            for(int i=0; i < array.Length; i++)
            {
                array[i] = random.Next(5,60);
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }

            Console.WriteLine($"Общее кол-во осадков = {summ}");
            Console.ReadLine();
        }
    }
}
