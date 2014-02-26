namespace FizzBuzz.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numberChecker = new FizzBuzz.Library.NumberChecker();

                System.Console.WriteLine(string.Join(Environment.NewLine, numberChecker.Output()));
                System.Console.ReadLine();

                System.Console.WriteLine(string.Join(Environment.NewLine, numberChecker.Output(1, 15)));
                System.Console.ReadLine();

                System.Console.WriteLine(string.Join(Environment.NewLine, numberChecker.Output("Pork", "Chops", "Applesauce")));
                System.Console.ReadLine();

                System.Console.WriteLine(string.Join(Environment.NewLine, numberChecker.Output(1, 50, "Pork", "Chops", "Applesauce")));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                System.Console.ReadLine();
            }
        }
    }
}
