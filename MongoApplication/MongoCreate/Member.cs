using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCreate
{
    public class Member
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("uid")]
        public string uid { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("phone")]
        public string phone { get; set; }
    }
}