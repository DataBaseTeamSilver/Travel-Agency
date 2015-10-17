namespace XMLGenerator
{
    using System;
    using System.Xml;

    public class XMLGenerator
    {
        public void xmlGenerate(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("exDest.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", "test 1", "1000", writer);
            createNode("2", "test 2", "2000", writer);
            createNode("3", "test 3", "3000", writer);
            createNode("4", "test 4", "4000", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        public void createNode(string pID, string pName, string pPrice, XmlTextWriter writer)
        {
            writer.WriteStartElement("Excursion");
            writer.WriteStartElement("Name");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Clients Count");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("Transport");
            writer.WriteString(pPrice);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
