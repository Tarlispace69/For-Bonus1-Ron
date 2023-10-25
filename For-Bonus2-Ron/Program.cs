using System;

namespace For_Bonus2_Ron
{
    class Program
    {


        static void Main(string[] args)
        {
            int digit = 0, num = 0, numCopy = 0;
            bool digitInNum = false;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Enter a digit: ");
            digit = int.Parse(Console.ReadLine());

            // checking if digit is in the number
            numCopy = num;
            while (!digitInNum && numCopy > 0)
            {
                // checking each digit
                if (numCopy % 10 == digit)
                {
                    digitInNum = true;
                }
                numCopy /= 10; //movin to next digit
            }

            //adding the digit to the number if it is not present
            if (!digitInNum)
            {
                num *= 10;
                num += digit;
            }

            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
