/*
 * ExemptionsExamples
 * Demonstration of the use of try, catch, and finally
 * 
 * Revision History:
 *    Tony Theodoropoulos, 2023.03.08: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryCatchExamples();
            ValidatingInput();

            Console.ReadKey();
        }

        static void TryCatchExamples()
        {
            int num1, num2, answer;

            try
            {
                Console.Write("Please enter a number (1-100): ");
                num1 = Convert.ToInt16(Console.ReadLine());

                if (num1 < 1 || num1 > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                do
                {
                    Console.Write("Please enter a second number (50-150): ");
                    num2 = Convert.ToInt16(Console.ReadLine());
                } while (num2 < 50 || num2 > 150);

                answer = num1 / num2;

                Console.WriteLine($"The answer is {answer}");
            }
            catch (FormatException e)
            {
                // Console.WriteLine(e.Message);
                Console.WriteLine("Integer values only");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number was too big or too small");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Silly grandma. You can divide by 0");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number was supposed to be 1-100");
            }
            catch
            {
                Console.WriteLine("Not sure what happened, but something broke");
            }
            finally
            {
                Console.WriteLine("See you again soon.");
            }

        }

        static void ValidatingInput()
        {
            double num1, num2;

            num1 = GetDouble("Please enter your age: ");
            num2 = GetDouble("Please enter a height: ");
        }

        static double GetDouble(string userPrompt)
        {
            double num1 = 0;
            bool inputOk = false;

            do
            {
                try
                {
                    Console.Write(userPrompt);
                    num1 = Convert.ToDouble(Console.ReadLine());
                    inputOk = true;
                }
                catch
                {
                    //Console.WriteLine("ERROR");
                }
            } while (inputOk == false);

            return num1;
        }
    }
}
