using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project8
{
     class Program
    {
        static void Main(string[] args)
        {
            bool prog = true;
            while (prog)
            {
                try
                {
                    Console.WriteLine("Введіть число");
                    int n;

                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 20)
                    {
                        CountSound countSound = new CountSound();
                        countSound.OneTwenty(n);
                    }
                    if (n > 20 && n < 100)
                    {
                        CountSound countSound = new CountSound();
                        countSound.TwentyOneHundred(n);
                    }
                    if (n >= 100 && n < 1000)
                    {
                        CountSound countSound = new CountSound();
                        countSound.OneHundedOneThousend(n);
                    }
                    if (n > 1000 && n <= 5000)
                    {
                        CountSound countSound = new CountSound();
                        countSound.OneThousendFiveThousend(n);
                    }
                    if (n > 5000 && n < 1000000)
                    {
                        CountSound countSound = new CountSound();
                        countSound.FiveThousendOneMilion(n);
                    }
                }
                catch
                {
                    prog = false;
                }
            }




            //  Thread.Sleep(1000);




            Console.ReadLine();

        }
    }
}
