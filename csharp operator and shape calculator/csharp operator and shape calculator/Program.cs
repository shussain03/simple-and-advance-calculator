using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_operator_and_shape_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Brief - Create c# calculator 
                Use the following -
                    *If statements
                    *nested If statement
                    Choice of – use a prompt -
                    1.simple calculations mathematical (with operators) 
                    or 
                    2. advance calculator the area of a shape, 
                    *which shape (prompt) 
                    *specify a shape, include 3 shapes.

               research - codereview.stackexchange.com/questions/126141/first-program-a-simple-calculator
            */
            Console.WriteLine();
           
            //this variable will take all the operators //Operators ("+","-","/","*") put into an object
            int operation = 0;
            //double can be used for both decimal and single number results
            double result = 0;

            //Prompt number1
            Console.WriteLine("Type in your first number : ");
            string stringfirstNumber = Console.ReadLine();
            double firstNumber = Convert.ToDouble(stringfirstNumber);

            //Prompt number2
            Console.WriteLine("Type you second number :");
            string stringSecondNumber = Console.ReadLine();
            double secondNumber = Convert.ToDouble(stringSecondNumber);

            //Ask user operation to use
            Console.WriteLine("Enter the operation + (addition), - (subtraction), *  (multiplication), / (division) :");
            string stringOperation = Console.ReadLine();

            // Convert string choice to operators // 
           if (stringOperation == "+" || stringOperation == "addition")
           {
            operation = 1;
            }
            else if (stringOperation == "-" || stringOperation == "subtraction")
            {
            operation = 2;
            }
            else if (stringOperation == "/" || stringOperation == "multiplication")
            {
            operation = 3;
            }
            else if (stringOperation == "*" || stringOperation == "division")
            {
            operation = 4;
            }
                

           //Switch statement will do someting depending on the operator
                switch (operation)
                {
                 case 1:
                        result = firstNumber + secondNumber;
                        break;

                 case 2:
                        result = firstNumber - secondNumber;
                        break;

                 case 3:
                         result = firstNumber * secondNumber;
                         break;

                 case 4:
                         result = firstNumber / secondNumber;
                         break;
               }
            // \n - new line
            Console.WriteLine("\n Result of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result + ".");
            Console.ReadKey();

        
        }
    }
}
