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

            // Use these variables for the IF & IF/ELSE statements
            int if_count = 0;
            int else_if_count = 0;
            int else_count = 0;
            bool var1 = true;
            bool var2 = false;

            #region IF Statements

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

            #endregion

            #region IF/ELSE Statements

            // TODO: Call the CreateSectionBreak() function for the different selection statement sections
            Console.WriteLine("IF/ELSE Statements");
            Util.CreateSectionBreak();



            // TODO: Which statement gets run? The IF or ELSE statement?
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console 
            if (true)
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



            // TODO: Which statement gets run? The IF or ELSE statement?
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



            // TODO: Which statement gets run? The IF or ELSE statement?
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



            // TODO: Which statement gets run? The IF or ELSE statement?
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing it to the console
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



            // TODO: Which statement gets run? The IF or ELSE statement?
            // TODO: What will be printed to the console?
            // TODO: Check your anwer by printing the count to the console
            if (var2 != var1)
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



            // TODO: Which statement gets run? The IF or ELSE statement?
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

            #endregion


            Console.WriteLine("IF/ELSE IF/ELSE Statements");
            Util.CreateSectionBreak();


            // Use these variables for the IF / ELSE IF / ELSE statements
            int x = 10;
            double y = -.0221;
            string z = "abc";
            if_count = 0; // resetting the value to 0 (re-initializing the variable to 0)
            else_count = 0; // reset
            else_if_count = 0; // reset



            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement?
            // TODO: What will be printed to the console?
            if (x == 0)
            {
                Console.WriteLine($"x equals 0");
            }
            else if (x > 0)
            {
                Console.WriteLine($"x is greater than 0");
            }
            else
            {
                Console.WriteLine($"x is less than 0");
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement?
            // TODO: What will be printed to the console?
            if (y > 0 || z.Contains('c'))
            {
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }
            else if (x == 10)
            {
                else_if_count++;
                Console.WriteLine($"else if statement count: {else_if_count}");
            }
            else
            {
                else_count++;
                Console.WriteLine($"else statement count: {else_count}");
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement?
            // TODO: What will be printed to the console?
            if (y > 0 || z.Contains('c'))
            {
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }
            else if (x == 10)
            {
                else_if_count++;
                Console.WriteLine($"else if statement count: {else_if_count}");
            }
            else
            {
                else_count++;
                Console.WriteLine($"else statement count: {else_count}");
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement?
            // TODO: What will be printed to the console?
            if (if_count > else_if_count && if_count > else_count)
            {
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }
            else if (else_if_count > if_count && else_if_count > else_count)
            {
                else_if_count++;
                Console.WriteLine($"else if statement count: {else_if_count}");
            }
            else
            {
                else_count++;
                Console.WriteLine($"else statement count: {else_count}");
            }

            Util.CreateStatementBreak();
        }

        
    }
}
