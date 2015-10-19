namespace TravelAgency.Logic.MySQL
{
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;

    public class ReadFromSQLite
    {
        public Dictionary<int?, int> GetData()
        {
            SQLiteConnection.CreateFile("TravelAgency.sqlite");
            SQLiteConnection dataBaseConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dataBaseConnection.Open();
            string sql1 = "SELECT * FROM Expenses";
            SQLiteCommand command1 = new SQLiteCommand(sql1, dataBaseConnection);
            SQLiteDataReader reader = command1.ExecuteReader();
            var resultExpenses = new Dictionary<int?, int>();

            while (reader.Read())
            {
                var expenseId = reader.GetInt32(0);
                var hotelExpense = reader.GetInt32(1);
                var transportExpense = reader.GetInt32(2);
          
                if (!resultExpenses.ContainsKey(expenseId))
                {
<<<<<<< HEAD
                    resultExpenses.Add(expenseId, expenseAmount);
                }

                Console.WriteLine("ID - {0} Hotel - {1}, Transport - {2}", reader["ExpensesId"], reader["HotelExpenses"], reader["TransportExpenses"]);
=======
                    resultExpenses.Add(expenseId, (hotelExpense + transportExpense));
                }             
>>>>>>> origin/master
            }

            return resultExpenses;
        }
    }
}
