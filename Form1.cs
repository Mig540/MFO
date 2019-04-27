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

namespace MFO
{
    public partial class Form1 : Form
    {
        string connectStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Credit.accdb";
        OleDbConnection myConnection;

        public Form1()
        {
            myConnection = new OleDbConnection(connectStr);
            InitializeComponent();
        }

        private void button_AcOps_Click(object sender, EventArgs e)
        {
            connection("SELECT * FROM Account_operations");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count * 4;  // a correction I need
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }

        private void button_BKI_Click(object sender, EventArgs e)
        {
            connection("SELECT * FROM BKI");
        }

        private void button_Contract_Click(object sender, EventArgs e)
        {
            connection("SELECT * FROM Contract");
        }

        private void button_History_Click(object sender, EventArgs e)
        {
            connection("SELECT * FROM Credit_history");
        }

        private void button_Entity_Click(object sender, EventArgs e)
        {
            connection("SELECT * FROM Entity");
        }

        private void button_Accounts_Click(object sender, EventArgs e)
        {
            connection("SELECT * FROM Loan_account");
        }

        private void button_MFO_Click(object sender, EventArgs e)
        {
            connection("SELECT * FROM MFO");
        }

        void connection(string query)
        {
            myConnection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            myConnection.Close();
        }

        private void button_zeroBalance_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ZeroBalance";
            //command.Parameters.AddWithValue("@current_balance", "0");

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Loan_account (open_date, loan_size, close_date, current_balance, entity_inn) VALUES ('20.04.2019','3242', '21.04.2019', '0', '321')";
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();

            //OleDbDataAdapter da = new OleDbDataAdapter(command);
            //DataTable dt = new DataTable();

            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            myConnection.Close();
        }
    }
}
