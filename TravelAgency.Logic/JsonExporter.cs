namespace TravelAgency.Logic
{    
    using System.Data.Entity;
    using System.IO;
    using System.Linq;

    using Newtonsoft.Json;
    using Data;

    public class JsonExporter
    {
        public void GenerateJsonFiles()
        {
            var db = new TravelAgencyDbContext();

            var allExcursion = db.Excursions
                .Select(x => new
                {
                    ID = x.ExcursionId,
                    Name = x.Name,
                    Duration = (int)DbFunctions.DiffDays(x.StartDate, x.EndDate),
                    Destination = x.Destination.Country,
                    ClientsCount = x.Clients,
                    TotalIncome = x.PricePerClient * x.Clients,
                    TransportCompany = x.Transport.CompanyName,
                    TransportType = x.Transport.Type.ToString(),
                    GuideName = x.Guide.Name
                }).ToList();

            
            foreach (var item in allExcursion)
            {
                var jsonObj = JsonConvert.SerializeObject(item, Formatting.Indented);
                var adress = "../../../" + item.ID +".json";
                File.WriteAllText(adress, jsonObj);
            }
        }
    }
}
