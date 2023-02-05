using System.Text;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Cüt yerdə duran rəqəmlər 
            Console.WriteLine("Ededi daxil edin");
            int eded = int.Parse(Console.ReadLine());
            int count = (int)Math.Log10(eded);
            int r, sum = 0;

            for (int i = count; i  >=1; i--)
            {
                r = eded % 10;
                eded /= 10;
                if (i % 2 == 0) continue ;
                sum += r * r;

            }
            Console.WriteLine(sum);

            //while (eded != 0)
            //{
            //    r = eded % 10;
            //    eded /= 10;
            //    if (sum % 2 == 0)
            //    {
                   
            //        Console.WriteLine(r);
                   
            //    }
            //    sum++;
            //   while (eded != 0)
            //    {
            //        sum += r * r;
                    
            //    }
            //    Console.WriteLine(sum);
            //}
            

            #endregion

            #region task 2
            //Console.WriteLine("Ededi daxil edin");
            //int eded = int.Parse(Console.ReadLine());
            //int count = (int)Math.Log10(eded) + 1;
            //int r, sum = 0;

            //while (eded != 0)
            //{
            //    r = eded % 10;
            //    eded /= 10;
            //    sum += r * count;
            //    count--;
            //}
            //Console.WriteLine(sum);
            #endregion


            #region task 3

            //Console.WriteLine("Ededi daxil edin");
            //int eded = int.Parse(Console.ReadLine());
            //int count = (int)Math.Log10(eded) + 1;
            //int r1,r2;
            //int tmp;
            //bool muxtelif = true;
            //while (eded!=0)
            //{
            //    r1 = eded % 10;
            //    eded /= 10;
            //    tmp = eded;
            //    while(tmp!=0)
            //    { r2 = tmp % 10;
            //        tmp /= 10;
            //        if (r1 == r2)
            //        {
            //            Console.WriteLine("muxtelif reqemli deyil");
            //            muxtelif = false;
            //            break;

            //        }

            //    }

            //}

            #endregion
        }
    }
}