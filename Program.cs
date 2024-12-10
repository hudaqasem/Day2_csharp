using System;
using System.Text;
using System.Xml.Linq;

namespace DAY1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region explain wit comment 
            //// Declare and initialize the variable x with the value 10
            //int x = 10;

            //// Declare and initialize the variable y with the value 20
            //int y = 20;

            ///* 
            //   Calculate the sum of x and y 
            //   and store the result in the variable sum 
            //*/
            //int sum = x + y;

            //// Print the value of sum to the console
            //Console.WriteLine(sum);

            /*  
                comment     ctrl + k +c 
                uncomment   ctrl + k + u
             */
            #endregion

            #region runtime & logical Errors
            //int x = 10; // change string to int value
            //int y = 10; // Declare and initialize the variable y with the value 10
            //Console.WriteLine(x + y); // Console with capital C 

            ////runtime error => Occurs during program execution
            ////string s = 2.5;

            ////logical error => The program runs but produces incorrect results
            //int a = 10;
            //int b = 20;
            //int sum = a - b;
            //Console.WriteLine(sum); 
            #endregion

            #region naming convention
            //string FullName = "Huda Qasem" ;
            //int age = 20;
            //decimal MonthlySalary = 0M;
            //bool IsStudent = true;
            ///*
            // naming convention make code more 
            // => Readability , Maintainability , Avoids Errors and Standardization 
            // */ 
            #endregion

            #region Value & Reference Type
            //string[] s1 = {"huda","m"}; // array is refrence type 
            //string[] s2 = s1;
            //s1[0] = "qasem";
            //Console.WriteLine(s2[0]);
            ///*
            // valye type => Allocated on the stack
            // reference type => Allocated on the heap, but the reference is stored on the stack
            // */ 
            #endregion

            #region calculator
            //int x = 15 , y = 4;
            ////int sum = x + y;
            ////Console.WriteLine("sum = " + sum );
            //Console.WriteLine($"sum = {x + y}");
            //Console.WriteLine($"Difference  = {x - y}");
            //Console.WriteLine($"Product = {x * y}");
            //Console.WriteLine($"Division = {x / y}");
            //Console.WriteLine($"Remainder = {x % y}"); 

            //int a = 2, b = 7;
            //Console.WriteLine(a % b);
            ///*
            // result = 2 
            // in mod if a > b then res will be a 
            // */
            #endregion

            #region greater than 
            //Console.WriteLine("Enter num : ");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 10 && num % 2 == 0)
            //    Console.WriteLine($"{num} is greater than 10 and even");
            //else
            //    Console.WriteLine($"otherwise"); 
            #endregion

            #region cast double to int 
            //double x = 10.5;
            ////int y = x; // implicit casting 
            ////Console.WriteLine(y); // not valid

            //int z = (int)x; //explicit casting 
            //Console.WriteLine(z);

            ///*
            // explicit casting(unsafe) => is required when converting a double 
            // to an int because of the loss of data due to truncation of 
            // the decimal 
            // */ 
            #endregion

            #region Check valid age
            //Console.WriteLine("Enter your age ");
            //string s = Console.ReadLine();
            //int age = int.Parse(s);
            //if (age > 0 && age < 90 )
            //    Console.WriteLine("valid age");
            //else
            //    Console.WriteLine("not valid try again");
            ///*
            // Exceptions that might occur : 
            // --- FormatException => if age = non numeric value
            // --- OverflowException => if age less than zero or greater than 90
            // How to handle ?
            // --- wa can handle Eceptions by using try & catch  
            // */ 
            #endregion

            #region prefix and postfix 
            //int x = 2;
            //Console.WriteLine(x++); // print 2  x = 3
            //Console.WriteLine(++x); // print 4  x = 4


            //int x = 5;
            //int y = ++x + x++; // y = 6 + 6
            //// x = 7 becuase ++x increase x by 1 and x++ also do the same 
            #endregion

        }
    }
}
