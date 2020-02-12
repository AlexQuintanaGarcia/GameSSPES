namespace GameSSPES.WebApi.Models
{
    public class Game
    {
        public string userName { get; set; }
        public int userAction { get; set; }
        public int computerAction { get; set; }
        public string result { get; set; }
    }
}