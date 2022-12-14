using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;


namespace KnuOopLab2
{
    class LinqSearchStrategy : IDormitorySearchStrategy
    {
        public LinqSearchStrategy(string filePath)
        {
            _element = XElement.Load(filePath);
        }

        public Inmate[] searchByAttribute(string attributeName, string pattern)
        {
            var elements = from element in _element.Descendants("inmate") where
                           element.Attribute(attributeName).Value.ToLower().Contains(pattern.ToLower()) select element;

            var resultList = new List<Inmate>();

            foreach(var element in elements)
            {
                resultList.Add(new Inmate(
                    element.Attribute("name").Value,
                    element.Attribute("faculty").Value,
                    element.Attribute("year").Value, 
                    element.Attribute("building").Value, 
                    element.Attribute("address").Value)
                    );
            }

            return resultList.ToArray();
        }

        private XElement _element;
    }
}
