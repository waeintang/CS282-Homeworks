﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoApplication
{
    public class members
    {
        // [BsonId]
        public ObjectId Id { get; set; }

        public string uid { get; set; }

        public string name { get; set; }

        public string phone { get; set; }
    }
}