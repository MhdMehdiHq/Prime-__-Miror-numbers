using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime____Miror_numbers
{
    internal class PrimeNumbersDemo
    {
        // اعداد اول یک تا صد
        public static void PrintPrimeNumbers()
        {
            /*
             * هر عدد اول، فقط دوتا مقسوم علیه دارد..یک و خودش
             * پس ما برای اثبات این قضیه،باید عددی که داریم رو،به اعداد مابین 2 تا یکی کمتر از همان عدد تقسیم کنیم تا از اول یا غیر اول بودن آن اطمینان حاصل کنیم
             * 
             * 2 --> 2x1 , 1x2 (----)
             * 5 --> 5x1 , 1x5 (2,3,4)
             * 7 --> 7x1 , 1x7 (2,3,4,5,6)
             * 
             * بوسیله حلقه تودرتو زیر، میتوان این تقسیم هارا انجام داد
             * */
            
            for (int i = 2; i <= 100; i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    if (i < 97)
                    {
                        Console.Write( i + ", ");
                        Thread.Sleep(200);

                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
            }
        }
    }
        
}

