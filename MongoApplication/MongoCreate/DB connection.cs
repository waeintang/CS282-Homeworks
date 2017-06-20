using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;

namespace MongoCreate
{
    public class DB_connection
    {
        protected static IMongoClient Client;
        protected static IMongoDatabase DB;
        protected static IMongoDatabase collection;

        public IMongoDatabase DB_connet()
	{
		
		Client = new MongoClient();
		DB = Client.GetDatabase("test1");
        return DB;
   	}
        
    }
}
