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
    public partial class Form2 : Form
    {
        public string title, publisher, releaseyear, typeID, previewed;

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
           
            string UpdateQuery = "update Table1 Set Title ='" + Titlebox.Text + "',Publisher ='" + Publisherbox.Text + "',Previewed ='" + Previewedbox.Text + "',TypeID ='" + TypeIDbox.Text + "";

            OleDbCommand sqlQuery = new OleDbCommand();
            sqlQuery.CommandText = UpdateQuery;
            sqlQuery.Connection = f1.conn;
            //int response = sqlQuery.ExecuteNonQuery();
            f1.Show();
            MessageBox.Show("Update successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Titlebox.Text = title;
            Publisherbox.Text = publisher;
            Previewedbox.Text = previewed;
            ReleaseYearbox.Text = releaseyear;
            TypeIDbox.Text = typeID;
             
        }
    }
}
