
namespace GameLibrary
{
    public class Game
    {
        public string userName { get; set; }
        public Action userAction { get; set; }
        public Action computerAction { get; set; }
        public Result result { get; set; }
    }
}
