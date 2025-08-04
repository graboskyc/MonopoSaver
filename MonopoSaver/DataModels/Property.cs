using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MonopoSaver.DataModels
{
    [BsonIgnoreExtraElements]
    class Prop
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("color")]
        public string Color { get; set; }
        [BsonElement("isMortgaged")]
        public int isMortgaged { get; set; }
        [BsonElement("houses")]
        public int Houses { get; set; }
        [BsonElement("ownable")]
        public bool Ownable { get; set; }
        [BsonElement("colorName")]
        public string ColorName { get; set; }

        public Prop()
        {
            Name = "";
            Color = "#000000";
            ColorName = "Black";
            isMortgaged = 0;
            Houses = 0;
            Ownable = true;
        }
    }
}