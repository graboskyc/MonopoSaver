namespace MonopoSaver.DataModels {
    class Board {
        private List<string> _pieces {get; set;}
        private List<Prop> _places {get; set;}

        private string _rules {get;set;}

        public List<string> Pieces {get {return _pieces;}}
        public List<Prop> Places {get {return _places;}}
        public string Rules {get { return _rules;}}


        public Board(string variant = "GB") {
            _rules = @"
# Money Breakdown

*At the start of the game, distribute $1500 as follows:*

* 2 x $500
* 4 x $100
* 1 x $50
* 1 x $20
* 2 x $10
* 1 x $5
* 5 x $1
"; //https://en.wikipedia.org/wiki/Monopoly_(game)
            
            if(variant == "GB") {
                _pieces =  new List<string>() {
                    "Cello",
                    "Ecto Goggles",
                    "Glasses",
                    "PKE Meter",
                    "Proton Pack",
                    "Radio"
                };

                _places = new List<Prop>() {
                    new Prop(){Name="Go",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Reading Room", Color="#825a2c", ColorName="Brown", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Roaming Vapor 1",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Basement", Color="#825a2c", ColorName="Brown", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Library Ghost",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Ecto-1 1",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Paranormal Studies Lab", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Roaming Vapor 2",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Dana's Living Room", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Dana's Kitchen", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="In Jail",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Just Visiting Jail",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Hotel Lobby", Color="#f472d0", ColorName="Pink", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Slimer",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Twelfth Floor", Color="#f472d0", ColorName="Pink", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Ballroom", Color="#f472d0", ColorName="Pink", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Ecto-1 2",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Sleeping Quarters", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Roaming Vapor 3",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Janine's Desk", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Symphony Hall", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Free Parking",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Louis's Living Room", Color="#e51400", ColorName="Red", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Roaming Vapor 4",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Louis's Bedroom", Color="#e51400", ColorName="Red", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Tavern Restaurant", Color="#e51400", ColorName="Red", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Ecto-1 3",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Subway Entrance", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Headquarters", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Vince Clortho",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Storage Facility", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Go To Jail",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="City Hall", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Mayor's Office", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Roaming Vapor 5",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="550 Central Park West", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Ecto-1 4",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Roaming Vapor 6",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Spook Central", Color="#0050ef", ColorName="Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Stay Puft",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Temple of Gozer", Color="#0050ef", ColorName="Blue", isMortgaged=0, Ownable=true, Houses=0}
                };

            } if(variant == "Cat") {
                _pieces =  new List<string>() {
                    "Cat Food",
                    "Fish",
                    "Milk",
                    "Mouse",
                    "Sardines",
                    "Yarn"
                };

                _places = new List<Prop>() {
                    new Prop(){Name="Go",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Ocicat", Color="#a20025", ColorName="Red", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Purrfect 1",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Tonkinese", Color="#a20025", ColorName="Red", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Fleas",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Stray Cats",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Chartreux", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Cat-astrophe 1",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Somali", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Egyption Mau", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Water",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Just Prawling",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Turkish Van", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Scratch Pole",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Himalayan", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Manx", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Scaredy Cats",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="British Shorthair", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Purrfect 2",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Russian Blue", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Ragdoll", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Free Catnip",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Sphynx", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Cat-astrophe 2",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Burmese", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Norwegian Forest Cat", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Cool Cats",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="American Shorthair", Color="#0050ef", ColorName="Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Scotish Fold", Color="#0050ef", ColorName="Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Mouse",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Birman", Color="#0050ef", ColorName="Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Fall in Water",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Abyssinian", Color="#00aba9", ColorName="Teal", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Exotic", Color="#00aba9", ColorName="Teal", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Purrfect 3",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Siameset", Color="#00aba9", ColorName="Teal", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Copy Cats",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Maine Coon",  Color="#6a00ff", ColorName="Purple", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Cat-astrophe 3", Color="#000000", ColorName="Black", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Dog Tax",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Persian", Color="#6a00ff", ColorName="Purple", isMortgaged=0, Ownable=true, Houses=0}
                };

            } else {
                _pieces =  new List<string>() {
                    "Battleship",
                    "Race Car",
                    "Top Hat",
                    "Boot",
                    "Thimble",
                    "Iron",
                    "Cannon",
                    "Lantern",
                    "Purse",
                    "Rocking Horse",
                    "Dog",
                    "Wheelbarrow",
                    "Horse and Rider",
                    "Money Sack",
                    "Cat",
                    "Duck",
                    "Penguin",
                    "T-Rex"
                }; // https://en.wikipedia.org/wiki/Monopoly_(game)

                _places = new List<Prop>() {
                    new Prop(){Name="Go",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Mediterranean Ave", Color="#825a2c", ColorName="Brown", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Community Chest 1",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Baltic Ave", Color="#825a2c", ColorName="Brown", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Income Tax",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Reading RR",  Color="#000000", ColorName="RR", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Oriental Ave", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Chance 1",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Vermont Ave", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Connecticut Ave", Color="#1ba1e2", ColorName="Light Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="In Jail",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Just Visiting Jail",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="St. Charles Place", Color="#f472d0", ColorName="Pink", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Electric Co",  Color="#000000", ColorName="Utilities", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="States Ave", Color="#f472d0", ColorName="Pink", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Virginia Ave", Color="#f472d0", ColorName="Pink", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Penn RR",  Color="#000000", ColorName="RR", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="St. James Place", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Community Chest 2",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Tennessee Ave", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="New York Ave", Color="#fa6800", ColorName="Orange", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Free Parking",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Kentucky Ave", Color="#e51400", ColorName="Red", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Chance 2",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Indiana Ave", Color="#e51400", ColorName="Red", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Illinois Ave", Color="#e51400", ColorName="Red", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="B and O RR",  Color="#000000", ColorName="RR", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Atlantic Ave", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Ventnor  Ave", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Water Works",  Color="#000000", ColorName="Utilities", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Marvin Gardens", Color="#e3c800", ColorName="Yellow", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Go To Jail",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Pacific Ave", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="North Carolina Ave", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Community Chest 3",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Penn Ave", Color="#008a00", ColorName="Green", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Shortline RR",  Color="#000000", ColorName="RR", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Chance 3",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Park Place", Color="#0050ef", ColorName="Blue", isMortgaged=0, Ownable=true, Houses=0},
                    new Prop(){Name="Luxury Tax",  Color="#000000", ColorName="Black", isMortgaged=0, Ownable=false, Houses=0},
                    new Prop(){Name="Boardwalk", Color="#0050ef", ColorName="Blue", isMortgaged=0, Ownable=true, Houses=0}
                };
            }
        }
    }
}