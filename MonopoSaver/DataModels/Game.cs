using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MonopoSaver.DataModels
{
    [BsonIgnoreExtraElements]
    class Game
    {
        [BsonElement("token")]
        public string Token { get; set; }
        [BsonElement("players")]
        public List<Player> Players { get; set; }

        public Game()
        {
            Players = new List<Player>();
        }
    }
}