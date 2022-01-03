namespace MonopoSaver.DataModels {
    class Board {
        private List<string> _pieces {get; set;}
        private List<Prop> _places {get; set;}

        public List<string> Pieces {get {return _pieces;}}
        public List<Prop> Places {get {return _places;}}

        public Board(string variant = "GB") {
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
            } else {
                _pieces =  new List<string>() {
                    "Battleship",
                    "Car",
                    "Cat",
                    "Dog",
                    "Duck",
                    "Hat",
                    "Thimble",
                    "Penguin",
                    "T-Rex"
                };

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