using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant
{
    public class Model: IModel
    {
        SqlConnection conn;
        private List<Produs> _commands;
        private string dataDB;
        private Meniu _menu;
        public Model()
        {
            _commands = new List<Produs>();
            dataDB = "";
            Connect();
            Read();
            Disconnect();
        }
        private void loadMenu()
        {
            
        }
        public Meniu Menu
        {
            get => _menu;
        }
        public List<Produs> Commands
        {
            get => _commands;
        }
        public void addCommand(Command cmd)
        {

        }
        public void deleteCommand(Command cmd)
        {

        }
        private void Connect()
        {
            string constr;

            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documente\Facultate\An_3\II_IP\Proiect\WindowsFormsApp1\Model\Database.mdf;Integrated Security=True";

            conn = new SqlConnection(constr);

            conn.Open();
        }
        private void Disconnect()
        {
            conn.Close();
        }
        private void Read()
        {
            // use to perform read and write operations in the database 
            SqlCommand cmd;

            // use to read a row in table one by one 
            SqlDataReader dreader;

            // to sore SQL command and the output of SQL command 
            string sql, output = "";

            // use to fetch rows from demo table 
            sql = "Select * from produse";

            // to execute the sql statement 
            cmd = new SqlCommand(sql, conn);

            // fetch all the rows from the demo table 
            dreader = cmd.ExecuteReader();

            // for one by one reading row 
            while (dreader.Read())
            {
                output = output + dreader.GetValue(0) + " - " + dreader.GetValue(1) + dreader.GetValue(2) + dreader.GetValue(3) + dreader.GetValue(4) + "\n";
            }
            dataDB = output;
            // to close all the objects 
            dreader.Close();
            cmd.Dispose();
        }
    }
}