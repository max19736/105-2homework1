using Models;
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
            var manufacturers = Findmanufacturers ();
            
            Showmanufacturer(manufacturers);

            Console.WriteLine("按下任一鍵進行新增資料庫");
            Console.ReadKey();
           Insertmanufacturer(manufacturers);
        }

        public static List<manufacturer> Findmanufacturers()
        {
            List<manufacturer> manufacturers = new List<manufacturer>();
            var xml = XElement.Load(@"D:\queryEMFile.xml");
            var manufacturersNode = xml.Descendants("優良廠商").ToList();

            for (var i = 0; i < manufacturersNode.Count; i++)
            {
                var manufacturerall = manufacturersNode[i];
            }
            manufacturersNode.Where(x => !x.IsEmpty).ToList().ForEach(manufacturerall =>
                    {
                        var code = manufacturerall.Element("廠商代碼").Value.Trim();
                        var name = manufacturerall.Element("廠商名稱").Value.Trim();
                        var address = manufacturerall.Element("廠商地址").Value.Trim();
                        var orcode = manufacturerall.Element("刊登機關代碼").Value.Trim();
                        var orname = manufacturerall.Element("刊登機關名稱").Value.Trim();
                        var oraddress = manufacturerall.Element("機關地址").Value.Trim();
                        var contactpeople = manufacturerall.Element("聯絡人").Value.Trim();
                        var contactemail = manufacturerall.Element("聯絡人電子郵件信箱").Value.Trim();
                        var phone = manufacturerall.Element("聯絡電話").Value.Trim();
                        var rule = manufacturerall.Element("評優良廠商依據之規定").Value.Trim();
                        var startdate = manufacturerall.Element("獎勵起始日期").Value.Trim();
                        var enddate = manufacturerall.Element("獎勵終止日期").Value.Trim();
                        var visa = manufacturerall.Element("通知工程會文號").Value.Trim();
                        var manufacturremarks = xml.Descendants("備註").ToList();
                        var remarks = manufacturerall.Element("備註").Value.Trim();

                        manufacturer manufacturerData = new manufacturer();
                        manufacturerData.code = code;
                        manufacturerData.name = name;
                        manufacturerData.address = address;
                        manufacturerData.orcode = orcode;
                        manufacturerData.orname = orname;
                        manufacturerData.oraddress = oraddress;
                        manufacturerData.contactpeople = contactpeople;
                        manufacturerData.contactemail = contactemail;
                        manufacturerData.phone = phone;
                        manufacturerData.rule = rule;
                        manufacturerData.startdate = startdate;
                        manufacturerData.enddate = enddate;
                        manufacturerData.visa = visa;
                        manufacturerData.remarks = remarks;
                        manufacturers.Add(manufacturerData);
                    });

            return manufacturers;
        }
        public static void Showmanufacturer(List<manufacturer> manufacturers)
        {

            Console.WriteLine(string.Format("共收到{0}筆監測站的資料", manufacturers.Count));
            manufacturers.ForEach(x =>
            {
                Console.WriteLine(string.Format("廠商代碼：{0}\n廠商名稱:{1}\n廠商地址：{2}\n刊登機關代碼：{3}\n刊登機關名稱：{4}\n機關地址：{5}\n聯絡人：{6}\n聯絡人電子郵件信箱：{7}\n聯絡電話：{8}\n評優良廠商依據之規定：{9}\n獎勵起始日期：{10}\n獎勵終止日期：{11}\n通知工程會文號：{12}\n備註：{13}\n", x.code, x.name,x.address,x.orcode,x.orname,x.oraddress,x.contactpeople,x.contactemail,x.phone,x.rule,x.startdate,x.enddate,x.visa,x.remarks));


            });


        }


        public static void Insertmanufacturer(List<manufacturer> manufacturers)
        {

            Repository.manufacturer db = new Repository.manufacturer();

            Console.WriteLine(string.Format("新增{0}筆優良廠商的資料開始", manufacturers.Count));
            manufacturers.ForEach(x =>
            {

                db.Createmanufacturer(x);


            });
            Console.WriteLine(string.Format("新增優良廠商的資料結束"));
            Console.ReadKey();
        }
        }
    }