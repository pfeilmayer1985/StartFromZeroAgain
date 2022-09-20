using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartFromZeroAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe 1 initialisiere 2 Zahlen und gebe die Summe der Zahlen auf der Console aus

            /*
              int Zahl1 = 10;
            int Zahl2 = 20;
            int Zahl3 = Zahl1+Zahl2;
            Console.WriteLine(Zahl3);
            */

            //Aufgabe 2: Frage den Nutzer welche zwei Zahlen er addieren möchte und gebe am Ende das Ergebnis aus

            /*
            Console.Write("Your first number is : ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your second number is : ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"The sum of {Zahl1} and {Zahl2} is : {Zahl1+Zahl2}");
            */

            //Aufgabe 3: Frage den Nutzer nach einem Text und ersetze im Text alle vorkommenden „U“ und „u“ durch „G“ und „g“

            /*
            Console.Write("Your original text is : ");
            string mytext = Console.ReadLine();
            Console.WriteLine("I will replace now all 'U' and 'G' letters with 'u' and 'g' !");
            string mynewtext = mytext.Replace("U", "u").Replace("G", "g");
            Console.WriteLine($"Your new text is : {mynewtext}");
            */

            //Aufgabe 4: Frage den Nutzer nach einem Text und gebe die Länge des eingegebenen Textes aus z.B. „Die Länge des eingegebenen Texts ist 7"
            Console.Write("Your text is : ");
            string mytext = Console.ReadLine();
            Console.WriteLine($"Your text is {mytext.Length} characters lnog.");



            Console.ReadLine();

        }
    }
}
