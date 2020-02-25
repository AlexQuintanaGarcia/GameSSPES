using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows;
using GameLibrary;
using Action = GameLibrary.Action;

namespace GameSSPES.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static HttpClient client = new HttpClient();
        
        public MainWindow()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("https://localhost:44376/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }

        static async Task<Game> GetWinner(Action userInput, string userName)
        {
            Game winner = null;
            var response = await client.GetAsync("api/Game/" + userInput + "/" + userName);
            if (response.IsSuccessStatusCode)
            {
                winner = await response.Content.ReadAsAsync<Game>();
            }
            return winner;
        }
        private void Winner(Game winner)
        {

            userAction.Text = $"{winner.userName}, du wählst {winner.userAction}";
            computerAction.Text = $"Computer wählt {winner.computerAction}";

            switch (winner.result)
            {
                case Result.Draw:
                    result.Text = "Unentschieden";
                    break;
                case Result.Lost:
                    result.Text = "Du hast verloren :(";
                    break;
                case Result.Won:
                    result.Text = "Du hast gewonnen!!";
                    break;
                default:
                    throw new Exception("Das hätte nicht passieren sollen!");
            }
        }
        private async void RunAsync(Action userInput)
        {
            string name = userName.Text;
            if (String.IsNullOrEmpty(name))
            {
                name = "Spieler";
            }
            Game winner = await GetWinner(userInput, name);
            Winner(winner);
        }
        private void Schere_Click(object sender, RoutedEventArgs e)
        {
            Action userInput = Action.Schere;
            RunAsync(userInput);
        }
        private void Stein_Click(object sender, RoutedEventArgs e)
        {
            Action userInput = Action.Stein;
            RunAsync(userInput);
        }
        private void Papier_Click(object sender, RoutedEventArgs e)
        {
            Action userInput = Action.Papier;
            RunAsync(userInput);
        }
        private void Echse_Click(object sender, RoutedEventArgs e)
        {
            Action userInput = Action.Echse;
            RunAsync(userInput);
        }
        private void Spock_Click(object sender, RoutedEventArgs e)
        {
            Action userInput = Action.Spock;
            RunAsync(userInput);
        }
    }
}
