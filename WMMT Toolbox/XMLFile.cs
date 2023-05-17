using System;
using System.Xml;

namespace XmlHelper
{
    public class XmlManager
    {
        private string xmlFilePath;

        public XmlManager(string filePath)
        {
            xmlFilePath = filePath;
        }

        public string ReadXmlFieldValue(string fieldName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            XmlNodeList fieldNodes = doc.GetElementsByTagName("FieldName");
            XmlNodeList valueNodes = doc.GetElementsByTagName("FieldValue");

            for (int i = 0; i < fieldNodes.Count; i++)
            {
                if (fieldNodes[i].InnerText.Trim() == fieldName)
                {
                    return valueNodes[i].InnerText.Trim();
                }
            }

            return null;
        }

        public void WriteXmlFieldValue(string fieldName, string fieldValue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            XmlNodeList fieldNodes = doc.GetElementsByTagName("FieldName");
            XmlNodeList valueNodes = doc.GetElementsByTagName("FieldValue");

            for (int i = 0; i < fieldNodes.Count; i++)
            {
                if (fieldNodes[i].InnerText.Trim() == fieldName)
                {
                    valueNodes[i].InnerText = fieldValue;
                    break;
                }
            }

            doc.Save(xmlFilePath);

            Console.WriteLine("XML文件写入成功！");
        }
    }
}
