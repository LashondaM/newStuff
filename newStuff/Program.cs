using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(11, 1, 4));
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;

            //if(num1 > num2)
            //{
            //    result = num1;
            //}
            //else
            //{
            //    result = num2;
            //}

            //return result;
        }
    }
}
 