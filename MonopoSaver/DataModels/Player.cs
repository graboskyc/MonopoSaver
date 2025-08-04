using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MonopoSaver.DataModels
{
    [BsonIgnoreExtraElements]
    class Player
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("gamePiece")]
        public string GamePiece { get; set; }
        [BsonElement("lastPosition")]
        public string LastPosition { get; set; }
        [BsonElement("money")]
        public int Money { get; set; }
        [BsonElement("props")]
        public List<Prop> Props { get; set; }
        [BsonElement("getOutOfJailCards")]
        public int GetOutOfJailCards { get; set; }

        public Player()
        {
            Name = "";
            GamePiece = "";
            LastPosition = "";
            Money = 0;
            Props = new List<Prop>();
            GetOutOfJailCards = 0;
        }
    }
}