using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Pt_1
{
    class Program
    {
        static void Main(string[] args)

        { 
                //Enter the first number
                Console.WriteLine("Enter first number:  ");
                string value1 = Console.ReadLine();

                //Enter the second number
                Console.WriteLine("Enter second number:  ");
                string value2 = Console.ReadLine();

                
            
                //Check if number1 and number2 are numeric/numbers, if not exit application
                if (!Int32.TryParse(value1, out Int32 intValue1) || !Int32.TryParse(value2, out Int32 intValue2))
                {
                    Console.WriteLine("Enter numbers only, you provided [" + value1 + " and " + value2 + "]");
                    Environment.Exit(0);

                }

                //Check if number1 and number2 are of same digits size, if not exit application. i.e. 123 and 3253 are of size 3 and 4 respectively
                if (value1.Length != value2.Length)
                {
                    Console.WriteLine("Number lengths don't match for [" + value1 + " and " + value2 + "]");
                    Environment.Exit(0);
                }

                //Capture the first digit from the inputs value1 and value2, sum them up
                int val1 = Int16.Parse(value1.Substring(0, 1));
                int val2 = Int16.Parse(value2.Substring(0, 1));
                int sum1 = val1 + val2;

                //By default the numbers shall be valid/true
                bool isFine = true;

                //Look through remaining digits
                //Check if the sum of each of the remaining digits is the same as the first sum           
                for (int i = 1; i < value2.Length; i++)
                {
                    int val3 = Int16.Parse(value1.Substring(i, 1));
                    int val4 = Int16.Parse(value2.Substring(i, 1));
                    int sum2 = val3 + val4;

                    //If sum1 and sum2 are not equal, set to false and break out of loop
                    if (sum1 != sum2)
                    {
                        isFine = false;
                        break;
                    }
                }

                //If isFine variable is not true, then return FALSE with a message
                if (!isFine)
                {
                    Console.WriteLine("\nFALSE \nYou entered invalid numbers, they don't sum up to the same total amount: {0} and {1} ", value1, value2);
                Environment.Exit(0);
                }

                //If isFine variable is not false, then return TRUE with a message
                else
                {
                    Console.WriteLine("\nTRUE \nThank you, valid numbers {0} and {1} determined with the same total sum amount of {2} ", value1, value2, sum1);
                    Environment.Exit(0);
                }
            


            
            }
        }
    }







    

