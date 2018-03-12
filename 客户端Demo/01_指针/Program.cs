using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_指针
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                uint u = 3;
                byte b = 8;
                double d = 10.0;
                uint* pUint = &u;
                byte* pByte = &b;
                double* pDouble = &d;
                Console.WriteLine((uint)pUint);
                pUint++;
                Console.WriteLine((uint)pUint);
                pUint = pUint + 2;
                Console.WriteLine((uint)pUint);
                //--Console.WriteLine((int) pByte);
            }
            Console.ReadKey();
        }
    }
}
