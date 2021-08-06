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

            Console.WriteLine("IF, IF/ELSE, IF/ELSE IF/ELSE Statements");
            Util.CreateTitleBreak();

            Console.WriteLine("IF Statements");
            Util.CreateSectionBreak();



            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console
            if (true)
            {
                Console.WriteLine("1st if statement");
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }



            // TODO: Call the CreateStatementBreak() function for each selection statement
            Util.CreateStatementBreak();



            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console
            if (false)
            {
                Console.WriteLine("2nd if statement");
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }

            Util.CreateStatementBreak();



            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console
            if (var1)
            {
                Console.WriteLine("3rd if statement");
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }

            Util.CreateStatementBreak();



            // TODO: (True or False) Will this statement be executed? 
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console
            if (var2)
            {
                Console.WriteLine("4th if statement");
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }

            Util.CreateStatementBreak();



            // TODO: Call the CreateSectionBreak() function for the different selection statement sections
            Console.WriteLine("IF/ELSE Statements");
            Util.CreateSectionBreak();



            // TODO: Which statement gets run? The IF or ELSE IFstatement?
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console 
            if (var2 == true)
            {
                Console.WriteLine($"if statement count: {if_count}");
                if_count++;
            }
            else
            {
                Console.WriteLine($"else statement count: {else_count}");
                else_count++;
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF or ELSE IFstatement?
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console
            if (var1 == false)
            {
                Console.WriteLine($"if statement count: {if_count}");
                if_count++;
            }
            else
            {
                Console.WriteLine($"else statement count: {else_count}");
                else_count++;
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF or ELSE IFstatement?
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console
            if (var1 == false)
            {
                Console.WriteLine($"if statement count: {if_count}");
                if_count++;
            }
            else
            {
                Console.WriteLine($"else statement count: {else_count}");
                else_count++;
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF or ELSE IFstatement?
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing the count to the console
            if (var2 == false)
            {
                Console.WriteLine($"if statement count: {if_count}");
                if_count++;
            }
            else
            {
                Console.WriteLine($"else statement count: {else_count}");
                else_count++;
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF or ELSE IFstatement?
            // TODO: What will be printed to the console?
            if (if_count == else_count)
            {
                Util.PrintIfCount(if_count, else_count);
            }
            else
            {
                Util.PrintElseCount(else_count, if_count);
            }

            Util.CreateStatementBreak();



            Console.WriteLine("IF/ELSE IF/ELSE Statements");
            Util.CreateSectionBreak();


            
            // Use these variables for the next set of statements
            int x = 10;
            double y = -.0221;
            string z = "abc";
            if_count = 0;
            else_count = 0;
            else_if_count = 0;

            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement?
            // TODO: What will be printed to the console?
            if (x == 0)
            {
                Console.WriteLine($"if statement count: {if_count}");
            }

        }

        
    }
}
