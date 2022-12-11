using System.Collections.Generic;
using System.Xml;

namespace KnuOopLab2
{
    class SaxSearchStrategy : IDormitorySearchStrategy
    {
        public SaxSearchStrategy(string filePath)
        {
            _filePath = filePath;
        }
        public Inmate[] searchByAttribute(string attributeName, string pattern)
        {
            var reader = new XmlTextReader(_filePath);
            var resultList = new List<Inmate>();
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if ((reader.Name == "inmate") && (reader.GetAttribute(attributeName).ToLower().Contains(pattern.ToLower())))
                    {
                        resultList.Add(new Inmate(reader.GetAttribute("name"), reader.GetAttribute("faculty"),
                        reader.GetAttribute("year"), reader.GetAttribute("building"), reader.GetAttribute("address")));
                    }
                }
            }
            return resultList.ToArray();
        }

        private string _filePath;
    }
}