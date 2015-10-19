namespace TravelAgency.Logic.MySQL
{
    using System.Collections.Generic;
    using Telerik.OpenAccess.Metadata;
    using Telerik.OpenAccess.Metadata.Fluent;
    using TravelAgency.Model;

    internal class ReportsFluentSource : FluentMetadataSource
    {
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> configurations = new List<MappingConfiguration>();

            MappingConfiguration<Report> reportConfiguration = new MappingConfiguration<Report>();

            reportConfiguration.MapType(x => new
            {
                ID = x.Id,
                Name = x.Name,
                Duration = x.Duration,
                Destination = x.Destination,
                ClientsCount = x.ClientsCount,
                TotalIncome = x.TotalIncome,
                TransportCompany = x.TransportCompany,
                TransportType = x.TransportType,
                GuideName = x.GuideName
            }).ToTable("Reports");

            reportConfiguration.HasProperty(p => p.Id).IsIdentity(KeyGenerator.Autoinc);

            configurations.Add(reportConfiguration);

            return configurations;
        }
    }
}
