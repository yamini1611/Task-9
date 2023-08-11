using System;

class SwapExample
{
    public static void Main()
    {
        int a=5, b=2;      //assign values      
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b; 
        b = a / b;
        a = a / b; //mistake  b=a-b;
        Console.Write("after swap a= " + a + " b =" + b);  // console.write("after swap a=" +a + "b =" +b);
        Console.ReadLine(); //missing
    }
}
