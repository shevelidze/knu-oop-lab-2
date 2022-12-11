using System.Collections.Generic;
using System.Xml;

namespace KnuOopLab2
{
    class DomSearchStrategy : IDormitorySearchStrategy 
    {
        public DomSearchStrategy(string filePath) {
            _document = new XmlDocument();
            _document.Load(filePath);
        }

        public Inmate[] searchByAttribute(string attributeName, string pattern)
        {
            var inmateNodes = _document.DocumentElement.SelectNodes("inmate");
            var resultList = new List<Inmate>();

            foreach (XmlNode node in inmateNodes)
            {
                if (node.Attributes[attributeName].Value.ToLower().Contains(pattern.ToLower()))
                {
                    resultList.Add(new Inmate(node.Attributes["name"].Value, node.Attributes["faculty"].Value,
                        node.Attributes["year"].Value, node.Attributes["building"].Value, node.Attributes["address"].Value
                        ));
                }
            }

            return resultList.ToArray();
        }

        private XmlDocument _document;
    }
}
