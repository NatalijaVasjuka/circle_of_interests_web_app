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
    public partial class Fcl : Form
    {
        string path = Environment.CurrentDirectory + "\\Child.accdb;";
        public Fcl()
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
                    string str = @"INSERT INTO CL(C_id, L_id) VALUES (@cid, @gid)";
                    con.Open();
                    OleDbCommand comm;
                    comm = con.CreateCommand();
                    comm.CommandText = str;
                    comm.Parameters.Add(new OleDbParameter("@cid", txtcID.Text));
                    comm.Parameters.Add(new OleDbParameter("@gid", txtlID.Text));
                    comm.ExecuteNonQuery();

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error!" + ex.Message);
                }
                con.Close();
                addDataToGrid();
                txtcID.Clear();
                txtlID.Clear();
            }
        }
        void addDataToGrid(string str = @"SELECT CL.L_ID AS L_ID, CL.C_ID AS C_ID, C_SURNAME, C_NAME," +
            " C_AGE, C_LANGUAGE, TITLE, DATA, TAME, PRICE FROM CL, CHILD CH, LESSON L " +
            " WHERE CL.L_ID = L.L_ID AND CL.C_ID = CH.C_ID;")
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
        private void addDataToBox(string str, ComboBox cBox)
        {
            var con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            con.Open();
            var comm = new OleDbCommand(str, con);
            OleDbDataReader reader = comm.ExecuteReader(CommandBehavior.SingleResult);

            if (reader.HasRows)
            {
                cBox.Items.Clear();
                cBox.Items.Add("");
                while (reader.Read())
                {
                    cBox.Items.Add(reader[0]);
                }
            }
            reader.Close();
            con.Close();
        }

        private void Fcl_Load(object sender, EventArgs e)
        {
            addDataToBox("SELECT Title FROM lesson", cBoxLesson);
            addDataToBox("SELECT DISTINCT c_surname FROM child ORDER BY c_surname", cBoxChildren);
            addDataToGrid();
        }

        private void cBoxChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDataToBox("SELECT DISTINCT c_name FROM child WHERE c_surname = '" + cBoxChildren.Text + "'  ORDER BY c_name", cBoxCNm);
        }
        private string returnId(string str)
        {
            object id = 0;
            var con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            con.Open();
            var comm = new OleDbCommand(str, con);
            id = comm.ExecuteScalar();
            con.Close();
            return id.ToString();
        }

        private void cBoxLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtlID.Text = returnId("SELECT l_id FROM lesson WHERE title = '" + cBoxLesson.Text + "'");
        }

        private void cBoxCNm_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcID.Text = returnId("SELECT c_id FROM child WHERE c_surname = '" + cBoxChildren.Text + "' AND c_name = '" + cBoxCNm.Text + "'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            string lid = dtGrid.CurrentRow.Cells[0].Value.ToString();
            string cid = dtGrid.CurrentRow.Cells[1].Value.ToString();
            string str = "DELETE FROM CG WHERE l_Id =@lid AND c_Id =@cid";
            try
            {
                con.Open();
                OleDbCommand comm;
                comm = con.CreateCommand();
                comm.CommandText = str;
                comm.Parameters.Add(new OleDbParameter("@lid", lid));
                comm.Parameters.Add(new OleDbParameter("@cid", cid));
                comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            con.Close();
            addDataToGrid();
        }
    }
}
