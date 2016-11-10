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

namespace ShowMovieDB
{
    public partial class Form1 : Form
    {
        public OleDbConnection conn;
        private DataGridViewButtonColumn deleteButton;
        private DataGridViewButtonColumn editButton;

        public Form1()
        {
            InitializeComponent();

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/amand/Desktop/MovieDatabase.mdb";

            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open();

                string QueryString = "select * FROM Table1";
                loadDataGrid(QueryString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        private void loadDataGrid(string queryString)
        {
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable table = null;
            dataGridView1.DataSource = null;
            SQLQuery.Connection = null;
            OleDbDataAdapter dataAdapter = null;
            dataGridView1.Columns.Clear();

            SQLQuery.CommandText = queryString;
            SQLQuery.Connection = conn;
            table = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = false;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;

            editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Width = 80;
            dataGridView1.Columns.Add(editButton);

            // insert delete button to datagridview
            deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Width = 80;
            dataGridView1.Columns.Add(deleteButton);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string queryString = "Select * from Table1";

            int currentRowSelected = int.Parse(e.RowIndex.ToString());

            string movieIDstring = dataGridView1[0, currentRowSelected].Value.ToString();
           // int movieIDint = int.Parse(movieIDstring);

            if (currentRowSelected>=0 && dataGridView1.Columns[e.ColumnIndex] == editButton)
            {
                string title = dataGridView1[1, currentRowSelected].Value.ToString();
                string publisher = dataGridView1[2, currentRowSelected].Value.ToString();
                string previewed = dataGridView1[3, currentRowSelected].Value.ToString();
                string releaseYear = dataGridView1[4, currentRowSelected].Value.ToString();
                string typID = dataGridView1[5, currentRowSelected].Value.ToString();

                Form2 form2 = new Form2();

                

                form2.title = title;
                form2.publisher = publisher;
                form2.previewed = previewed;
                form2.releaseyear = releaseYear;
                form2.typeID = typID;

                form2.Show();

            }
        }
    }
    }

