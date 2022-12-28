using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractMAnagmentSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
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
            chart1.Series["Gender"].XValueMember = "Gender";
            chart1.Series["Gender"].YValueMembers = "Gender";
            chart1.DataSource = cRUD_DBDataSet.Employees;
            chart1.DataBind();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }
    }
}
