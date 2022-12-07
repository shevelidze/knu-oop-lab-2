using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace KnuOopLab2
{
    class DomSearchStrategy : DormitorySearchStrategy 
    {
        public DomSearchStrategy(string filePath) {
            _document = new XmlDocument();
            _document.Load(filePath);
        }

        public Inmate[] searchByName(string namePattern)
        {
            var inmateNodes = _document.DocumentElement.SelectNodes("inmate");
            var resultList = new List<Inmate>();

            foreach (XmlNode node in inmateNodes)
            {
                if (node.Attributes["name"].Value.ToLower().Contains(namePattern.ToLower()))
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
