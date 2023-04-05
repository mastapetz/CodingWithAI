namespace LargestSmallerNumber
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] integerArray = { 1, 2, 3, 4, 5 }; //Erstellung des Arrays
            int target = 4;
            int result = GetLargestSmallerNumber(integerArray, target); //Aufruf Funktion und übergabe der Werte

            Console.WriteLine($"Bei Vorgegebenen Zahlen Array  und dem zu Vergleichende Ziel {target}");
            Console.WriteLine($"Ist die Größte Nummer die kleiner als das Ziel ist {result}");
            Console.WriteLine("------------------------------------------------");
            /*
             * Gibt unrichtiges Ergebnis, weil Funktion nicht auf negative Zahlen ausgelegt ist
             * 
            int[] integerArray2 = { -1, -2, -3, -4, -5 }; //Erstellung des Arrays
            int target2 = -4;
            int result2 = GetLargestSmallerNumber(integerArray2, target2); 

            Console.WriteLine($"Bei Vorgegebenen Zahlen Array  und dem zu Vergleichende Ziel {target2}");
            Console.WriteLine($"Ist die Größte Nummer die kleiner als das Ziel ist {result2}");

            */

        }

        static int GetLargestSmallerNumber(int[] integerArray, int target)  //Erstellung Funktion
        {
            int largestSmallerNumber = 0;  //Gibt kleinste Nummer vor
                                           //von ChatGPT vorgegeben -1
                                           //Vermutung: Funktioniert nur mit Positiven zahlen
                                           //Probe: Funktioniert nur mit Positiven zahlen. Müsste für negative Zahlen angepasst werden 

            foreach (int num in integerArray) //for methode  für Arrays, läuft durch jeden Eintrag  im Array
            {
                if (num < target && num > largestSmallerNumber)     //Wenn num (der Eintrag im Array) kleiner als die Zielnummer ist
                                                                    //und auch größer als die größte Nummer die kleiner als das Ziel ist
                {
                    //Console.WriteLine(num);
                    largestSmallerNumber = num;                     //ist sie die neuste Größte Nummer
                }
            }
            return largestSmallerNumber;
        }
    }
}