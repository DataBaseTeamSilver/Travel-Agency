namespace TravelAgency.Logic
{
    using System;
    using System.Data.SQLite;

    public class ReadFromSQLite
    {
        public void ReadDataFromSQLLite()
        {
            SQLiteConnection.CreateFile("TravelAgency.sqlite");
            SQLiteConnection dataBaseConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dataBaseConnection.Open();
            string sql1 = "select * from Expenses";
            SQLiteCommand command1 = new SQLiteCommand(sql1, dataBaseConnection);
            SQLiteDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ID - {0} Hotel - {1}, Transport - {2}", reader["ExpensesId"], reader["HotelExpenses"], reader["TransportExpenses"]);
            }
        }
    }
}
