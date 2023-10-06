namespace Prime____Miror_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Which one do you want ? " + "\n");
            Thread.Sleep(600);

            Console.WriteLine(" 1 : Prime numbers from 1 to 100 ");
            Thread.Sleep(600);

            Console.WriteLine(" 2 : Mirror numbers " + "\n");
            Thread.Sleep(200);

            Console.Write(" Your answer = ");

            int answer;

            bool flag = int.TryParse(Console.ReadLine(), out answer);
            if (flag == true)
            {
                if (answer == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Prime numbers from 1 to 100 are : " + "\n");

                    //استفاده از کلاس تولید شده برای نمایش اعداد اول
                    PrimeNumbersDemo.PrintPrimeNumbers();
                }
                if (answer == 2)
                {
                    // چاپ اعداد آینه ای : ورودی توسط کاربر

                    Console.WriteLine("\n" + "\n");
                    Console.WriteLine(" 'Notice': ");
                    Thread.Sleep(1000);

                    Console.WriteLine(" Mirror numbers : Here you should enter two numbers, and the system will show you the mirror numbers between them.");
                    Thread.Sleep(1000);

                    Console.WriteLine(" For a better experience, enter numbers that are far apart... Like 10 to 10000");
                    Console.WriteLine();
                    Thread.Sleep(1000);

                    //استفاده از کلاس تولید شده برای نمایش اعداد آینه ای
                    MirrorNumbersDemo.MirrorNumbers();
                }
                if (answer > 2 || answer < 1)
                {
                    Console.WriteLine(" Enter true number ! ");
                }
                
            }
            else
            {
                Console.WriteLine(" Enter true number !");
            }

            Thread.Sleep(500);
            Console.WriteLine("\n" + "\n" + "Press any key to exit the program!");
            Console.ReadKey();
        }
    }
}