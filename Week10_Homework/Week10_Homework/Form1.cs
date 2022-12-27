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

namespace Week10_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Desktop\\5. Semester\\Visual Programming\\C-Sharp-tutorial\\Week10_Homework\\Week10_Homework\\OY.accdb\"");


        private void buttonload_Click(object sender, EventArgs e)
        {
            try
            {
                // clear chart
                foreach (var series in Oy_Oran.Series)
                {
                    series.Points.Clear();
                }
                Aconnection.Open();
                OleDbCommand AcsessComand = new OleDbCommand();
                AcsessComand.Connection = Aconnection;
                AcsessComand.CommandText = ("SELECT * FROM OY");
                OleDbDataReader read = AcsessComand.ExecuteReader();

                while (read.Read())
                {
                    Oy_Oran.Series["OY"].Points.AddXY(read["Parti_Name"].ToString(), read["Oy_oran"].ToString());
                    Oy_Oran.Series["ChartDataSet"].Points.AddXY(read["Parti_Name"].ToString(), read["Oy_oran"].ToString());
                }

                Aconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
            }
            Oy_Oran.Series["OY"].XValueMember = "Parti_Name";
            Oy_Oran.Series["OY"].YValueMembers = "Oy_Oran";
            Oy_Oran.DataSource = oYDataSet1.OY;
            Oy_Oran.DataBind();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oYDataSet1.OY' table. You can move, or remove it, as needed.
            this.oYTableAdapter.Fill(this.oYDataSet1.OY);

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                oYBindingSource.EndEdit();
                oYTableAdapter.Update(oYDataSet1.OY);
                
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
            }

            
        }

        
    }
}
