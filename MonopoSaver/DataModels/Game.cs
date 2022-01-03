namespace MonopoSaver.DataModels {
    class Game {
        public string Token {get;set;}
        public List<Player> Players {get;set;}

        public Game() {
            Players = new List<Player>();
        }
    }
}