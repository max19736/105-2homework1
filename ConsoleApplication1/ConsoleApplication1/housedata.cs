
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DatabaseRepository
    {
        private const string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\0324\範例程式\解析XML\ConsoleApplication1\App_Data\Water.mdf;Integrated Security=True";


        public void CreateStation(ConsoleApplication1.house station)
        {
            var connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();


            var command = new System.Data.SqlClient.SqlCommand("", connection);
            command.CommandText = string.Format(@"
INSERT        INTO    Station(ID, LocationAddress, ObservatoryName, LocationByTWD67, CreateTime)
VALUES          (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')
", station.date, station.number, station.chinesename, station.englishename, station.phonenumber,station.fax,station.URL,station.Email,station.chineseaddress,station.englishaddress);

            command.ExecuteNonQuery();


            connection.Close();
        }

    }
}