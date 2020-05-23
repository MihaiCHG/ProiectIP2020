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
        private int lastID;
        private int getIdOfCommand()
        {
            SqlCommand cmd;
            SqlDataReader dreader;
            string sql = "SELECT * FROM comenzi ORDER BY idcomanda";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            int lastID = 0;
            while (dreader.Read())
            {
                lastID = Convert.ToInt32(dreader.GetValue(0));
            }
            dreader.Close();
            cmd.Dispose();
            return lastID;
        }
        public Model()
        {
            _commands = new List<Produs>();
            loadDB();
            dataDB = "";
            _menu = Meniu.GetInstance();
            lastID = getIdOfCommand();
        }
        public void loadDB()
        {

            string constr;

            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documente\Facultate\An_3\II_IP\Proiect\WindowsFormsApp1\Model\Database.mdf;Integrated Security=True";

            conn = new SqlConnection(constr);

            conn.Open();
        }

        public Meniu Menu
        {
            get => _menu;
        }
        public List<String> Commands
        {
            get
            {
                List<String> commands = new List<string>();
                // use to perform read and write operations in the database 
                SqlCommand cmd;

                // use to read a row in table one by one 
                SqlDataReader dreader;

                // to sore SQL command and the output of SQL command 
                string sql, output = "";

                // use to fetch rows from demo table 
                sql = "SELECT * FROM comenzi";

                // to execute the sql statement 
                cmd = new SqlCommand(sql, conn);

                // fetch all the rows from the demo table 
                dreader = cmd.ExecuteReader();
                
                // for one by one reading row 
                while (dreader.Read())
                {
                    output = dreader.GetValue(0) + "#" + dreader.GetValue(1) + "#" + dreader.GetValue(2) +"-"+ dreader.GetValue(3);
                    if (output != "")
                        commands.Add(output);
                }

                // to close all the objects 
                dreader.Close();
                cmd.Dispose();
                return commands;
            }
        }
        public void addCommand(Command cmd)
        {

            string produse = "";
            foreach(Produs p in cmd.CommandList)
            {
                produse += p.Nume + "-";
            }
            double pretComanda = cmd.PretComanda;
            int nrMasa = cmd.NrMasa;

            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";

            SqlCommand cmdsql;
            // use the defined sql statement against our database 
            lastID++;
            sql = "INSERT INTO comenzi (IdComanda, ListaProduse, Pret, NrMasa) values(" +lastID+ ", '" + produse + "'," + pretComanda  +", " + nrMasa + ")";
            // use to execute the sql command so we are passing query and connection object 
            cmdsql = new SqlCommand(sql, conn);

            // associate the insert SQL command to adapter object
            adap.InsertCommand = new SqlCommand(sql, conn);

            // use to execute the DML statement against our database
            adap.InsertCommand.ExecuteNonQuery();

            // closing all the objects 
            cmdsql.Dispose();
        }
        public void deleteCommand(Command cmd)
        {
            SqlCommand cmdSql;

            // data adapter object is use to insert, update or delete commands 
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";

            // use the define SQL statement  
            // against our database
            string produse = "";
            foreach (Produs p in cmd.CommandList)
            {
                produse += p.Nume + "-";
            }
            sql = "DELETE FROM comenzi WHERE ListaProduse=" + "\'" + produse + "\'" + " AND Pret=" + cmd.PretComanda + " AND NrMasa=" + cmd.NrMasa;

            // use to execute the sql command so we  
            // are passing query and connection object 
            cmdSql = new SqlCommand(sql, conn);

            // associate the insert SQL  
            // command to adapter object 
            adap.InsertCommand = new SqlCommand(sql, conn);

            // use to execute the DML statement 
            // against our database 
            adap.InsertCommand.ExecuteNonQuery();

            // closing all the objects 
            cmdSql.Dispose();
        }
        public void Disconnect()
        {
            conn.Close();
        }
    }
}