using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesConsole
{
    class Program
    {
        #region Static Methods

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Display(string s)
        {
            Console.WriteLine(s);
        }

        public static decimal CalculateTieredSalesTax(decimal saleAmount)
        {
            if (saleAmount < 0.0M)
            {
                throw new ArgumentOutOfRangeException("Sale Amount must be positive");
            }
            if (saleAmount < 1000M)
            {
                return saleAmount * 0.07M;
            }
            else if (saleAmount < 5000M)
            {
                return saleAmount * 0.065M;
            }
            else
            {
                return saleAmount * 0.06M;
            }
        }

        #endregion
        
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises:");

            // A Func for adding two integers
            Func<int, int, int> methAdd = Add;
            Console.WriteLine("Add using delegate: " + methAdd(2, 6));

            // Anonymous Method Implementation
            //Func<int, int, int> anonAdd =
            //    /* Insert here */
            //Console.WriteLine("Add using anonymous method: " + anonAdd(2, 6));

            // Lambda Statement implementation
            //Func<int, int, int> stmtAdd =
            //    /* Insert here */
            //Console.WriteLine("Add using lambda statement: " + stmtAdd(2, 6));

            // Lambda Expression Implementation
            //Func<int, int, int> exprAdd = /* Insert here */
            //Console.WriteLine("Add using lambda expression: " + exprAdd(2, 6));

            Console.WriteLine("\r\n\r\n");

            // An Action for writing to the console
            Action<string> methDisplay = Display;
            methDisplay("Display with delegate");

            //Action<string> anonDisplay =
            //    /* Insert here */
            //anonDisplay("Display with anonymous method");


            //Action<string> stmtDisplay =
            //    /* Insert here */
            //stmtDisplay("Display with lambda statement");

            //Action<string> expDisplay = /* Insert here */
            //expDisplay("Display with lambda expression");

            Console.WriteLine("\r\n\r\n");

            // A Func for calculating sales tax
            Func<decimal, decimal> methTax = CalculateTieredSalesTax;
            Console.WriteLine("Sales Tax Delegate: " + methTax(1200M));

            //Func<decimal, decimal> anonTax =
            //    /* Insert here */
            //Console.WriteLine("Sales Tax Delegate: " + methTax(1200M));

            //Func<decimal, decimal> stmtTax =
            //    /* Insert here */
            //Console.WriteLine("Sales Tax Lambda Statement: " 
            //    + stmtTax(1200M));

            //Func<decimal, decimal> exprTax =
            //    /* Insert here */
            //Console.WriteLine("Sales Tax Lambda Expression: " + exprTax(1200M));

            Console.ReadLine();

        }
    }
}
