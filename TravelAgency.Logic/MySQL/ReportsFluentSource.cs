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

            MappingConfiguration<Excursion> reportConfiguration = new MappingConfiguration<Excursion>();

            reportConfiguration.MapType(x => new
            {
                Id = x.ExcursionId,
                Name = x.Name,
                Destination = x.Destination.Country,
                ClientsCount = x.Clients,
                TotalIncome = x.PricePerClient * x.Clients,
                TransportCompany = x.Transport.CompanyName,
                TransportType = x.Transport.Type.ToString(),
                GuideName = x.Guide.Name
            }).ToTable("Reports");

            reportConfiguration.HasProperty(p => p.ExcursionId).IsIdentity(KeyGenerator.Autoinc);

            configurations.Add(reportConfiguration);

            return configurations;
        }
    }
}
