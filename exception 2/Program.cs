using System;

namespace ConclaseAcademy
{
    static class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Please enter the first number");

                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number");

                int secondNumber = int.Parse(Console.ReadLine());

                var result = firstNumber / secondNumber;

                Console.WriteLine($"The result is: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Something bad happened: {ex.GetType().Name}");
                Console.WriteLine($"Something bad happened: {ex.Message}");
                Console.WriteLine($"Something bad happened: {ex.StackTrace}");
                //throw;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Something bad happened: {ex.GetType().Name}");
                Console.WriteLine($"Something bad happened: {ex.Message}");
                Console.WriteLine($"Something bad happened: {ex.StackTrace}");
                //throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something bad happened: {ex.GetType().Name}");
                Console.WriteLine($"Something bad happened: {ex.Message}");
                Console.WriteLine($"Something bad happened: {ex.StackTrace}");
                //throw;
            }
            finally
            {
                Console.WriteLine("Finally block executed.  ");
            }

        }

        public static string Welcome(string name, string timeofTheDay)
        {
            return $"{Greet(timeofTheDay)} {GetName(name)}.";
        }

        public static string GetName(string name)
        {
            return $"{name}";
        }

        public static string Greet(string timeOfTheDay)
        {
            return $"Good {timeOfTheDay}";
        }
    }
}