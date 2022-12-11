using System.Xml.Xsl;
using System.Collections.Generic;
using System;
using System.Text;

namespace KnuOopLab2
{
    class Program
    {
        static void Transform()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("dormitoryToHtml.xsl");
            xslt.Transform("dormitory.xml", "dormitory.html");
        }
        static void Main(string[] args)
        {
            Transform();

            var strategies = new Dictionary<string, IDormitorySearchStrategy>();

            strategies.Add("linq", new LinqSearchStrategy("dormitory.xml"));
            strategies.Add("dom", new DomSearchStrategy("dormitory.xml"));
            strategies.Add("sax", new SaxSearchStrategy("dormitory.xml"));

            Console.OutputEncoding = Encoding.Unicode;

            var strategyKey = Prompt.ReadString("Яку стратегію хочете використовувати?", strategies.Keys, "Невірне ім'я стратегії.");

            var search = new DormitorySearch(strategies[strategyKey]);

            search.startShellLoop();
        }
    }
}
