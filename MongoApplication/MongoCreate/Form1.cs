using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoCreate
{
    public partial class Form1 : Form
    {
        DB_connection connection = new DB_connection();
        IMongoDatabase DB = connection.DB_connet();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            uidTextBox.Clear();
            nameTextBox.Clear();
            phoneTextBox.Clear();
            IdtextBox.Clear();
            SelectResultTextBox.Clear();
            ConditionTextBox.Clear();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
          //  var Client = new MongoClient();
          //  var DB = Client.GetDatabase("test1");
            var collection = DB.GetCollection<Member>("members");
            var doc = new Member
            {
                uid = uidTextBox.Text,
                name = nameTextBox.Text,
                phone = phoneTextBox.Text
            };
            collection.InsertOneAsync(doc);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var Client = new MongoClient();
            var DB = Client.GetDatabase("test1");
            var collection = DB.GetCollection<Member>("members");
            var updateresult = collection.UpdateOneAsync(
                                Builders<Member>.Filter.Eq("uid", uidTextBox.Text),
                                Builders<Member>.Update.Set("name", nameTextBox.Text));
            var updateresult1 = collection.UpdateOneAsync(
                                  Builders<Member>.Filter.Eq("uid", uidTextBox.Text),
                                  Builders<Member>.Update.Set("phone", phoneTextBox.Text));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var Client = new MongoClient();
            var DB = Client.GetDatabase("test1");
            var collection = DB.GetCollection<Member>("members");
            var Delone = collection.DeleteOneAsync(Builders<Member>.Filter.Eq("uid", uidTextBox.Text));
        }

        private async void SelectButton_Click(object sender, EventArgs e)
        {
            SelectResultTextBox.Clear();
            var Client = new MongoClient();
            var DB = Client.GetDatabase("test1");
            var collection = DB.GetCollection<Member>("members");

            if (ConditionTextBox.Text.Length == 0)
            {
                var list = await Client.GetDatabase("test1")
                   .GetCollection<BsonDocument>("members")
          .Find(new BsonDocument())//ConditionCombobox.SelectedItem,//"uid", ConditionTextBox.Text
                  .Sort(Builders<BsonDocument>.Sort.Descending(ConditionCombobox.SelectedItem.ToString()))
          .ToListAsync();
                var jsonWriterSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict }; // convert to json

                foreach (var docs in list)
                {
                    docs["_id"] = docs["_id"].ToString();
                    SelectResultTextBox.Text = Convert.ToString(docs.ToJson(jsonWriterSettings)) + "\r\n" + SelectResultTextBox.Text;
                }
            }
            else
            {
                var list = Client.GetDatabase("test1")
                                 .GetCollection<BsonDocument>("members")
                                 .Find(new BsonDocument("uid", ConditionTextBox.Text))
                                 .ToList();
                var jsonWriterSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict }; // convert to json
                var doc = list[0];

                IdtextBox.Text = doc["_id"].ToString();
                uidTextBox.Text = doc["uid"].ToString();
                nameTextBox.Text = doc["name"].ToString();
                phoneTextBox.Text = doc["phone"].ToString();

                //  SelectResultTextBox.Text = Convert.ToString(list.ToJson(jsonWriterSettings));
            }
        }
    }
}