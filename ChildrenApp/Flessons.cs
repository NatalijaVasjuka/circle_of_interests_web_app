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
    public partial class Flessons : Form
    {
        string path = Environment.CurrentDirectory + "\\Child.accdb;";
        public Flessons()
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
                    string str = @"INSERT INTO Lesson (L_id, Title, Data, Tame, Price, T_id) " +
                                             " VALUES (@id, @tm, @dt, @t, @pr, @tid)";
                    con.Open();
                    OleDbCommand comm;
                    comm = con.CreateCommand();
                    comm.CommandText = str;
                    comm.Parameters.Add(new OleDbParameter("@id", tID.Text));
                    comm.Parameters.Add(new OleDbParameter("@tm", tTt.Text));
                    comm.Parameters.Add(new OleDbParameter("@dt", cBoxDt.Text));
                    comm.Parameters.Add(new OleDbParameter("@t", tTm.Text));
                    comm.Parameters.Add(new OleDbParameter("@pr", tPrice.Text));
                    comm.Parameters.Add(new OleDbParameter("@tid", ttID.Text));
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
        void addDataToGrid(string str = @"SELECT * FROM Lesson")
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

        private void Flessons_Load(object sender, EventArgs e)
        {
            addDataToGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            string id = dtGrid.CurrentRow.Cells[0].Value.ToString();
            string str = "DELETE FROM lesson WHERE l_Id =@id";
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
                MessageBox.Show("Error!" + ex.Message);
            }
            con.Close();
            addDataToGrid();
        }

        private void cBoxDt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
