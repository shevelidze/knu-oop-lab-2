using System;
using System.Xml.Xsl;
using System.IO;

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
            Console.WriteLine("Hello World!");
            Transform();
        }
    }
}
