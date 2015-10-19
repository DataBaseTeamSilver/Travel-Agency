namespace TravelAgency.Logic.MySQL
{
    using System.Data.Entity;
    using System.Linq;
    using Telerik.OpenAccess;
    using TravelAgency.Data;

    public class MySqlImporter
    {
        public void UpdateDatabase(TravelAgencyDbContext db)
        {
            using (var reportsContext = new ReportsFluentModel())
            {
                var schemaHandler = reportsContext.GetSchemaHandler();
                this.EnsureDB(schemaHandler);

                var allReports = db.Excursions
                .Select(x => new Report()
                {
                    Id = x.ExcursionId,
                    Name = x.Name,
                    Duration = (int)DbFunctions.DiffDays(x.StartDate, x.EndDate),
                    Destination = x.Destination.Country,
                    ClientsCount = x.Clients,
                    TotalIncome = x.PricePerClient * x.Clients,
                    TransportCompany = x.Transport.CompanyName,
                    TransportType = x.Transport.Type.ToString(),
                    GuideName = x.Guide.Name,
                    ExpenseId = x.ExpenseId
                }).ToList();

                var reportNames = reportsContext.GetAll<Report>().Select(x => x.Name).ToList();
                foreach (var report in allReports)
                {
                    if (!reportNames.Contains(report.Name))
                    {
                        reportsContext.Add(report);
                    }
                }

                reportsContext.SaveChanges();
            }
        }

        private void EnsureDB(ISchemaHandler schemaHandler)
        {
            string script = null;
            if (schemaHandler.DatabaseExists())
            {
                script = schemaHandler.CreateUpdateDDLScript(null);
            }
            else
            {
                schemaHandler.CreateDatabase();
                script = schemaHandler.CreateDDLScript();
            }

            if (!string.IsNullOrEmpty(script))
            {
                schemaHandler.ExecuteDDLScript(script);
            }
        }
    }
}
