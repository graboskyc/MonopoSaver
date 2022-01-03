namespace MonopoSaver.DataModels {
    class Prop {
        public string Name {get;set;}
        public string Color {get;set;}
        public int isMortgaged {get;set;}
        public int Houses {get;set;}
        public bool Ownable {get;set;}

        public Prop() {
            Name = "";
            Color = "#000000";
            isMortgaged = 0;
            Houses = 0;
            Ownable = true;
        }
    }
}