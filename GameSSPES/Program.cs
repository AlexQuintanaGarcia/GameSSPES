using System;

namespace GameSSPES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Wilkommen bei Schere, Stein, Papier, Echse, Spock
                ");
            Console.WriteLine("Die Regeln: \nSchere schneidet Papier, \nPapier bedeckt Stein, \nStein zerquetscht Echse, \nEchse vergiftet Spock, \nSpock zertrümmert Schere, \nSchere köpft Echse, \nEchse frisst Papier, \nPapier widerlegt Spock, \nSpock verdampft Stein. \nUnd wie gewöhnlich – Stein schleift Schere. \n ");
            Console.Write("Bitte schreiben Sie Ihre Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hallo {0}, bitte wählen Sie ein nummer: 1. Schere, 2. Stein, 3. Papier, 4. Echse, 5. Spock", userName);


            Console.ReadKey();
        }
    }
}
