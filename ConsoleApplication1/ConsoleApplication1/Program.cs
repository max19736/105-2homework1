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
            var classes = Findhouse ();
        }

        public static List<house> Findhouse()
        {
            List<house> house = new List<house>();
            XNamespace gml = @"http://data.gov.tw/node/42171";

            var xml = XElement.Load(@"http://opendataap2.e-land.gov.tw/resource/files/2016-12-21/b7e51d49764d324866a9941023648336.xml");

            var housesNode = xml.Descendants("row_item").ToList();

            for(var i=0;i< housesNode.Count(); i++)
            {
                var houseNode = housesNode[i];
            }
            housesNode
                .Where(x => !x.IsEmpty).ToList()
                .ForEach(houseNode =>
                {
                    var date = houseNode.Element("登記證核准日期").Value.Trim();
                    var number = houseNode.Element("編號").Value.Trim();
                    var chinesename = houseNode.Element("中文名稱").Value.Trim();
                    var englishename = houseNode.Element("英文名稱").Value.Trim();
                    var phonenumber = houseNode.Element("電話").Value.Trim();
                    var fax = houseNode.Element("傳真").Value.Trim();
                    var URL = houseNode.Element("網址").Value.Trim(); 
                    var Email = houseNode.Element("E-mail").Value.Trim();
                    var chineseaddress = houseNode.Element("營業地址").Value.Trim();
                    var englishaddress = houseNode.Element("英文地址").Value.Trim();
                   /* house classData = new house();
                    classData.date = "登記證核准日期";*/

                });

            return classes;
        }
    }
}
