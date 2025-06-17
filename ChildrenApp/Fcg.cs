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
    public partial class Fcg : Form
    {
        string path = Environment.CurrentDirectory + "\\Child.accdb;";
        public Fcg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            con.Open();
            string cid = dtGrid.CurrentRow.Cells[0].Value.ToString();
            string gid = dtGrid.CurrentRow.Cells[1].Value.ToString();
            string str = "DELETE FROM CG WHERE c_Id =@cid AND g_Id =@gid";
            try
            {
                con.Open();
                OleDbCommand comm;
                comm = con.CreateCommand();
                comm.CommandText = str;
                comm.Parameters.Add(new OleDbParameter("@cid", cid));
                comm.Parameters.Add(new OleDbParameter("@gid", gid));
                comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            con.Close();
            addDataToGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path);
            {
                try
                {
                    string str = @"INSERT INTO CG(C_id, G_id) VALUES (@cid, @gid)";
                    con.Open();
                    OleDbCommand comm;
                    comm = con.CreateCommand();
                    comm.CommandText = str;
                    comm.Parameters.Add(new OleDbParameter("@cid", txtcID.Text));
                    comm.Parameters.Add(new OleDbParameter("@gid", txtgID.Text));
                    comm.ExecuteNonQuery();

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error!" + ex.Message);
                }
                con.Close();
                addDataToGrid();
                txtcID.Clear();
                txtgID.Clear();
            }
        }

        private void Fcg_Load(object sender, EventArgs e)
        {
            string str = "SELECT DISTINCT g_surname FROM guardian ORDER BY g_surname";
            try
            {
                addDataToBox(str, cBoxGuardian);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            str = "SELECT DISTINCT c_surname FROM child ORDER BY c_surname";
            try
            {
                addDataToBox(str, cBoxChildren);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            addDataToGrid();
        }
        void addDataToGrid(string str = @"SELECT CG.C_ID  AS C_ID, CG.G_ID AS G_ID, C_NAME, C_SURNAME," +
                            "C_AGE, C_LANGUAGE, G_NAME, G_SURNAME, G_NR, G_ADRESS  FROM CG, CHILD C," +
                            " GUARDIAN G WHERE CG.C_ID = C.C_ID AND CG.G_ID = G.G_ID")
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

        private void cBoxChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDataToBox("SELECT DISTINCT c_name FROM child WHERE c_surname = '" + cBoxChildren.Text + "'  ORDER BY c_name", cBoxCNm);
        }

        private void cBoxGuardian_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDataToBox("SELECT DISTINCT g_name FROM guardian WHERE g_surname = '" + cBoxGuardian.Text + "'  ORDER BY g_name", cBoxGNm);
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

        private void cBoxCNm_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcID.Text = returnId("SELECT c_id FROM child WHERE c_surname = '" + cBoxChildren.Text + "' AND c_name = '" + cBoxCNm.Text + "'");
        }

        private void cBoxGNm_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtgID.Text = returnId("SELECT g_id FROM guardian WHERE g_surname = '" + cBoxGuardian.Text + "' AND g_name = '" + cBoxGNm.Text + "'");
        }
    }
}
