using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[12]; 

            //Random rnd = new Random(); 

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rnd.Next(163, 191); 
            //}

            //Console.WriteLine("Рост людей:");
            //foreach (int height in array)
            //{
            //    Console.WriteLine(height);
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}] = {array[i]}");
            //}


            //Random rnd = new Random();
            //double[] array = new double[10];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rnd.NextDouble() * (50 - (-50)) - 50; 
            //}

            //Console.WriteLine("Первый элемент: " + array[0]);
            //Console.WriteLine("Последний элемент: " + array[array.Length - 1]);


            //int[] array = new int[] { 74, 0, 50, 46, 34, 46, 0, 13 };

            //foreach (int element in array)
            //{
            //    Console.WriteLine(element);
            //}


            /* int[] array = new int[] { 74, 0, 50, 46, 34, 46, 0, 13 }; */              // Первый способ заданных чисел внутри массива
                                                                                         // int[] array = { 74, 0, 50, 46, 34, 46, 0, 13 };                      Второй способ заданных чисел внутри массива

            //foreach (int element in array)
            //{
            //    Console.WriteLine(element);
            //    int result = element * element;
            //    Console.WriteLine(result);
            //}


            //Задача 1.  Заполнить одномерный массив с клавиатуры шестью целыми числами. Вывести одномерный массив в обратном порядке.

            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++) // Последовательно
            {
                Console.Write($"array[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array.Length-1; i >= 0; i--) //    Обратно
                {
                Console.WriteLine($"array[{i}] = {array[i]}");

            }

            Console.Read();
            //3

        }
    }
}
