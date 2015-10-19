﻿namespace TravelAgency.Logic.MySQL
{
    using System.Linq;

    using Telerik.OpenAccess;
    using Telerik.OpenAccess.Metadata;

    internal partial class ReportsFluentModel : OpenAccessContext
    {
        static MetadataContainer metadataContainer = new ReportsFluentSource().GetModel();

        static BackendConfiguration backendConfiguration = new BackendConfiguration()
        {
            Backend = "MySql",
            ProviderName = "MySql.Data.MySqlClient"
        };

        private const string DbConnection = "MySqlTravelAgency";

        public ReportsFluentModel()
            : base(DbConnection, backendConfiguration, metadataContainer)
        {
        }

        public IQueryable<Report> Reports
        {
            get
            {
                return this.GetAll<Report>();
            }
        }
    }
}
