namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter a positive whole number and will determine if it is a Prime number: ");
            bool isParseAble = int.TryParse(Console.ReadLine(), out input);
            bool result = IsPrime(input);
            Console.WriteLine(result ? "The number is prime" : "The number is not prime");
        }
        static bool IsPrime(int input)
        {
            if (input < 2)
            {
                return false;
            }

            int maxDivisor = (int)Math.Sqrt(input); //(int) is a cast and converts the result from Sqrt from double to int

            for (int i = 2; i <= maxDivisor; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}