using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ChildrenApp
{
    public partial class Form1 : Form
    {
        //  string path = Environment.CurrentDirectory + "\\Child.accdb;";
        //  string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:/Program Files(x86)/Engine2010;";
        static string databaseFile = @"Child.accdb";
        static string executablePath = AppDomain.CurrentDomain.BaseDirectory;
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + executablePath + "//" + databaseFile + ";";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addDataToGrid();
            addDataToBox("SELECT Title FROM lesson", cBoxLesson);
        }

        private void childToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fchildren fchildren = new Fchildren();
            fchildren.ShowDialog();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fteacher fteacher = new Fteacher();
            fteacher.ShowDialog();
        }

        private void guardianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fguard fguard = new Fguard();
            fguard.ShowDialog();
        }

        private void exitProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lessonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flessons flessons = new Flessons();
            flessons.ShowDialog();
        }

        private void cGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcg fc = new Fcg();
            fc.ShowDialog();
        }

        private void cLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcl fcl = new Fcl();
            fcl.ShowDialog();
        }

        private void cBoxDt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxDt.SelectedIndex == 0)
                addDataToGrid();
            else
                addDataToGrid(@"SELECT C_SURNAME + '  '+ C_NAME AS CHILDREN ," +
                            " C_AGE AS AGE , TITLE, DATA, TAME, T_SURNAME +' '+ T_NAME AS TEACHER,  PRICE " +
                            " FROM CL, CHILD AS CH, LESSON AS L, TEACHER T " +
                            " WHERE CL.L_ID = L.L_ID AND CL.C_ID = CH.C_ID AND L.T_ID = T.T_ID AND DATA = '"+ cBoxDt.Text +"';");
        }

        void addDataToGrid(string str = @"SELECT C_SURNAME + '  '+ C_NAME AS CHILDREN ,"+
            " C_AGE AS AGE , TITLE, DATA, TAME, T_SURNAME +' '+ T_NAME AS TEACHER,  PRICE " +
            " FROM CL, CHILD AS CH, LESSON AS L, TEACHER T " +
            " WHERE CL.L_ID = L.L_ID AND CL.C_ID = CH.C_ID AND L.T_ID = T.T_ID;")
        {
            OleDbConnection con = new OleDbConnection(connectionString);
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

        private void button1_Click(object sender, EventArgs e)
        {
            addDataToGrid("SELECT COUNT(CG.C_ID)  AS CHILDREN, G_NAME + '  ' + G_SURNAME AS GUARDIAN  FROM CG, CHILD C," +
                          " GUARDIAN G WHERE CG.C_ID = C.C_ID AND CG.G_ID = G.G_ID GROUP BY G_NAME, G_SURNAME");
        }
        private void addDataToBox(string str, ComboBox cBox)
        {
            var con = new OleDbConnection(connectionString);
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

        private void cBoxLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxLesson.SelectedIndex == 0)
                addDataToGrid();
            else
                addDataToGrid(@"SELECT C_SURNAME + '  '+ C_NAME AS CHILDREN ," +
                            " C_AGE AS AGE , TITLE, DATA, TAME, T_SURNAME +' '+ T_NAME AS TEACHER,  PRICE " +
                            " FROM CL, CHILD AS CH, LESSON AS L, TEACHER T " +
                            " WHERE CL.L_ID = L.L_ID AND CL.C_ID = CH.C_ID AND L.T_ID = T.T_ID AND TITLE = '" + cBoxLesson.Text + "';");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addDataToGrid(@"SELECT TITLE, DATA, TAME, PRICE, T_NAME, " +
                           " T_SURNAME FROM LESSON L, TEACHER T WHERE L.T_ID = T.T_ID AND PRICE <="+ Int32.Parse(txtPrice.Text) +"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addDataToGrid(@"SELECT SUM(PRICE) AS [TOTAL SUMMA], T_NAME + ' ' " +
                            " + T_SURNAME AS TEACHER  FROM LESSON L, TEACHER T WHERE L.T_ID = T.T_ID GROUP BY T_NAME,T_SURNAME");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fsetting fsetting = new Fsetting();
            fsetting.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
