using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndependentWork23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Ftorial(n);
            Console.ReadKey();
        }
        static void Ftorial(int n) 
        {
            
            int fto=1;
            for (int i = 2; i <= n; i++) 
            {
                fto = fto * i;
                Thread.Sleep(500);
            }
            Console.WriteLine(fto);
        }
        static async void FtorialAsunc(int n) 
        {
            await Task.Run(() => Ftorial(n));
        }
    }
}
