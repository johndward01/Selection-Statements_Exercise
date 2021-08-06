using System;

namespace Selection_Statements_Exericse_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Complete all of the TODOs for the Selection Statements below
            /* There will be:
             * if statements,
             * if/else statements,                  
             * if/else if statements,
             * if/else if/else statements,
             * switch/case statements,
             * and inline-if statements 
            */


            int if_count = 0;
            int else_if_count = 0;
            int else_count = 0;
            bool var1 = true;
            bool var2 = false;



            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            if (true)
            {
                Console.WriteLine("1st if statement");
                if_count++;
            }




            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            if (false)
            {
                Console.WriteLine("2nd if statement");
                if_count++;
            }




            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            if (var1)
            {
                Console.WriteLine("3rd if statement");
                if_count++;
            }




            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            if (var2)
            {
                Console.WriteLine("4th if statement");
                if_count++;
            }



            // TODO: Call the CreateSectionBreak() function
            CreateSectionBreak();



            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            if (var2 == true)
            {
                Console.WriteLine($"if statement count{if_count}");
                if_count++;
            }
            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            else
            {
                Console.WriteLine($"else statement count{else_count}");
                else_count++;
            }




            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            if (var1 == false)
            {
                Console.WriteLine($"if statement count{if_count}");
                if_count++;
            }
            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            else
            {
                Console.WriteLine($"else statement count{else_count}");
                else_count++;
            }



            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            if (var1 == false)
            {
                Console.WriteLine($"if statement count{if_count}");
                if_count++;
            }
            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            else
            {
                Console.WriteLine($"else statement count{else_count}");
                else_count++;
            }



            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            if (var1 == false)
            {
                Console.WriteLine($"if statement count{if_count}");
                if_count++;
            }
            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console
            else
            {
                Console.WriteLine($"else statement count{else_count}");
                else_count++;
            }
        }
        private static void CreateSectionBreak()
        {
            Console.WriteLine();
            Console.WriteLine("***************************************************************");
            Console.WriteLine();
        }
    }
}
