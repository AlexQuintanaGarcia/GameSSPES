using GameSSPES.WebApi;
using System;
using System.Collections.Generic;
using System.Web.Http;
using GameLibrary;
using Action = GameLibrary.Action;

namespace GameSSPES.WebApi.Controllers
{

    public class GameController : ApiController
    {
        public IHttpActionResult GetWinner(Action choice, string name)
        {
            Random number = new Random();
            Action computerChoice = (Action) number.Next(1, 6);
            Result winner = rules[ActionCombination(choice, computerChoice)];

            var game = new Game { userName = name, userAction = choice, computerAction = computerChoice, result = winner };
            return Ok(game);
        }

        private static string ActionCombination(Action action1, Action action2)
        {
            return action1.ToString() + action2.ToString();
        }

        static Dictionary<string, Result> rules = new Dictionary<string, Result> {
                { ActionCombination(Action.Schere, Action.Schere), Result.Draw },
                { ActionCombination(Action.Schere, Action.Stein), Result.Lost },
                { ActionCombination(Action.Schere, Action.Papier), Result.Won },
                { ActionCombination(Action.Schere, Action.Echse), Result.Won },
                { ActionCombination(Action.Schere, Action.Spock), Result.Lost },
                { ActionCombination(Action.Stein, Action.Schere), Result.Won },
                { ActionCombination(Action.Stein, Action.Stein), Result.Draw },
                { ActionCombination(Action.Stein, Action.Papier), Result.Lost },
                { ActionCombination(Action.Stein, Action.Echse), Result.Won },
                { ActionCombination(Action.Stein, Action.Spock), Result.Lost },
                { ActionCombination(Action.Papier, Action.Schere), Result.Lost },
                { ActionCombination(Action.Papier, Action.Stein), Result.Won },
                { ActionCombination(Action.Papier, Action.Papier), Result.Draw },
                { ActionCombination(Action.Papier, Action.Echse), Result.Lost },
                { ActionCombination(Action.Papier, Action.Spock), Result.Won },
                { ActionCombination(Action.Echse, Action.Schere), Result.Lost },
                { ActionCombination(Action.Echse, Action.Stein), Result.Lost },
                { ActionCombination(Action.Echse, Action.Papier), Result.Won },
                { ActionCombination(Action.Echse, Action.Echse), Result.Draw },
                { ActionCombination(Action.Echse, Action.Spock), Result.Won },
                { ActionCombination(Action.Spock, Action.Schere), Result.Won },
                { ActionCombination(Action.Spock, Action.Stein), Result.Won },
                { ActionCombination(Action.Spock, Action.Papier), Result.Lost },
                { ActionCombination(Action.Spock, Action.Echse), Result.Lost },
                { ActionCombination(Action.Spock, Action.Spock), Result.Draw },
            };
    }
}
