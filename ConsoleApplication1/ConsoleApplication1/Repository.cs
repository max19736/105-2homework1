using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class manufacturer
    {
        private const string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2015\Projects\homework1\ConsoleApplication1\ConsoleApplication1\資料庫\manufacturers.mdf;Integrated Security=True";


        public void Createmanufacturer(Models.manufacturer manufacturer)
        {
            var connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();


            var command = new System.Data.SqlClient.SqlCommand("", connection);
            command.CommandText = string.Format(@"
INSERT        INTO    manufacturers(code,name,address,orcode,orname,oraddress,contactpeople,contactemail,phone,[rule],startdate,enddate,visa,remarks)
VALUES          ('{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}',N'{7}','{8}',N'{9}','{10}','{11}',N'{12}',N'{13}')
", manufacturer.code,manufacturer.name,manufacturer.address,manufacturer.orcode,manufacturer.orname,manufacturer.oraddress,manufacturer.contactpeople,manufacturer.contactemail,manufacturer.phone,manufacturer.rule,manufacturer.startdate,manufacturer.enddate,manufacturer.visa,manufacturer.remarks);


            command.ExecuteNonQuery();


            connection.Close();
        }
    }
}
