using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
             

                int years_of_experience = 0;
                // This variable will gather the user input
                Console.WriteLine("How many years of experience you have");
                // Assign the number of years the user has input to the years_in_sales variable
                years_of_experience = int.Parse(Console.ReadLine());

                switch (years_of_experience)
                    {
                        case 0:
                            Console.WriteLine("You need a lot of practice!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Little expert, but still not there!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Wow, you been doing this for a while!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("Wow you are an expert!");
                            Console.WriteLine("However, if are here because you did not type an integer value for the number of years - Please enter an integer value next time ...");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                    }
                }
                  catch
            {
                Console.WriteLine("Please use a decimal data type for your sales amount next time...");
                Console.WriteLine("--- OR ---");
                Console.WriteLine("Please use an integer data type for your number of years in sales next time ...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }

    }
}
