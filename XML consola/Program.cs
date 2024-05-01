using System;
using System.Xml;

namespace appReadXML_From_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            String URLString;
            XmlReader reader;
            URLString = "https://www.w3schools.com/xml/cd_catalog.xml";
            reader = XmlReader.Create(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        while (reader.MoveToNextAttribute()) 
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: 
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: 
                        Console.WriteLine("</" + reader.Name + ">");
                        break;
                }
            }
        }
    }
}
