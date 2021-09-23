using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = DateTime.Now;

            //Console.WriteLine(d1);
            //Console.WriteLine("date is "+d1.ToShortDateString());
            //Console.WriteLine("time is " + d1.ToShortTimeString());
            //Console.WriteLine();
            //Console.WriteLine("Hello Good Morning");
            // n1 = Convert.ToInt32(Console.ReadLine());
            //n2= Convert.ToInt32(Console.ReadLine());
            //int n1, n2, res;
            //Console.WriteLine("enter two numbers");
            //n1 = int.Parse(Console.ReadLine());
            //n2=int.Parse(Console.ReadLine());
            //res = n1 + n2;
            //Console.WriteLine("THE SUM IS "+res);
            //res = n1 - n2;
            //Console.WriteLine("THE DIFFERENCE IS "+res);
            //res = n1 * n2;
            //Console.WriteLine("THE PRODUCT IS "+res);
            //res = n1 / n2;
            //Console.WriteLine("THE QUOTIENT IS "+res);

            //Console.WriteLine("Enter another number");
            //int n3 = int.Parse(Console.ReadLine());
            //if (n3 % 2 == 0)
            //    Console.WriteLine(n3 + " is an even number");
            //else
            //    Console.WriteLine(n3 + " is an odd number");
            //Console.WriteLine("enter a 4 digit number");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (n > 0) {
            //    int n2 = n % 10;
            //    sum = sum + n2;
            //    n = n / 10;
            //}
            //Console.WriteLine("THE SUM OF THE DIGITS IS " + sum);

            //Console.ReadLine();
            //Console.WriteLine("ENTER A NUMBER ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++) {
            //    for (int j = 1; j <= ((n-i)+1); j++) {
            //        Console.Write("*"+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("ENTER A NUMBER ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i == 1 || i == n) {
            //        for (int j = 1; j <= n; j++)
            //        {
            //            Console.Write("*"+" ");
            //        }
            //    }
            //    else {
            //        for (int j = 1; j <=n; j++)
            //        {
            //            if (j == 1 || j == n)
            //            {
            //                Console.Write("*"+" ");
            //            }
            //            else {
            //                Console.Write(" "+" ");
            //            }
            //        }
            //    }

            //    Console.WriteLine();
            //}
            //int i, j;

            //for (i = 1; i <= n; i++)
            //{
            //    for (j = 1; j <= n - i; j++)
            //        Console.Write(" ");

            //    for (j = 1; j <= i; j++)
            //        Console.Write("* ");

            //    Console.Write("\n");
            //}
            int[,] m1 = new int[3, 3];



            Console.WriteLine("Enter elements of the array");



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }



            Console.WriteLine("-----------------------------");
            Console.WriteLine("Elements of the array are");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sum of right diagonal elements");
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum = sum+m1[i, j];
                    }
                    else {
                        continue;

                    }
                }
            }
            Console.WriteLine(sum);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sum of left diagonal elements");
            int sum1 = 0;
            int m = 3;
            for (int i = 0; i < 3; i++)
            {
                m = m - 1;
                for (int j = 0; j < 3; j++)
                {
                    if (j== m)
                    {
                        sum1 = sum1 + m1[i, j];
                    }
                    else
                    {
                        continue;

                    }
                }
            }
            Console.WriteLine(sum1);
            Console.ReadLine();
        }
        
    }
 
}
