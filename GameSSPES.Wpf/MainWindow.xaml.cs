using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
        private static void Winner(Game winner, TextBlock userAction, TextBlock computerAction, TextBlock result)
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
        private async void Stein_Click(object sender, RoutedEventArgs e)
        {
            string name = User();
            Action userInput = (Action)2;
            Game winner = await GetWinner(userInput, name);
            Winner(winner, userAction, computerAction, result);
        }

        private async void Schere_Click(object sender, RoutedEventArgs e)
        {
            string name = User();
            Action userInput = (Action)1;
            Game winner = await GetWinner(userInput, name);
            Winner(winner, userAction, computerAction, result);
        }

        private async void Papier_Click(object sender, RoutedEventArgs e)
        {
            string name = User();
            Action userInput = (Action)3;
            Game winner = await GetWinner(userInput, name);
            Winner(winner, userAction, computerAction, result);
        }

        private async void Echse_Click(object sender, RoutedEventArgs e)
        {
            string name = User();
            Action userInput = (Action)4;
            Game winner = await GetWinner(userInput, name);
            Winner(winner, userAction, computerAction, result);
        }

        private async void Spock_Click(object sender, RoutedEventArgs e)
        {
            string name = User();
            Action userInput = (Action)5;
            Game winner = await GetWinner(userInput, name);
            Winner(winner, userAction, computerAction, result);
        }
        private string User()
        {
            string name = userName.Text;
            if (String.IsNullOrEmpty(name))
            {
                name = "Spieler";
            }

            return name;
        }
    }
}
