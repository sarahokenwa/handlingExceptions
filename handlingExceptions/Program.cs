using System;

namespace handlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        label1:
            try
            {
            
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto label1;
            }
           
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto label1;
            }
           /* catch(Exception ex)
            {
                variablename = ex.GetType() + " : " + ex.Message;
            }*/
            
            Console.ReadLine();
        }
    }
}
