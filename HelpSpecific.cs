using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public static class HelpSpecific
    {
        internal static void BranchReturn()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Help >> BranchReturn");
            Console.WriteLine("=====\nYou can use the keyword \"done\" everytime you want to go to branch menu (e.g: Algebra). For example, in quadratic equation: ");
            Console.WriteLine(
                "System: \n"+
                "\t-----------------------------------------------\n" +
                "\t| Enter a:                                    |\n" +
                "\t-----------------------------------------------\n" +
                "Your input:\n" +
                "\t-----------------------------------------------\n" +
                "\t| Enter a: done                               |\n" +
                "\t-----------------------------------------------\n" +
                "Results:\n" +
                "\t-----------------------------------------------\n" +
                "\t| ====================                        |\n" +
                "\t| Basic Calculator                            |\n" +
                "\t| ====================                        |\n" +
                "\t| Home >> Algebra                             |\n" +
                "\t| ---                                         |\n" +
                "\t| 0. Go back                                  |\n" +
                "\t| 1. Calculate with + - * /                   |\n" +
                "\t| ...                                         |\n" +
                "\t-----------------------------------------------\n");
            Console.WriteLine("However, this does not apply to yes / no questions. For example: ");
            Console.WriteLine(
                "System: \n"+
                "\t-----------------------------------------------\n" +
                "\t| Do you want to continue? (y/n):             |\n" +
                "\t-----------------------------------------------\n" +
                "Your input:\n" +
                "\t-----------------------------------------------\n" +
                "\t| Do you want to continue? (y/n): done        |\n" +
                "\t-----------------------------------------------\n" +
                "Results:\n" +
                "\t-----------------------------------------------\n" +
                "\t| Invalid command                             |\n" +
                "\t| ...                                         |\n" +
                "\t-----------------------------------------------");
            Console.WriteLine("----------");
            Console.Write("Enter \"back\" to go back to Help: ");
            string line = Console.ReadLine();
            line = line.ToUpper();
            if (line == "BACK")
            {
                Console.Clear();
                Program.Help();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                BranchReturn();
            }
        }
        internal static void MathPrefixes()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Help >> MathPrefixes");
            Console.WriteLine("=====\nIn basic Maths, there are some prefixes and commands for you to input other mathematical operations\n-----");
            Console.Write("" +
                "pw <n> <p>    :  powers                   (e.g: pw 3 3: 3^3)\n" +
                "rt <n> <p>    :  roots                    (e.g: rt 16 2: sqrt(16))\n" +
                "ab <n>        :  absolute value           (e.g: ab -12: |-12|)\n" +
                "fa <n>        :  factorial*               (e.g: fa -4.1: 4!)\n" +
                "pi            :  pi (rounded to 3.14)     (e.g: pi: 3.14)\n" +
                "sq <n>        :  squares                  (e.g: sq 4: 4^2)\n" +
                "sr <n>        :  square roots             (e.g: sr 8: sqrt(8))\n" +
                "*: factorial only receives positive integer, if not, calculator will return factorial of the" +
                " absolute value, rounded number\n");
            Console.WriteLine("----------");
            Console.Write("Enter \"back\" to go back to Help: ");
            string line = Console.ReadLine();
            line = line.ToUpper();
            if (line == "BACK")
            {
                Console.Clear();
                Program.Help();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                MathPrefixes();
            }
        }
        internal static void QuadReturn()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Help >> QuadraticReturn");
            Console.WriteLine("=====\nWhile finding x in the Quadratic Equation section, sometimes the returning result looks something like this:\n" +
                "\t-----------------------------------------------\n" +
                "\t| x1 = NaN                                    |\n" +
                "\t| x2 = NaN                                    |\n" +
                "\t-----------------------------------------------\n" +
                " There are two reasons for this:\n" +
                "1. x1 and x2 is undefined / incalculable\n" +
                "2. x1 and x2 contain complex numbers (e.g: i) which the built-in Math function does not support complex numbers");
            Console.WriteLine("----------");
            Console.Write("Enter \"back\" to go back to Help: ");
            string line = Console.ReadLine();
            line = line.ToUpper();
            if (line == "BACK")
            {
                Console.Clear();
                Program.Help();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                MathPrefixes();
            }
        }
    }
}
