namespace TravelAgency.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using TravelAgency.Data;

    public class XMLGenerator
    {
        public void XmlGenerate(TravelAgencyDbContext dbContext, string destination, string guide, string transport)
        {
            XmlTextWriter writer = new XmlTextWriter("../../../Data files/TransportReport.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            var data = this.GetData(dbContext, destination, guide, transport);

            foreach (var report in data)
            {
                this.CreateNode(report, writer);
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private IEnumerable<ReportTransport> GetData(TravelAgencyDbContext dbContext, string destination, string guide, string transport)
        {
            var excursions = dbContext
                .Excursions
                .Where(s => s.Transport.CompanyName == transport)
                .Select(x => new ReportTransport()
                {
                    ExcName = x.Name,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    CompanyName = x.Transport.CompanyName,
                    TransportType = x.Transport.Type
                })
                .ToList();

            return excursions;
        }

        private void CreateNode(ReportTransport report, XmlTextWriter writer)
        {
            writer.WriteStartElement("Excursion");
            writer.WriteStartElement("Name");
            writer.WriteString(report.ExcName);
            writer.WriteEndElement();
            writer.WriteStartElement("StartDay");
            writer.WriteString(report.StartDate.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("EndDay");
            writer.WriteString(report.EndDate.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("Trasport");
            writer.WriteString(report.CompanyName);
            writer.WriteEndElement();
            writer.WriteStartElement("TransportType");
            writer.WriteString(report.TransportType.ToString());
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
