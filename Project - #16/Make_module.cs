using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class sampleClass
    {
        public static int x;         
        public int y;
        // Статический конструктор  
        static sampeClass()
        {             
            x = 1;         
        }
        // Обычный конструктор         
        public sampleClass()
        {
            y = 12;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Access to x: " + sampleClass.x);
            sampleClass obj = new sampleClass();
            Console.WriteLine("Access to y: " + obj.y);
        }
    }
}