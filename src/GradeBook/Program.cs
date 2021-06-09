using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);

            // double x = 23.3;
            // double y = 15.5;
            // var z = x + y;
            // Console.WriteLine($"Sum of two floating numbers is : {z}");

            // var numbers = new double[2];
            // numbers[0] = 12.33;
            // numbers[1] = 23.34;
            // var result = numbers[0] + numbers[1];
            // Console.WriteLine($"Sum of two floating numbers is : {result}");

            // var numbers = new double[2] { 23.23, 34.45 };
            // here we are saying I am going to have a variable
            // grades with a type of List that hold double
            // new List<double>() here we are initalizing the 
            // new List double & the () parenthesis is used to 
            // invoke the method to create a List of array.    
            List<double> grades = new List<double>() { 23.23, 34.45 };
            //  OR
            var gradess = new List<double>() { 23.23, 34.45 };
            grades.Add(45.23);
            Console.WriteLine(grades.Count);
            var result = 0.0;
            var average = 0.0;

            // var newResult = numbers1[0] + numbers1[1];
            // Console.WriteLine($"Sum of two floating numbers is : {newResult}");
            // foreach (var number in numbers)
            foreach (var number in grades)
            {
                result += number;
            }
            average = result / grades.Count;
            Console.WriteLine($"The average of number is:{average:N2}");
            // N2 telling the program needed a floating point or Precesion
            // for the average  is length of 2  
            Console.WriteLine($"The result of the number is: {result:N3}");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello,s {args[0]}!");
            }

            else
            {
                Console.WriteLine("Hello Greetings!");
            }
        }
    }
}
