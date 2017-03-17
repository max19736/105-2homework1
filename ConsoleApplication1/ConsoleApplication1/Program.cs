using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = FindClass1 ();
        }

        public static List<Class1> FindClass1()
        {
            List<Class1> classes = new List<Class1>();
            var xml =XElement.Load( @"D:\max19736\max19736.xml");

            var classesNode = xml.Descendants("row_item").ToList();

            for(var i=0;i< classesNode.Count(); i++)
            {
                var classNode = classesNode[i];
            }
            classesNode
                .Where(x => !x.IsEmpty).ToList()
                .ForEach(classNode =>
                {
                    var date = classNode.Element("登記證核准日期").Value.Trim();


                });

            return classes;
        }
    }
}
