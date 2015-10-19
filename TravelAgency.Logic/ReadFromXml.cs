namespace TravelAgency.Logic
{
    using System.Collections.Generic;
    using System.Xml;

    using TravelAgency.Data;
    using TravelAgency.Logic.ImportData;
    using TravelAgency.Model;

    public class ReadFromXml
    {
        public IEnumerable<Guide> ImportFromXmlIntoSql(string path)
        {
            XmlDocument document = new XmlDocument();
            document.Load(path);

            XmlElement rootnode = document.DocumentElement;

            return this.ReadData(rootnode.GetElementsByTagName("guide"));

            //var mongoGenerator = new MongoDBGenerator();
            //mongoGenerator.InputGuides(newGuides);
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
    }
}
