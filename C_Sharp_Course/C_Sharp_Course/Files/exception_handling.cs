using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingExceptions
    {
        static void ExceptionHandling(string[] args)
        {
            try
            {
                Console.Write("Enter a Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // finally gets always executed no matter what happened before
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}