namespace MonopoSaver.DataModels {
    class Player {
        public string Name {get;set;}
        public string GamePiece {get;set;}
        public string LastPosition {get;set;}
        public int Money {get;set;}
        public List<Prop> Props {get;set;}
        public int GetOutOfJailCards {get;set;}

        public Player() {
            Name = "";
            GamePiece = "";
            LastPosition = "";
            Money = 0;
            Props = new List<Prop>();
            GetOutOfJailCards = 0;
        }
    }
}