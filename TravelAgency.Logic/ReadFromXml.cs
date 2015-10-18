namespace TravelAgency.Logic
{
    using System.Collections.Generic;
    using System.Xml;

    using TravelAgency.Data;
    using TravelAgency.Model;

    public class ReadFromXml
    {
        public void ImportFromXmlIntoSql(TravelAgencyDbContext dbContext)
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../../Data files/Guides.xml");

            XmlElement rootnode = document.DocumentElement;

            var newGuides = ReadData(rootnode.GetElementsByTagName("guide"));

            InputNewGuides(dbContext, newGuides);
        }

        private IEnumerable<Guide> ReadData(XmlNodeList nodeList)
        {
            var albums = new HashSet<Guide>();

            foreach (XmlNode album in nodeList)
            {
                var guide = new Guide();
                guide.Name = album["name"].InnerText;
                guide.Experience = int.Parse(album["skill"].InnerText);
                albums.Add(guide);
            }

            return albums;
        }

        private void InputNewGuides(TravelAgencyDbContext dbContext, IEnumerable<Guide> newGuides)
        {
            foreach (var guide in newGuides)
            {
                dbContext.Guides.Add(guide);
            }

            dbContext.SaveChanges();
        }
    }
}
