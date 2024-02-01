using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.cl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //Console.WriteLine("Enter the weather");
            //int weather = int.Parse(Console.ReadLine());

            //if(weather < 0)
            //{
            //    Console.WriteLine("Freezing weather");
            //}
            //else if (weather >0 && weather < 15)
            //{
            //    Console.WriteLine("Cold weather");
            //}
            //else if(weather > 15 && weather < 25)
            //{
            //    Console.WriteLine("Cool weather");
            //}
            //else 
            //{
            //    Console.WriteLine("Warm weather");
            //}
            //Console.ReadLine();


            // Task 2
            //Console.WriteLine("Enter the age number");
            //int age = int.Parse(Console.ReadLine());

            //if (age < 13)
            //{
            //    Console.WriteLine("Child");
            //}
            //else if (age<13 && age < 19)
            //{
            //    Console.WriteLine("Teenager");
            //}
            //else
            //{
            //    Console.WriteLine("Adult");
            //}
            //Console.ReadLine();



            // Task 3
            //Console.WriteLine("1)Celsius to Fahrenheit");
            //Console.WriteLine("2)Fahrenheit to Celsius");
            //int choice = int.Parse(Console.ReadLine());

            //if (choice==1)
            //{
            //    Console.WriteLine("enter temperature in Celsius");
            //    int celsius = int.Parse(Console.ReadLine());

            //    int fahrenheit = (celsius * 9 / 5) + 32;
            //    Console.WriteLine($"Temperature in fahrenheit: {fahrenheit} F");
            //}
            //else if(choice==2)
            //{
            //    Console.WriteLine("enter temperature in Fahrenheit");
            //    int fahrenheit = int.Parse(Console.ReadLine());

            //    int celsius = (fahrenheit - 32) * 5 / 9;
            //    Console.WriteLine($"Temperature in celsius:{celsius} C");

            //}
            //else
            //{
            //    Console.WriteLine("enter 1 or 2");
            //}
            //Console.ReadLine();


            // Task 4
            //int[] numbers = { 1, 3, 4, 8, 9, 10, 11, 12, };
            //int max = numbers[0];
            //int min = numbers[0];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.ReadLine();



            // Task 5
            //int[] array = { 1, 2, 3, 4, 5, };

            //Array.Reverse(array);
            //Console.WriteLine("Reverse array");
            //foreach (int value in array)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.ReadLine();




            // Task 6 
            //int[] array = { 25, 13, 44, 7, 11, };
            //int max = int.MinValue;
            //int secondMax = int.MinValue;

            //foreach (int i in array)
            //{
            //    if (i > max)
            //    {
            //        secondMax = max;
            //        max = i;
            //    }
            //    else if (i > secondMax && i<max)
            //    {
            //        secondMax = i;
            //    }
            //}

            //if(secondMax == int.MinValue)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    Console.WriteLine(secondMax);
            //}
            //Console.ReadLine(); 




            // Task 7 
            int[] array1 = { 2, 3, 4, 5,};
            int[] array2 = { 7, 8, 9, 10, };
            int lenght = Math.Min(array1.Length,array2.Length);
            int[] result = new int[lenght];

            for(int i = 0; i < array1.Length; i++)
            {
        
               result[i] = array1[i] + array2[i];
                
            }
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
