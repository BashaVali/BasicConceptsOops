using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptsOops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welecome To Practice Problems");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("****** Basic Concepts Oops ******");

                Console.WriteLine(" Select the option ");

                Console.WriteLine("1.Method Overloading" + "\n" +
                                  "2.Exit" + "\n");
                int check = Convert.ToInt32(Console.ReadLine());
                MethodOverLoading method = new MethodOverLoading();
                switch (check)
                {
                    case 1:
                        int sum = method.Add(2, 4, 6);
                        Console.WriteLine("sum of the three "
                                          + "integer value : " + sum);
                        double doubleSum = method.Add(1.0, 2.4, 3.0);
                        Console.WriteLine("sum of the three "
                                          + "double value : " + doubleSum);
                        break;
                      case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}

