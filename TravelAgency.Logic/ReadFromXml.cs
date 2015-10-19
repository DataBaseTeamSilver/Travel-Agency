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
        }

        private IEnumerable<Guide> ReadData(XmlNodeList nodeList)
        {
            var guides = new HashSet<Guide>();

            foreach (XmlNode guide in nodeList)
            {
                var newGuide = new Guide();
                newGuide.Name = guide["name"].InnerText;
                newGuide.Experience = int.Parse(guide["skill"].InnerText);

                if (!guides.Contains(newGuide))
                {
                    guides.Add(newGuide);                
                }
            }

            return guides;
        }
    }
}
