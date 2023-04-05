namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            string reversedStr = "";
            int strLength;

            Console.WriteLine("Geben sie ein Wort ein, um zu testen ob es ein Paldindrome ist: ");
            str = Console.ReadLine();
            str = str.ToLower();

            strLength = str.Length - 1;

            for (int i = strLength; i >= 0; i--)
            {
                reversedStr = reversedStr + str[i];
            }

            Console.WriteLine($"Das eingegebene Wort war: {str}");


            Console.WriteLine($"Das Umgedrehte Wort: {reversedStr}");

            if (str == reversedStr)
            {
                Console.WriteLine("Ist ein Palindrom");
            }

            else
            {
                Console.WriteLine("Ist kein Palindrom");
            }

        }
    }
}