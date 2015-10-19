namespace TravelAgency.Logic
{
    using System.Collections.Generic;
    using System.Linq;

    using MongoDB.Bson;
    using MongoDB.Driver;
    using Model;

    public class MongoDBGenerator
    {
        private const string DatabaseHost = "mongodb://127.0.0.1";
        private const string DatabaseName = "TravelAgency";

        public void GenerateSampleData()
        {
            this.InsertData("Busabout", 0);
            this.InsertData("Onnibus", 0);
            this.InsertData("Alsa", 0);
            this.InsertData("Westbus", 0);
            this.InsertData("Megabus", 0);
            this.InsertData("BerlinenBus", 0);
            this.InsertData("Swebus", 0);
            this.InsertData("Eurolines", 0);
            this.InsertData("Megabus", 0);
            this.InsertData("Austrian Airlines", 1);
            this.InsertData("FlyNiki", 1);
            this.InsertData("Aeroflot", 1);
            this.InsertData("Lufthansa", 1);
            this.InsertData("Wizz Air", 1);
            this.InsertData("Ryanair", 1);
            this.InsertData("EasyJet", 1);
            this.InsertData("Finnair", 1);
            this.InsertData("Princess Cruises", 2);
            this.InsertData("Norwegian Cruise Line", 2);
            this.InsertData("Disney Cruise Line", 2);
            this.InsertData("Cunard", 2);
            this.InsertData("Silversea Cruises", 2);
            this.InsertData("Seabourn", 2);
        }

        public void InputGuides(IEnumerable<Guide> newGuides)
        {
            var db = this.GetDatabase(DatabaseName, DatabaseHost);
            var guides = db.GetCollection<BsonDocument>("Guides");

            var currentGuides = guides.FindAll()
                .Select(x => x["Name"].AsString)
                .ToList();

            foreach (var guide in newGuides)
            {
                if (!currentGuides.Contains(guide.Name))
                {
                    guides.Insert(new BsonDocument
                { 
                    { "Id", guide.GuideId },
                    { "Name", guide.Name },
                    { "Experience", guide.Experience }
                });
                }
            }
        }

        private MongoDatabase GetDatabase(string name, string fromHost)
        {
            var mongoClient = new MongoClient(fromHost);
            var server = mongoClient.GetServer();
            return server.GetDatabase(name);
        }

        private void InsertData(string companyName, int type)
        {
            var db = this.GetDatabase(DatabaseName, DatabaseHost);
            var transports = db.GetCollection<BsonDocument>("Transports");
            transports.Insert(new BsonDocument
            { 
                { "Id", ObjectId.GenerateNewId().ToString() },
                { "CompanyName", companyName },
                { "Type", type }
            });
        }
    }
}
