using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class manufacturer
    {
        private const string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2015\Projects\homework1\ConsoleApplication1\ConsoleApplication1\資料庫\manufacturer.mdf;Integrated Security=True";


        public void Createmanufacturer(Models.manufacturer manufacturer)
        {
            var connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();


            var command = new System.Data.SqlClient.SqlCommand("", connection);
            command.CommandText = string.Format(@"
INSERT        INTO    manufacturer(code,name,address,orcode,orname,oraddress,contactpeople,contactemail,phone,rule,startdate,enddate,visa)
VALUES          ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')
", manufacturer.code,manufacturer.name,manufacturer.address,manufacturer.orcode,manufacturer.orname,manufacturer.oraddress,manufacturer.contactpeople,manufacturer.contactemail,manufacturer.phone,manufacturer.rule,manufacturer.startdate,manufacturer.enddate,manufacturer.visa,manufacturer.remarks);


 //           command.ExecuteNonQuery();


            connection.Close();
        }
    }
}
