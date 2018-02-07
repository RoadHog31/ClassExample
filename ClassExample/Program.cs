using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassExample
{
    class Program
    {
        static void Main(string[] args )
        {
            Die die1 = new Die();
            Console.Out.WriteLine(die1);
            
            for (int i = 0; i < 10; i++)
            {            
              die1.roll();
              Console.WriteLine(die1); 
            }
            Console.ReadLine();
        }


    }
}

