using System;

namespace MultipleCatchBlock
{
    class Program
    {
            static void Main()
            {
                int a, b, c;
                Console.WriteLine("ENTER ANY TWO NUBERS");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("C VALUE = " + c);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("second number should not be zero");
                }
                catch (FormatException)
                {
                    Console.WriteLine("enter only integer numbers");
                }
                Console.ReadLine();
            }
        }
    }


