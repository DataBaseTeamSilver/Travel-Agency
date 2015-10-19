namespace TravelAgency.ConsoleApp
{
    using System;
    using Logic.MySQL;

    public class Startup
    {
        public static void Main()
        {
            ////Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());

            ////var db = new TravelAgencyDbContext();

            var reader = new ReadFromSQLite();
            var t = reader.GetData();
            foreach (var item in t.Keys)
            {
                Console.WriteLine(t[item]);
            }

            ////var test = new CreateSampleExcursions();
            ////test.AddRandomNumberOfExcursion(200);
        }        
    }
}
