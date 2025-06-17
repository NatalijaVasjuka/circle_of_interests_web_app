using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenApp
{
    public partial class Fsetting : Form
    {
        string path = Environment.CurrentDirectory + "\\Child.accdb;";
        public Fsetting()
        {
            InitializeComponent();
        }

        private void Fsetting_Load(object sender, EventArgs e)
        {
            addData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Boolean isUsrExists(string lgn)
        {
            {
                using (var con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path))
                {
                    con.Open();
                    OleDbCommand command = new OleDbCommand(@"SELECT* FROM login WHERE login = @lg", con);
                    command.Parameters.Add(new OleDbParameter("@lg", lgn));


                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Такой пользователь уже зарегистрирован");
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String pass = txtPass.Text;

            if (login == "")
            {
                MessageBox.Show("Enter login");
                return;
            }

            if (pass == "")
                return;

            if (isUsrExists(login))
            {
                return;
            }
            if (txtFIO.Text == "")
            {
                MessageBox.Show("Enter F.I.О.");
                return;
            }
            if (cBox.Text == "")
            {
                MessageBox.Show("Select rights");
                return;
            }
            OleDbConnection db = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            db.Open();
                try
                {
                    OleDbCommand command = new OleDbCommand(@"INSERT INTO login (login, pass, FIO, rights) " +
                                       " VALUES (@lg, @ps, @fio, @rgts)", db);
                    command.Parameters.Add(new OleDbParameter("@lg", txtLogin.Text));
                    command.Parameters.Add(new OleDbParameter("@ps", txtPass.Text));
                    command.Parameters.Add(new OleDbParameter("@fio", txtFIO.Text));
                    command.Parameters.Add(new OleDbParameter("@rgts", cBox.Text));
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            txtPass.Text = "";
            txtLogin.Text = "";
            txtFIO.Text = "";
            db.Close();
            addData();
        }
        void addData()
        {
            using (var connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path))
            {
                connection.Open();
                string queryStr = @"SELECT id, login, fio, rights FROM login";

                OleDbCommand sqlCommand = new OleDbCommand(queryStr, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = sqlCommand;
                DataSet ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds);
                dtGrid.DataSource = ds.Tables[0];
                dtGrid.Columns[0].Visible = false;
                dtGrid.Columns[1].HeaderText = "login";
                dtGrid.Columns[2].HeaderText = "FIO";
                dtGrid.Columns[3].HeaderText = "rights";
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
