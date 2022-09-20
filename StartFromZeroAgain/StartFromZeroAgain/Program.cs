using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
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

            //Aufgabe1: Programm frägt den Nutzer nach einer Zahl z.B. 20 In der Forschleife wird bis 20 gezählt und die Werte werden immer addiert

            /*
            Console.Write("Your counter limit is : ");
            int myCounterLimit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < myCounterLimit; i++)
            {
                
                Console.WriteLine($"Your current number is : {i}");
                sum += i;
                Console.WriteLine($"The sum is : {sum}");
            }
            */

            //Aufgabe 2: Frage nach einer Zahl und zähle von dieser Rückwärts bis 0

            /*
            Console.Write("Your countdown number is : ");
            int myCountdown = Convert.ToInt32(Console.ReadLine());

            for (int i = myCountdown; i >= 0; i--)
            {
                Console.WriteLine($"Countdown is at : {i}");
            }
            */


            //Aufgabe 3: Laufe mit einer For-Schleife über die Namen der Azubis & Studenten. Wenn der Name des Azubis ein „e“ enthält, gebe den Namen aus, ansonsten nicht.

            /*
            string nameArray = "Mona,Marie,Erwin,Marcello,Jonas,Philipp,Andreas,Lukas,Johannes,Leon,Robin,Niklas,Robert,Jan";
            string[] mySplittedArray = nameArray.Split(',');

            foreach (string name in mySplittedArray)
            {
                bool nameFound = name.Contains("e");
                if (nameFound)
                { 
                Console.WriteLine(name);
                }
            }

            */

            //Wiederhole das Ganze und lass den Nutzer einen Buchstaben bestimmen, nach dem gesucht wird.

            /*
            string nameArray = "Mona,Marie,Erwin,Marcello,Jonas,Philipp,Andreas,Lukas,Johannes,Leon,Robin,Niklas,Robert,Jan";
            string[] mySplittedArray = nameArray.Split(',');
            Console.WriteLine($"Your names are : {nameArray}");
            Console.Write($"Choose a letter to search for : ");
            string mySearchCriteria = Console.ReadLine();

            foreach (string name in mySplittedArray)
            {
                bool entryFound = name.Contains(mySearchCriteria);
                if (entryFound)
                {
                    Console.WriteLine(name);
                }
            }
            */

            //Aufgabe 4: Frage den Nutzer wie viele Einträge er in einem int-Array haben möchte. Initialisiere ein int-Array von dieser
            //Größe und befülle dieses Int Array in einer Schleife, indem du den Nutzer jedes Mal frägst, welche Zahl eingetragen werden
            //soll. => Gebe anschließend alle Zahlen nacheinander nochmal aus

            /*
            Console.Write("How many entries you want in your int-Array : ");
            int userEntries = Convert.ToInt32(Console.ReadLine());

            int[] myDefinedArray = new int[userEntries];
            
            for (int i = 0; i < myDefinedArray.Length; i++)
            {
                Console.Write($"Enter numer {i + 1} : ");
                myDefinedArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < myDefinedArray.Length; i++)
            {
                Console.Write($"{myDefinedArray[i]}, ");
            }
            */

            //Aufgabe 4b) Gehe das Int-array durch und gebe den Maximal-Wert aus, Minimal-Wert und den Durchschnitt.

            /*
            Console.Write("How many entries you want in your int-Array : ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] theNewArray = new int[arraySize];

            for (int i = 0; i < theNewArray.Length; i++)
            {
                Console.Write($"Enter numer {i + 1} : ");
                theNewArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < theNewArray.Length; i++)
            {
                Console.Write($"{theNewArray[i]}, ");
            }

            Console.WriteLine($"The smallest entry in the array is : {theNewArray.Min()}.");
            Console.WriteLine($"The bigest entry in the array is : {theNewArray.Max()}.");
            Console.WriteLine($"The average entry in the array is : {theNewArray.Average()}.");
            */



            //Aufgabe 5: Fizz-Buzz-Spiel: Gehe alle Zahlen von 1 bis 100 durch. Ist die Zahl ein
            //Vielfaches von 3 [(Bedingung: index % 3 == 0) => % ist der Modulo Operator, welcher den
            //Rest einer Division angibt.] dann gebe Fizz aus, ist die Zahl ein Vielfaches von 5 gebe Buzz aus,
            //und wenn die Zahl ein Vielfaches von 5 und 3 (=> z.B. 15) gebe FizzBuzz anstatt die Zahl aus.

            /*
            for (int i = 1; i < 101; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }

                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            //While Schleife -> Ratespiel

            /*
            Console.Write("Enter a number : ");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            bool gameState = true;

            Random random = new Random();
            int computerNumber = random.Next(0, 10);

            do
            {
                if (userGuess == computerNumber)
                {
                    Console.WriteLine("You WON !");
                    gameState = false;
                }

                else if (userGuess > computerNumber)
                {
                    Console.WriteLine("Try a smaller number");
                    Console.Write("Try your luck again :");
                    userGuess = Convert.ToInt32(Console.ReadLine());

                }
                else if (userGuess < computerNumber)
                {
                    Console.WriteLine("Try a biger number");
                    Console.Write("Try your luck again :");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (gameState);

            */

            //Frage den Nutzer nach seinem Namen. Wenn er keinen eingibt, Frage „hast du keinen Namen?“ und lasse den Nutzer die Eingabe erneut
            //ausführen. Zähle anschließend den Buchstaben ‚a‘ im Namen und gebe aus wie oft dieser vorkommt. Lasse den Nutzer anschließend nochmal
            //2 Zahlen eingeben, und gebe aus, welche Zahl größer ist.

            /*

            Console.Write("Your name is : ");
            string userName = Console.ReadLine();
            bool noName = true;

            do
            {
                if (userName == "")
                {
                    Console.Write("Don't you have a name ? Let's try again");
                    Console.Write("Your name is : ");
                    userName = Console.ReadLine();
                }
                else
                {
                    noName = false;
                }
            } while (noName);

            Console.WriteLine($"Your name is : {userName}");

            string[] strings = userName.Split('a');

            Console.WriteLine($"Your name contains letter 'a' {strings.Length - 1} times ");

            */

            //Aufgabe:Der Nutzer soll eine Zahl eingeben. Diese stellen die Anzahl der Sekunden dar.Konvertiere die Zahl in die
            //Anzahl der Tage, Stunden Minuten und restliche Sekunden. (90.061 => 1 Tag 1 Stunde 1 Minute 1 Sekunde )
            /*

            Console.Write("Enter a number (of seconds): ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int minutes;
            int hours;
            int days;

            days = seconds / 86400;
            hours = (seconds % 86400) / 3600;
            minutes = ((seconds % 86400) % 3600) / 60;
            seconds = ((seconds % 86400) % 3600) % 60;

            Console.WriteLine($"Days {days} Hours {hours} Minutes {minutes} and  {seconds} seconds");

            //pro version for the same issue

            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            Console.WriteLine($"Days {timeSpan.Days} Hours {timeSpan.Hours} Minutes {timeSpan.Minutes} ");
            */


            //Aufgabe: Zähle die Vorkommnisse der einzelnen Buchstaben in „MissiSsiPpi“. Groß-Kleinschreibung kann ignoriert werden.
            
            /*
            string word = "MissiSsiPpi";
            string loweWord = word.ToLower();
            int m = 0;
            int i = 0;
            int s = 0;
            int p = 0;

            foreach (char sChar in loweWord)
            {
                if (sChar == 'm')
                    m++;
                if (sChar == 'i')
                    i++;
                if (sChar == 's')
                    s++;
                if (sChar == 'p')
                    p++;
            }

            Console.WriteLine($"Occurence of the letters in the word '{word}' : m - {m}, i - {i}, s - {s}, p - {p}.");
            */




            Console.ReadLine();

        }
    }
}
