using System;
using System.Collections.Generic;
namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //var firstName = "Jane";
            //var lastName = "Doe";
            //var weight = 150;
            //Console.WriteLine($"Hello {firstName} your full name is {firstName} {lastName} and you are {weight} LB!");

            Console.WriteLine("Input from user: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " greater than or equal to nine";
            }

            Console.WriteLine(response);

        }
    }
}
