using System;
delegate void NumberChanger(int n); 
namespace DelegateAppl
{
    class TestDelegate
    {
        

        static int num = 1;  
      public static void AddNum(int p)
        {
            num += p;
           
        }
        public static void  MultNum(int q)
        {
            num *= q;
           
        }
        public static int GetNum()
        {
            return num;
        }
    }
  

    class program

    {
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(TestDelegate.AddNum);
            //calling the methods using the delegate objects
            nc1(4);

            nc1 += new NumberChanger(TestDelegate.MultNum);
            nc1(5);
   
            Console.WriteLine("Value of Num: {0}", TestDelegate.GetNum()); 
            Console.ReadKey();
        }
    }
}