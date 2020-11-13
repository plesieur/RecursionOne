using System;

//Assignment
//
//Complete the two functions:
//  sumRecursion(n)- 
//    Which should use recursion to return
//      the sum of numbers 0 through n
//  fibonacciL(n) -
//    Which should use a loop to return the 
//	    nth value in the Fibonacci sequence, zero based
namespace RecursionOne
{
    class Program
    {

        //Factorial: 
        //  Product of an integer 'data' and all non-negative integers below it
        //  Factorial of 0 equals 1
        static int factorialLoop(int data)
        {
            int rv = 1;
            for (int i = 1; i <= data; i++)
            {
                rv = rv * i;
            }
            return rv;
        }

        static int factorialRecursion(int data)
        {
            if (data == 0)
            {
                return 1;
            }
            return data * factorialRecursion(data - 1);
        }

        //Sum:
        //  Addition of integer 'n' with all non-negative integers below it
        static int sumLoop(int n)
        {
            int rv = 0;
            for (int i = 0; i <= n; i++)
            {
                rv = rv + i;
            }
            return rv;
        }

        static int sumRecurion(int n)
        {
            return 0;   //<<<<< Delete This Line when you add your code below
            //Your Code Goes Here

        }

        //Fibonacci Sequence
        //  The next number is found by adding up the two numbers before it
        //  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
        //  Will return the nth value in the sequence, zero based
        //    n=0, returns 0
        //    n=2, returns 1
        //    n=6, returns 8
        static int fibonacciR(int n)
        {
            if (n <= 0) { return 0; }
            else if (n == 1) { return 1; }
            else { return fibonacciR(n - 1) + fibonacciR(n - 2); }
        }

        static int fibonacciL(int n)
        {
            return 0;   //<<<<< Delete This Line when you add your code below
            //Your Code Goes Here

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Factorial Integer (-1 to exit): ");
                int temp = int.Parse(Console.ReadLine());
                if (temp < 0) break;

                int resultL = factorialLoop(temp);
                int resulrR = factorialRecursion(temp);
                Console.WriteLine("Factorial of {0}= Loop:{1}  Recursion:{2}", temp, resultL, resulrR);

                resultL = sumLoop(temp);
                resulrR = sumRecurion(temp);
                Console.WriteLine("Sum of {0}= Loop:{1}  Recursion:{2}", temp, resultL, resulrR);

                Console.WriteLine("Fibonacci:\nLoop:      ");
                for (int i = 0; i <= temp; i++)
                {
                    Console.Write("{0}, ", fibonacciL(i));
                }
                Console.WriteLine("\nRecursive: ");
                for (int i = 0; i <= temp; i++)
                {
                    Console.Write("{0}, ", fibonacciR(i));
                }
                Console.WriteLine("\n");
            }
        }
    }
}
