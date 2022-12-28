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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))

                {
                    this.employeesTableAdapter.Fill(this.cRUD_DBDataSet.Employees);
                    employeesBindingSource.DataSource = this.cRUD_DBDataSet.Employees;
                    //dataGridView.DataSource = employeesBindingSource;
                }
                else
                {

                    var query = from o in this.cRUD_DBDataSet.Employees
                                where o.FullName.Contains(txtSearch.Text) || o.PhoneNumber == txtSearch.Text || o.Email == txtSearch.Text || o.Address.Contains(txtSearch.Text)
                                select o;
                    employeesBindingSource.DataSource= query.ToList();
                    //dataGridView.DataSource = query.ToList();

                }

              }

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode== Keys.Delete)
            {
                if (MessageBox.Show("Are you want to delete this row?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    employeesBindingSource.RemoveCurrent();

            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPEG Dosyası |*.jpeg| JPEG Dosyası|*.jpg"; 
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = false;
                ofd.Title = "JPEG Dosyası Seçiniz..";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = ofd.FileName;
                   // string DosyaAdi = ofd.SafeFileName;
                    pictureBox.ImageLocation = DosyaYolu;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtFullName.Focus();
                this.cRUD_DBDataSet.Employees.AddEmployeesRow(this.cRUD_DBDataSet.Employees.NewEmployeesRow());
                employeesBindingSource.MoveLast();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtFullName.Focus();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            employeesBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                employeesBindingSource.EndEdit();
                employeesTableAdapter.Update(this.cRUD_DBDataSet.Employees);
                panel.Enabled = false;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRUD_DBDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.cRUD_DBDataSet.Employees);
            //employeesBindingSource.DataSource = this.cRUD_DBDataSet.Employees;

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void btnShutDown_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Close();
        }
    }
}
