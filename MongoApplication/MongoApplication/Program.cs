using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using Newtonsoft;

namespace MongoApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            retrive(args).Wait();
            Console.ReadLine();
        }

        private static async Task retrive(string[] args)
        {
            //private static void Main(string[] args)
            //  {
            //         var conString = "mongodb://loalhost:27017";
            var Client = new MongoClient();
            var DB = Client.GetDatabase("test1");
            var collection = DB.GetCollection<members>("members");

            //var doc = new members
            //{
            //    uid = "M10",
            //    name = "console",
            //    phone = "34124141"
            //};
            //collection.InsertOneAsync(doc);
            //Console.ReadLine();
            var list = await Client.GetDatabase("test1")
                 .GetCollection<BsonDocument>("members")
                 .Find(new BsonDocument())
                 .ToListAsync();

            var jsonWriterSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict }; // convert to json
                                                                                                    // Console.WriteLine(list.ToJson(jsonWriterSettings));
            foreach (var docs in list)
            {
                Console.WriteLine(docs);
                Console.WriteLine(docs.ToJson(jsonWriterSettings));
            }
        }
    }
}