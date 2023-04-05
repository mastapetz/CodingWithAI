namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie zu Faktorierende Nummer ein: ");

            int numberInput;

            bool isParseAble = int.TryParse(Console.ReadLine(), out numberInput);   //checkt ob eine ganze Zahl eingegeben wurde,
                                                                                    //wenn ja wird sie an numberInput weitergegeben


            int numberOutput = calcFactorial(numberInput);                          //Ruft Funktion/Methode auf und gibt deren ergebnis an die neue Variable weiter

            Console.WriteLine($" {numberInput}! ergibt: {numberOutput} ");          //Gibt Ergebnis an Console aus.
        }

        static int calcFactorial(int number)
        {
            int calculationHelper = 1;                                              //Pre-definiert die Rechenvariable als 1 damit weiter damit gerechnet werden kann
                                                                                    //andere Werte führen zu falschen Ergebnis

            while (number != 1)                                                     //Führ die Faktorisierung durch bis 1 erreicht wurde,
                                                                                    //da Kopfgesteurte Schleife wird bei erreichen die Schleife nicht mehr ausgeführt
            {
                calculationHelper = calculationHelper * number;                     //Berechnung der Faktorisierung mit der eingegeben Ganzzahl als 'number'
                number--;
            }
            return calculationHelper;                                               //Retuniert das ergebnis der Berechnung
        }
    }
}