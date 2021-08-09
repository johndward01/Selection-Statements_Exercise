using System;
using System.Collections.Generic;
using System.Text;

namespace Selection_Statements_Exericse_01_Answers
{
    internal class Util
    {
        public static void CreateStatementBreak()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void CreateSectionBreak()
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine();
        }

        public static void CreateTitleBreak()
        {
            Console.WriteLine("======================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void PrintIfCount(int if_count, int else_count)
        {
            Console.WriteLine("The IF count is equal to the ELSE count.");
            Console.WriteLine($"if count: {if_count}");
            Console.WriteLine($"else count: {else_count}");
            Console.WriteLine();
        }

        public static void PrintElseCount(int else_count, int if_count)
        {
            Console.WriteLine("The ELSE count is not equal to the IF count.");
            Console.WriteLine($"else count: {else_count}");
            Console.WriteLine($"if count: {if_count}");
            Console.WriteLine();
        }
    }
}
