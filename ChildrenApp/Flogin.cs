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
    public partial class Flogin : Form
    {
        static string path = @"Child.accdb";
        public Flogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String pass = txtPass.Text;

            OleDbConnection db = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            db.Open();
            OleDbCommand command = new OleDbCommand(@"SELECT* FROM login WHERE login = @lg AND pass = @ps", db);
            command.Parameters.Add(new OleDbParameter("@lg", txtLogin.Text));
            command.Parameters.Add(new OleDbParameter("@ps", txtPass.Text));
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // USR.rights = reader.GetString(4);
                }
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
            }

            else
            {
                MessageBox.Show("Error autorization");
                txtLogin.Clear();
                txtPass.Clear();
                return;
            }


            DataTable table = new DataTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
