using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
       public void T1()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" THREAD 1 ");
        }

        public void T2()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" THREAD 2");

        }
        public void T3()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" THREAD 3");

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Thread t1 = new Thread(program.T1);
            Thread t2 = new Thread(program.T2);
            Thread t3 = new Thread(program.T3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
