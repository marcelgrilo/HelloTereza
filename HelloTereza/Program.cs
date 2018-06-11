using System;
using System.Threading;
using System.Threading.Tasks;

namespace HelloTereza
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Tereza!");
            while (true)
            {
                Thread.Sleep(3000);
                Console.WriteLine("Hello Tereza!");
            }
        }
    }
}