using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project8
{
    internal class CountSound
    {
     private string path = @"C:/Users/bilen/OneDrive/Рабочий стол/4 курс/Розробка програмного забезпечення/Числа/";
     public   void  OneTwenty(int n){
          
            SoundPlayer sound1 = new SoundPlayer(path+n.ToString()+".wav");
            sound1.Play();
        }
     public   void TwentyOneHundred(int n) {
            int m = n-n%10;
            int k = n % 10;
            SoundPlayer sound1 = new SoundPlayer(path + m.ToString() + ".wav");
            sound1.Play();
            Thread.Sleep(1700);
            if (k != 0)
            {
                SoundPlayer sound2 = new SoundPlayer(path + k.ToString() + ".wav");
                sound2.Play();
                Thread.Sleep(1000);
            }
        }
     public void OneHundedOneThousend(int n) {
           
            int m = n % 100;
            int np100=n-n%100;
            if (m == 0)
            {
                SoundPlayer sound1 = new SoundPlayer(path + np100.ToString() + ".wav");
                sound1.Play();
                Thread.Sleep(1000);
            }
            else
            {
                SoundPlayer sound1 = new SoundPlayer(path + np100.ToString() + ".wav");
                sound1.Play();
                Thread.Sleep(1500);
                CountSound countSound = new CountSound();
                if (m <= 20) {
                    countSound.OneTwenty(m);
                }
                else
                {
                    countSound.TwentyOneHundred(m);
                }
            }
        
        }
     public void OneThousendFiveThousend(int n)
        {
            if (n > 1000 && n < 2000)
            {
                SoundPlayer sound3 = new SoundPlayer(path + "1000" + ".wav");
                sound3.Play();
                Thread.Sleep(1500);
            }
            if (n > 2000 && n < 3000)
            {
                SoundPlayer sound3 = new SoundPlayer(path + "2000" + ".wav");
                sound3.Play();
                Thread.Sleep(2300);
            }
            if (n > 3000 && n < 4000)
            {
                SoundPlayer sound3 = new SoundPlayer(path + "3000" + ".wav");
                sound3.Play();
                Thread.Sleep(2300);
            }
            if (n > 4000 && n < 5000)
            {
                SoundPlayer sound3 = new SoundPlayer(path + "4000" + ".wav");
                sound3.Play();
                Thread.Sleep(3000);
            }
           
                int m = n % 1000;
            if (m != 0)
            {
                if (m <= 20)
                {
                    CountSound countSound = new CountSound();
                    countSound.OneTwenty(m);
                }
                if (m > 20 && m < 100)
                {
                    CountSound countSound = new CountSound();
                    countSound.TwentyOneHundred(m);
                }
                if (m >= 100 && m < 1000)
                {
                    CountSound countSound = new CountSound();
                    countSound.OneHundedOneThousend(m);
                }
            }
            else
            {
                if (n == 1000 )
                {
                    SoundPlayer sound3 = new SoundPlayer(path + "1000" + ".wav");
                    sound3.Play();
                    Thread.Sleep(1500);
                }
                if (n == 2000 )
                {
                    SoundPlayer sound3 = new SoundPlayer(path + "2000" + ".wav");
                    sound3.Play();
                    Thread.Sleep(2300);
                }
                if (n == 3000)
                {
                    SoundPlayer sound3 = new SoundPlayer(path + "3000" + ".wav");
                    sound3.Play();
                    Thread.Sleep(2300);
                }
                if (n == 4000 )
                {
                    SoundPlayer sound3 = new SoundPlayer(path + "4000" + ".wav");
                    sound3.Play();
                    Thread.Sleep(3000);
                }
            }

            }
     public void FiveThousendOneMilion(int n)
     {
                int m = n / 1000;
                
            int k = n % 1000;
                if (m <= 20)
                {
                    CountSound countSound = new CountSound();
                    countSound.OneTwenty(m);
                }
                if (m > 20 && m < 100)
                {
                    CountSound countSound = new CountSound();
                    countSound.TwentyOneHundred(m);
                }
                if (m >= 100 && m < 1000)
                {
                    CountSound countSound = new CountSound();
                    countSound.OneHundedOneThousend(m);
                Thread.Sleep(2000);
            }
            SoundPlayer sound3 = new SoundPlayer(path + "Тисяч" + ".wav");
            sound3.Play();
            Thread.Sleep(1500);
            if (k <= 20)
            {
                CountSound countSound = new CountSound();
                countSound.OneTwenty(k);
            }
            if (k > 20 && k < 100)
            {
                CountSound countSound = new CountSound();
                countSound.TwentyOneHundred(k);
            }
            if (k >= 100 && k < 1000)
            {
                CountSound countSound = new CountSound();
                countSound.OneHundedOneThousend(k);
            }


        }
     

    }

    }

