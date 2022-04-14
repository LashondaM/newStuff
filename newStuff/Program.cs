using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // SCENARIO 1
            try
            {
                /* Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2); */
            }
            catch(Exception e) // This parameter is used to get more information about the error that occured
            {
                Console.WriteLine(e.Message); // This Tells us what went wrong when we have the Exception e print out the exception method
            }


            // SCENARIO 2
            try
            {
                /* Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2); */
            }
            catch (DivideByZeroException e) // We can also specify specific exceptions we want this catch block to catch
            {
                Console.WriteLine(e.Message); //Now this will only catch exceptions whenever we try to divide by zero, but will ignore other different exceptions in the console we didn't specify here
            } // but the other different exceptions will stop the program and show up in the code instead of the console


            // SCENARIO 3
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e) // We can add more catches for different specific exceptions we want to see in the console
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //optional
                // Any code inside the finally block will be executed no matter what, even if there are exceptions. So if you still want to execute something, you'll put it in here
                //can also search C# exception lists online
            }

            Console.ReadLine();

        }
    }
}
