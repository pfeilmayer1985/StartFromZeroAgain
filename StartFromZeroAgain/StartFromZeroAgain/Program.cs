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
            Console.WriteLine("I will replace now all 'U' and 'u' letters with 'G' and 'g' !");
            string mynewtext = mytext.Replace("U", "G").Replace("u", "g");
            Console.WriteLine($"Your new text is : {mynewtext}");
            */

            //Aufgabe 4: Frage den Nutzer nach einem Text und gebe die Länge des eingegebenen Textes aus z.B. „Die Länge des eingegebenen Texts ist 7"
            /*
            
            Console.Write("Your text is : ");
            string mytext = Console.ReadLine();
            Console.WriteLine($"Your text is {mytext.Length} characters long.");
            */

            //Aufgabe 2b: Frage den Nutzer nach zwei Fließkommazahlen und addiere diese
            /*
            Console.Write("Your first number is : ");
            double Zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your second number is : ");
            double Zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"The sum of {Zahl1} and {Zahl2} is : {Zahl1 + Zahl2}");
            */

            //Aufgabe 5: Frage den Nutzer nach einer Texteingabe und fülle diese mit bis zu 20 Stellen mit einem y von links auf
            /*
            Console.Write("Your text is : ");
            string mytext = Console.ReadLine();
            Console.WriteLine("I will add 'y' up to the first 20 charachers of your text !");
            Console.WriteLine($"Your new text is : {mytext.PadLeft(20, 'y')}");
            */

            //Aufgabe 6: Frage den Nutzer nach einer Texteingabe und fülle diese mit bis zu 30 Stellen mit einem y von rechts auf und gebe den veränderten Text wieder aus

            /*
            Console.Write("Your text is : ");
            string mytext = Console.ReadLine();
            Console.WriteLine("I will add 'y' up to the last 30 charachers of your text !");
            Console.WriteLine($"Your new text is : {mytext.PadRight(30, 'y')}");
            */

            //Aufgabe 7: Frage den Nutzer nach einer Texteingabe ( es sollen davor und danach Leerzeilen sein) und gebe die Eingabe ohne Leerzeichen wieder aus
            /*
            Console.Write("Input a text with many spaces before and after : ");
            string mytext = Console.ReadLine();
            Console.WriteLine($"Yout original text is : **|{mytext}|**");
            Console.WriteLine("I will erase all the spaces now !");
            Console.WriteLine($"Your TRIMMED text is : **|{mytext.Trim()}|**");
            */

            //Aufgabe 8: Frage den Nutzer nach einer Eingabe mit Semikolons ( ; ) und Splitte die Eingabe an diesem Zeichen. Gebe die einzelnen Werte auf der Console aus.

            /*
            Console.Write("Input random words. Use semicolon ';' as separator  : ");
            string mytext = Console.ReadLine();
            string[] myNewArray = mytext.Split(';');
            //foreach (string s in myNewArray) 
            //{ Console.WriteLine(s); }
            for (int i = 0; i < myNewArray.Length; i++)
            {
                Console.WriteLine(myNewArray[i]);
            }
            */

            //Aufgabe 9: Frage den Nutzer nach einer Eingabe und überprüfe die Texteingabe des Nutzers, ob die Zeichen „abc“ in der Eingabe
            //enthalten sind. Gebe true oder false auf der Konsole aus.

            /*
            Console.Write("Your text is : ");
            string mytext = Console.ReadLine();
            bool whatif = mytext.Contains("abc");
            if (whatif)
            {
                Console.WriteLine("Your text contains the 'abc' chars !");
            }
            else
            {
                Console.WriteLine("Your text does not contain the 'abc' chars !");
            }
            */

            //Aufgabe 10: Frage den Nutzer nach einer Texteingabe und gebe den Text in kompletten groß bzw. kompletten Kleinbuchstaben aus

            /*
            Console.Write("Your text is : ");
            string mytext = Console.ReadLine();
            Console.WriteLine($"Your text in UPPERCASE : {mytext.ToUpper()}");
            Console.WriteLine($"Your text in lowercase : {mytext.ToLower()}");
            */




            Console.ReadLine();

        }
    }
}
