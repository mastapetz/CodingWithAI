namespace CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib einen Satz ein, Ich zähle die Wörter: ");
            string userInput = Console.ReadLine();
            int wordCount = CountWords(userInput);

            if (wordCount == 1)
                Console.WriteLine($"Der eingegebene Satz hat {wordCount} Wort");
            else
                Console.WriteLine($"Der eingegebene Satz hat {wordCount} Wörter");

        }

        static int CountWords(string input)
        {
            string[] words = input.Split();     //Interpretiert den eingegebenen String als Array word, indem Leerzeichen als Trenner verwendet werden durch die Sub-Mehtode Split()

            return words.Length;                //Gibt die Länge des Arrays zurück = die Anzahl der Wörter. Bei diesem Zählen wird nicht wie der Index gezählt sondern normal (von 1 an)
                                                //daher benötigt es kein -1
        }
    }
}