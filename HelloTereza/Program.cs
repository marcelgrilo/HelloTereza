using System;
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
                Task.Delay(1000);
                Console.WriteLine("Hello Tereza!");
            }
        }
    }
}