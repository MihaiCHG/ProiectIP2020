/*
	Fisier creat de Tanasă Ciprian-Ionut
	Acest fisier contine partea de model
	din arhitectura MVP care se ocupa cu
	partea de stocare a comenzilor in baza
	de date si preluarea acestora
*/
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
        private Meniu _menu;
        private int lastID;
        private int getIdOfCommand()
        {
            //se obtine id-ul ultimei comenzi astfel incat sa se poate asocia noul id pentru noua comanda
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
            try
            {
                loadDB();
            } catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
            _menu = Meniu.GetInstance();
            lastID = getIdOfCommand();
        }
        public void loadDB()
        {
            string constr;

            string currentFolder = AppDomain.CurrentDomain.BaseDirectory;

            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + currentFolder + @"Database.mdf;Integrated Security=True";
            
            conn = new SqlConnection(constr);

            conn.Open();
        }

        public Meniu Menu
        {
            get => _menu;
        }
        public List<String> Commands
        {
            //se extrage lista de comenzi stocate in baza de date
            get
            {
                List<String> commands = new List<string>();

                try {
                    SqlCommand cmd;
                    SqlDataReader dreader;
                    string sql, output = "";
                    sql = "SELECT * FROM comenzi";
                    cmd = new SqlCommand(sql, conn);
                    dreader = cmd.ExecuteReader();
                    while (dreader.Read())
                    {
                        output = dreader.GetValue(0) + "#" + dreader.GetValue(1) + "#" + dreader.GetValue(2) +"-"+ dreader.GetValue(3);
                        if (output != "")
                            commands.Add(output);
                    }
                    dreader.Close();
                    cmd.Dispose();
                } catch(SqlException sqlEx)
                {
                    throw sqlEx;
                }
                return commands;
            }
        }
        public void addCommand(Command cmd)
        {
            try
            {
                string produse = "";
                foreach (Produs p in cmd.CommandList)
                {
                    produse += p.Nume + "-";
                }
                double pretComanda = cmd.PretComanda;
                int nrMasa = cmd.NrMasa;

                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand cmdsql;
                lastID++;
                string sql = "INSERT INTO comenzi (IdComanda, ListaProduse, Pret, NrMasa) values(" + lastID + ", '" + produse + "'," + pretComanda + ", " + nrMasa + ")";
                cmdsql = new SqlCommand(sql, conn);
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();
                cmdsql.Dispose();
            } catch (SqlException sqlEx)
            {
                throw sqlEx;
            } 
        }
        public void deleteCommand(Command cmd)
        {
            try
            {
                SqlCommand cmdSql;
                SqlDataAdapter adap = new SqlDataAdapter();
                string produse = "";
                foreach (Produs p in cmd.CommandList)
                {
                    produse += p.Nume + "-";
                }
                string sql = "DELETE FROM comenzi WHERE ListaProduse=" + "\'" + produse + "\'" + " AND Pret=" + cmd.PretComanda + " AND NrMasa=" + cmd.NrMasa;
                cmdSql = new SqlCommand(sql, conn);
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();
                cmdSql.Dispose();
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
        }
        public void Disconnect()
        {
            conn.Close();
        }
    }
}