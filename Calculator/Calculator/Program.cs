using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {



            Console.WriteLine("Welcome to simple calculator");
            Console.WriteLine("Please enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What would you like to do with the numbers");
            Console.WriteLine("Add..........");
            Console.WriteLine("Subtact.........");
            Console.WriteLine("Multiply........");
            Console.WriteLine("Divide........");

            string userChoice = Console.ReadLine();

            if (userChoice == "add")
            {
                Console.WriteLine("The result is " + (num1 + num2));
            }
            else if (userChoice == "subtract")
            {
                Console.WriteLine("The result is " + (num1 - num2));
            }
            else if (userChoice == "multiply")
            {
                Console.WriteLine("The result is " + (num1 * num2));
            }
            else if (userChoice == "divide")
            {
                Console.WriteLine("The result is " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("That is not a valid selection, press m to return to Main Menu");
                string input = Console.ReadLine();
                if(input == "m")
                {
                    Console.Clear();
                    MainMenu();
                }
                
            }
        }
        
    }
}
