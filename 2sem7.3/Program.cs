using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem7._3
{
    class Program
    {
        delegate void IsDivisible(int x);
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 100);
            foreach (int i in arr) 
            {
                IsDivisible oper = Divide;
                oper.Invoke(i);
            }
            Console.ReadKey();
        }
       
        public static void Divide(int x) 
        { 
            if (x % 3 == 0 || x % 7 == 0)
            {
                
                Console.WriteLine(x);
            }
            
        }   
    }

}
