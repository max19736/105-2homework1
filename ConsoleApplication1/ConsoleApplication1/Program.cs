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
            var xml =XElement.Load(@"C:\Users\User\Documents\Visual Studio 2015\Projects\homework1\max19736.xml");

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
                    var number = classNode.Element("編號").Value.Trim();
                    var chinesename = classNode.Element("中文名稱").Value.Trim();
                    var englishename = classNode.Element("英文名稱").Value.Trim();
                    var phonenumber = classNode.Element("電話").Value.Trim();
                    var fax = classNode.Element("傳真").Value.Trim();
                    var URL = classNode.Element("網址").Value.Trim(); 
                    var Email = classNode.Element("E-mail").Value.Trim();
                    var chineseaddress = classNode.Element("營業地址").Value.Trim();
                    var englishaddress = classNode.Element("英文地址").Value.Trim();

                });

            return classes;
        }
    }
}
