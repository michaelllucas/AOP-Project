using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            FunWithoutAspect();

            Console.ReadLine();
        }

        [ExceptionAspect]
        public static void FunWithAspect()
        {
            throw new DivideByZeroException();
        }

        public static void FunWithoutAspect()
        {
            throw new DivideByZeroException();
        }
    }
}
