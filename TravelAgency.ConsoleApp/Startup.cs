﻿namespace TravelAgency.ConsoleApp
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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());
            var db = new TravelAgencyDbContext();
        }        
    }
}
