namespace TravelAgency.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.OleDb;
    using Data;
    using Data.Migrations;
    using Logic;
    using Model;

    public class Startup
    {
        public static void Main()
        {
           
            var db = new TravelAgencyDbContext();
        }        
    }
}
