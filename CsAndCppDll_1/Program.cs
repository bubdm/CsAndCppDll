using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CsAndCppDll_1
{
    class Program
    {
        public const string CppFunctionsDLL = @"..\..\..\Debug\CppFunctions.dll";

        [DllImport(CppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddNumbers(int a, int b);

        [DllImport(CppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SubtractNumbers(int a, int b);

        static void Main(string[] args)
        {
            int input1, input2;

            Console.WriteLine("Input number 1:");

            if (!int.TryParse(Console.ReadLine(), out input1))
            {
                Console.WriteLine("Bad input. Setting input1 to 5.");
                input1 = 5;
            }

            Console.WriteLine("Input number 2:");

            if (!int.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("Bad input. Setting input2 to 10.");
                input2 = 10;
            }

            int addition = AddNumbers(input1, input2);
            int subtraction = SubtractNumbers(input1, input2);

            Console.WriteLine(String.Format("Addition: {0} + {1} = {2}", input1, input2, addition));
            Console.WriteLine(String.Format("Subtraction: {0} + {1} = {2}", input1, input2, subtraction));

            Console.ReadLine();
        }
    }
}
