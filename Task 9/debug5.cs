using System;
using System.Security.Cryptography.X509Certificates;

namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        public int  result {get; set;}
        DivNumbers()
        {
            result = 0;//define num1 and num2 too and result need a datatype 
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException ex) {
               Console.WriteLine("Exception caught: " +ex.Message);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main()
        {
            DivNumbers d = new DivNumbers();
            d.division(2,0);//pass parameters it cannot be empty d.division(2,0);
            Console.ReadKey();
        }
    }
}
