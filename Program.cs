using System;
using System.Xml.Xsl;

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

            var search = new DormitorySearch(new DomSearchStrategy("dormitory.xml"));

            search.startShellLoop();
            
        }
    }
}
