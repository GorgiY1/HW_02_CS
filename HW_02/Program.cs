using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== 1 =================");
            //int A, B, C;

            //Console.WriteLine("This programme counts squares with side C that fit in rectangle A * B");
            //Console.WriteLine("Input three numbers A, B, C and A and B should be more than C!");

            //do
            //{
            //    Console.Write("Enter number A: ");
            //    A = int.Parse(Console.ReadLine());

            //    Console.Write("Enter number B: ");
            //    B = int.Parse(Console.ReadLine());

            //    Console.Write("Enter number C: ");
            //    C = int.Parse(Console.ReadLine());

            //    if (C > A)
            //    {
            //        Console.WriteLine("Error! A should be more then C!");
            //    }
            //    if (C > B)
            //    {
            //        Console.WriteLine("Error! B should be more then C!");
            //    }

            //} while (C > A && C > B);


            //int amount_square = (int)(A / C) * (int)(B / C);

            //Console.Write("Amount squares: ");
            //Console.WriteLine(amount_square);
            //Console.Write("The rest of the area: ");
            //Console.WriteLine((A*B)-(C*C*amount_square));

            Console.WriteLine("================== 2 =================");

            //float P = 0;

            //do
            //{
            //    Console.Write("Enter percent P: ");
            //    P = float.Parse(Console.ReadLine());

            //    if (P < 0)
            //    {
            //        Console.WriteLine("Error! P should be more then 0!");
            //    }
            //    if (P > 25)
            //    {
            //        Console.WriteLine("Error! P should be less then 25!");
            //    }

            //} while (P<0 || P>25);

            
            //float sum = 10000;
            //for (int i = 0; sum < 11000; i++)
            //{
            //    sum += sum*P/100;
            //    Console.WriteLine("{0} :{1}",i,sum);
            //}

            Console.WriteLine("================== 3 =================");

           // int A, B;

           //Console.WriteLine("Input three numbers A, B and B should be more than A!");

           // do
           // {
           //     Console.Write("Enter number A: ");
           //     A = int.Parse(Console.ReadLine());

           //     Console.Write("Enter number B: ");
           //     B = int.Parse(Console.ReadLine());

           //     if (B < A)
           //     {
           //         Console.WriteLine("Error! B should be more then A!");
           //     }
                
           // } while (B < A);

           // for (int i = A; i <= B; i++)
           // {
           //     for (int j = 0; j < i; j++)
           //     {
           //         Console.Write("{0} ",i);
           //     }
           //     Console.WriteLine();
           // }

            Console.WriteLine("================== 4 =================");

            int num;

            Console.WriteLine("Input number: ");

            Console.Write("Enter number num: ");
            num = int.Parse(Console.ReadLine());

            int[] arr = new int[200];
            for (int i = 0; num != 0; i++)
            {
                arr[i] = num % 10;
                num = num / 10;
                Console.Write("{0} ",arr[i]);
            }

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
