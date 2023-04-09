/*
 Sum of Squares: Write a program that takes a positive integer input n and calculates
the sum of the squares of all integers from 1 to n. For example, if n = 3, the program should calculate 1^2 + 2^2 + 3^2 = 14.
 */
namespace SumUpSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input;
            Console.Write("Input a Number to calculate the sum of all squared integers up to given number: ");
            bool isParseAble = double.TryParse(Console.ReadLine(), out input);
            double result = SumUpSquares(input);
            Console.WriteLine("The sum of all squared integers up to given number is: " + result);
        }

        static double SumUpSquares(double inputNumber)
        {
            double sumUp = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                sumUp = sumUp + Math.Pow(i, 2);
            }
            return sumUp;



        }
    }
}