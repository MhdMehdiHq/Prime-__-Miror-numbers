using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime____Miror_numbers
{
    internal class MirrorNumbersDemo
    {
        // اعداد آینه ای توسط کاربر 
        public static void MirrorNumbers()
        {
            Console.Write(" Enter first number : ");
            
            int num1;
            bool isNum1Right = int.TryParse(Console.ReadLine(), out num1);

            if (isNum1Right)
            {
                Console.Write(" Enter second number : ");
                int num2;
                bool isNum2Right = int.TryParse(Console.ReadLine(), out num2);
                if (isNum2Right)
                {
                    Console.WriteLine();
                    Console.Write(" The mirror numbers from {0} to {1} are : ", num1, num2);

                    Console.WriteLine("\n");

                    for (int i = num1; i <= num2; i++)
                    {
                        bool isMirror = IsMirror(i);

                        if (isMirror)
                        {
                            Console.Write(i + ",");
                            Thread.Sleep(100);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("enter true number! ");

                }
            }
            else
            {
                Console.WriteLine("enter true number! ");

            }
            
        }

        //  تابع برای تولید عدد آینه ای
        public static bool IsMirror(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number = number / 10;
            }
            return originalNumber == reversedNumber;
        }
    }
}
