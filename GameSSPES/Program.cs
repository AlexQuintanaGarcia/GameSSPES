using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GameSSPES
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }
        static async Task RunAsync()
        {

            client.BaseAddress = new Uri("https://localhost:44376/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            Console.WriteLine("Wilkommen bei Schere, Stein, Papier, Echse, Spock\n");

            Console.WriteLine("Die Regeln: \nSchere schneidet Papier, \nPapier bedeckt Stein, \nStein zerquetscht Echse, \nEchse vergiftet Spock, \nSpock zertrümmert Schere, \nSchere köpft Echse, \nEchse frisst Papier, \nPapier widerlegt Spock, \nSpock verdampft Stein. \nUnd wie gewöhnlich – Stein schleift Schere. \n ");

            Console.Write("Bitte schreibe deinen Name: ");

            string userName = Console.ReadLine();
            if (userName == "")
            {
                userName = "Spieler";
            }
            Console.WriteLine();

            bool playAgain = true;

            while (playAgain)
            {
                int userInput = getUserChoice(userName);
                if (userInput != 0)
                {
                    playAgain = true;
                    Game winner = await GetWinner(userInput, userName);
                    Winner(winner);
                }
                else
                {
                    playAgain = false;
                }
            }
        }
        private static int getUserChoice(string userName)
        {
            Console.WriteLine("{0}, bitte wähle zwischen:", userName);
            Console.WriteLine("1 Schere");
            Console.WriteLine("2 Stein");
            Console.WriteLine("3 Papier");
            Console.WriteLine("4 Echse");
            Console.WriteLine("5 Spock");
            Console.WriteLine("0 Spiel beenden");
            string userInput = Console.ReadKey(true).KeyChar.ToString();

            if (int.TryParse(userInput, out int result))
            {
                if (result >= 0 && result <= 5)
                {
                    return result;
                }
            }

            FalseAnswer();
            return getUserChoice(userName);
        }
        static async Task<Game> GetWinner(int userInput, string userName)
        {
            Game winner = null;
            var response = await client.GetAsync("api/Game/" + userInput + "/" + userName);
            if (response.IsSuccessStatusCode)
            {
                winner = await response.Content.ReadAsAsync<Game>();
            }
            return winner;
        }
        private static void Winner(Game winner)
        {
            Action userChoice = (Action)winner.userAction;
            Action computerChoice = (Action)winner.computerAction;

            Console.WriteLine("\n{0}, du wählst {1}", winner.userName, userChoice);
            Console.WriteLine();

            switch (winner.result)
            {
                case "Draw":
                    Draw(computerChoice);
                    break;
                case "Lost":
                    YouLost(computerChoice);
                    break;
                case "Won":
                    YouWon(computerChoice);
                    break;
                default:
                    throw new Exception("Das hätte nicht passieren sollen!");
            }
        }

        private static void YouWon(Action ComputerChoice)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoice);
            Console.WriteLine("Du hast gewonnen!!\n");
        }
        private static void YouLost(Action ComputerChoice)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoice);
            Console.WriteLine("Du hast verloren :(\n");
        }
        private static void Draw(Action ComputerChoice)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoice);
            Console.WriteLine("Unentschieden, nochmal\n");
        }
        private static void FalseAnswer()
        {
            Console.WriteLine("\nUngültige Option\nbitte whäle eine Nummer von 1 bis 5 oder 0, um das Spiel zu beenden\n");
        }
    }
}
