namespace TravelAgency.Logic.MySQL
{
    using System.Data.Entity;
    using System.Linq;

    using TravelAgency.Data;

    public class ExcelReport
    {
        private ReadFromSQLite sqliteReader;

        public ExcelReport(ReadFromSQLite reader)
        {
            this.sqliteReader = reader;
        }

        public string[,] GenerateReports(TravelAgencyDbContext db)
        {
            using (var reportsContext = new ReportsFluentModel())
            {
                var schemaHandler = reportsContext.GetSchemaHandler();

                var sqliteReports = this.sqliteReader.GetData();

                var currentReports = reportsContext.GetAll<Report>().Select(x => new
                {
                    Name = x.Name,
                    ExpenseId = x.ExpenseId,
                    Income = x.TotalIncome
                }).ToList();

                var finalReportsLength = currentReports.Count;

                string[,] finalReports = new string[finalReportsLength, 2];

                for (int i = 0; i < finalReportsLength; i++)
                {
                    var currentReport = currentReports[i];
                    foreach (var sqliteReport in sqliteReports)
                    {
                        if (sqliteReport.Key == currentReport.ExpenseId)
                        {
                            var expenseToAdd = currentReport.Income - sqliteReport.Value;
                            finalReports[i, 0] = currentReport.Name;
                            finalReports[i, 1] = sqliteReport.Value.ToString();
                        }
                    }
                }

                return finalReports;
            }
        }
    }
}
