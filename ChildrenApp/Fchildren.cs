using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ChildrenApp
{
    public partial class Fchildren : Form
    {
        string path = Environment.CurrentDirectory + "\\Child.accdb;";
        public Fchildren()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            {
                try
                {
                    string str = @"INSERT INTO child (C_id, C_name, C_Surname, C_age, C_language)" +
                        " VALUES (@id, @nm, @snm, @age, @lang)";
                    con.Open();
                    OleDbCommand comm;
                    comm = con.CreateCommand();
                    comm.CommandText = str;
                    comm.Parameters.Add(new OleDbParameter("@id", tID.Text));
                    comm.Parameters.Add(new OleDbParameter("@nm", tNm.Text));
                    comm.Parameters.Add(new OleDbParameter("@snm", tSurNm.Text));
                    comm.Parameters.Add(new OleDbParameter("@age", tAge.Text));
                    comm.Parameters.Add(new OleDbParameter("@lang", tLang.Text));
                    comm.ExecuteNonQuery();

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error!" + ex.Message);
                }
                con.Close();
                addDataToGrid();
            }
        }

        private void Fchildren_Load(object sender, EventArgs e)
        {
            addDataToGrid();
        }
        void addDataToGrid(string str = @"SELECT * FROM Child")
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            {
                OleDbDataAdapter adptr;
                try
                {
                    con.Open();
                    OleDbCommand comm;
                    comm = con.CreateCommand();
                    comm.CommandText = str;
                    adptr = new OleDbDataAdapter(comm);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    adptr.Fill(dt);
                    dtGrid.DataSource = dt;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error!" + ex.Message);
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            con.Open();
            string id = dtGrid.CurrentRow.Cells[0].Value.ToString();
            string str = "DELETE FROM Child WHERE C_Id =@id";
            try
            {
                con.Open();
                OleDbCommand comm;
                comm = con.CreateCommand();
                comm.CommandText = str;
                comm.Parameters.Add(new OleDbParameter("@id", id));
                comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            con.Close();
            addDataToGrid();
        }
    }
}


