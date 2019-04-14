using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!\n");
                    while (true)
                    {
                        Console.WriteLine();
                        Console.Write("Enter Length: ");
                        decimal length = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Width: ");
                        decimal width = decimal.Parse(Console.ReadLine());

                        decimal area = length * width;
                        decimal perimeter = 2 * (length * width);

                        Console.WriteLine("Area: " + area);
                        Console.WriteLine("Perimeter: " + perimeter);
                        Console.WriteLine();
                    

                        while (true)
                        {
                            Console.WriteLine();
                            Console.Write("Continue? (y/n): ");
                            string answer = Console.ReadLine();
                            if (answer == "y")
                            break;
                            if (answer == "n")
                            return;
                            Console.ReadKey();
                        }

                    }
                    
                }  
                
                
            }
            
        }
    }
}
