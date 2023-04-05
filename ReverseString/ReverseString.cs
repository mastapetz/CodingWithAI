namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben sie ein Wort ein, welches umgekehrt ausgegeben werden soll: ");
            string inputString = Console.ReadLine();
            string reversedString = ReverseString(inputString);

            Console.WriteLine("Das eingegebene Wort umkehrt ist " + reversedString);
        }

        static string ReverseString(string input)
        {
            string reversal = "";
            for (int i = input.Length - 1; i >= 0; i--)       //Das -1 wird benötigt, da der Index bei 0 beginnt und der index des letzten  charcters (bei strings)  length-1 ist
                                                              //Das Wort 'Hello' hat 5 Buchstaben, der letzte Buchstabe ist aber auf index 4.
                                                              //Ohne das -1 würden wir bei einem nicht existierenden Index anfangen und zu einem OutOfRange exception kommen (getestet)
            {
                reversal += input[i];
            }
            return reversal;
        }
    }
}