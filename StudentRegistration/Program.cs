using System;

namespace StudentRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Registration App! \n");

            Console.Write("Enter First Name: ");

            string fName = Console.ReadLine();

            Console.Write("Enter Last Name: ");

            string lName = Console.ReadLine();

            Console.Write("What year were you born? ");

            string bYear = Console.ReadLine();

            Console.WriteLine($"\nWelcome {fName} {lName}!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine($"Your temporary password is: {fName}*{bYear}");
        }   
    }
}
