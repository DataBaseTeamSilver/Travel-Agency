namespace TravelAgency.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Model;
    using MongoDB.Bson;
    using MongoDB.Driver;

    public class MongoDBImporter
    {
        private const string DatabaseHost = "mongodb://127.0.0.1";
        private const string DatabaseName = "TravelAgency";

        public void ImportData(TravelAgencyDbContext ctx)
        {
            var db = this.GetDatabase(DatabaseName, DatabaseHost);
            var transportsDocuments = db.GetCollection<BsonDocument>("Transports");
            var transportsMongo = transportsDocuments
                .FindAll()
                .Select(x => new
                {
                    CompanyName = x["CompanyName"].AsString,
                    Type = x["Type"].AsInt32
                })
                .ToList();

            var uniqueTransportNames = new HashSet<string>();

            var transportsInDB = ctx
                .Transports
                .Select(x => x.CompanyName)
                .ToList();

            foreach (var transport in transportsInDB)
            {
                uniqueTransportNames.Add(transport);
            }

            foreach (var currentTransport in transportsMongo)
            {
                if (!uniqueTransportNames.Contains(currentTransport.CompanyName))
                {
                    uniqueTransportNames.Add(currentTransport.CompanyName);

                    var transportToAdd = new Transport()
                    {
                        CompanyName = currentTransport.CompanyName,
                        Type = (TransportType)currentTransport.Type
                    };

                    ctx.Transports.Add(transportToAdd);
                }
            }

            ctx.SaveChanges();
        }

        private MongoDatabase GetDatabase(string name, string fromHost)
        {
            var mongoClient = new MongoClient(fromHost);
            var server = mongoClient.GetServer();
            return server.GetDatabase(name);
        }
    }
}
