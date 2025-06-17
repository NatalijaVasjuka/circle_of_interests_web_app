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
    public partial class Fteacher : Form
    {
        string path = Environment.CurrentDirectory + "\\Child.accdb;";
        public Fteacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            {
                try
                {
                    string str = @"INSERT INTO Teacher (T_id, T_name, T_Surname, T_nr, T_adress)" +
                        " VALUES (@id, @nm, @snm, @age, @lang)";
                    con.Open();
                    OleDbCommand comm;
                    comm = con.CreateCommand();
                    comm.CommandText = str;
                    comm.Parameters.Add(new OleDbParameter("@id", tID.Text));
                    comm.Parameters.Add(new OleDbParameter("@nm", tNm.Text));
                    comm.Parameters.Add(new OleDbParameter("@snm", tSurNm.Text));
                    comm.Parameters.Add(new OleDbParameter("@age", tPhone.Text));
                    comm.Parameters.Add(new OleDbParameter("@lang", tAdress.Text));
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
        void addDataToGrid(string str = @"SELECT * FROM Teacher")
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

        private void Fteacher_Load(object sender, EventArgs e)
        {
            addDataToGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            string id = dtGrid.CurrentRow.Cells[0].Value.ToString();
            string str = "DELETE FROM teacher WHERE t_Id =@id";
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
                MessageBox.Show("Error " + ex.Message);
            }
            con.Close();
            addDataToGrid();
        }
    }
}
