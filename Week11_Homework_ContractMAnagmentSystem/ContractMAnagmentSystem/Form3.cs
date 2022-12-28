using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContractMAnagmentSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Desktop\\5. Semester\\Visual Programming\\C-Sharp-tutorial\\Week11_Homework_ContractMAnagmentSystem\\ContractMAnagmentSystem\\CRUD_DB.accdb\"";
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Desktop\\5. Semester\\Visual Programming\\C-Sharp-tutorial\\Week11_Homework_ContractMAnagmentSystem\\ContractMAnagmentSystem\\CRUD_DB.accdb\"");

        

        private void Form3_Load(object sender, EventArgs e)
        {
            int boys = 0;
            int girls = 0;            

            Aconnection.Open();
            OleDbCommand AcsessComand = new OleDbCommand();
            AcsessComand.Connection = Aconnection;
            AcsessComand.CommandText = ("SELECT * FROM Employees");
            OleDbDataReader read = AcsessComand.ExecuteReader();

            while (read.Read())
            {
                if (read["Gender"].ToString() == "Boy")
                    boys++;
                else if (read["Gender"].ToString() == "Girl")
                    girls++;
            }
            if ((boys + girls) == 0)
                boys--;

            chart1.Series["Gender"].Points.AddXY("Boys", (100 / (boys + girls)) * boys);
            chart1.Series["Gender"].Points.AddXY("Girls", (100 / (boys + girls)) * girls);

            Aconnection.Close(); 
            // TODO: This line of code loads data into the 'cRUD_DBDataSet.Employees' table. You can move, or remove it, as needed.
            try
            {
                this.employeesTableAdapter.Fill(this.cRUD_DBDataSet.Employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
            }
            

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                employeesBindingSource.EndEdit();
                employeesTableAdapter.Update(cRUD_DBDataSet.Employees);

                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int boys=0;
            int girls =0;
            string var;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value == null || row.Cells[2].Value == DBNull.Value)
                    var = "";
                else
                    var = (string)row.Cells[2].Value;

                if (var == "Boy")
                    boys++;
                else if (var == "Girl")
                    girls++;
            }
            if (boys+girls == 0)
                boys--;

            chart1.Series["Gender"].Points.Clear();
            chart1.Series["Gender"].Points.AddXY("Boys", (100 / (boys+girls)) * boys);
            chart1.Series["Gender"].Points.AddXY("Girls", (100 / (boys + girls)) * girls);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }
    }
}
