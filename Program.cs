﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args){
            //1
            //    Console.Write("Enter number 1 : ");
            //     int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter number 2 : ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    int sum = num1 + num2;
            //    if (sum % 2 == 0 )
            //    {
            //        Console.WriteLine("Positive number ");        
            //     }
            //    else if (sum % 2 != 0 ) 
            //    {
            //        Console.WriteLine("Negative number ");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Zero ");
            //     }

            //2
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //        Console.WriteLine(numbers[i]);
            //}

            //3
            // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // int sum = 0;
            //for(int i = 1; i <= numbers.Length; i++)
            // {
            //     if (i % 2 != 0)
            //     {


            //         sum += i;
            //     }
            // }
            //Console.WriteLine(sum);  

            //4
            //Console.Write("Enter number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number <= 9999 && number > 999)
            //{
            //    int s1 = number % 10;
            //    int s2 = (number % 100 - s1) / 10;
            //    int s3 = (number % 1000 - (s2 * 10 + s1)) / 100;
            //    int s4 = number / 1000;
            //    int sum = s1 + s2 + s3 + s4;
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    Console.WriteLine("Eded 4 reqemli deyil ");
            //}

            //5
           
            
            Person p1 = new Person();
            p1.Name = "Dilshad";
            p1.SurName = "Ibrahimli";
            p1.Age = 20;
            p1.Speciality = "IT";
            p1.GroupNo = "P419";
            Person[] people = new Person[] { p1 };

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"{people[i].Name} {people[i].SurName} {people[i].Age} {people[i].Speciality}  {people[i].GroupNo} ");
            }
           

        }
    }
    
    class Person
    {
        public string Name;
        public string SurName;
        public int Age;
        public string Speciality;
        public string GroupNo;
         



}
}