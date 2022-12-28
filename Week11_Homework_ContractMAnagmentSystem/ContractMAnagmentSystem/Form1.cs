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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsernameKeypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter your name.","Message", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            try {

                LoginDBDataSetTableAdapters.UsersTableAdapter user = new LoginDBDataSetTableAdapters.UsersTableAdapter();
                LoginDBDataSet.UsersDataTable dt = user.GetDataByUsernamePassword(txtUsername.Text,txtPassword.Text);
                
                if (dt.Rows.Count == 0 )
                {
                    MessageBox.Show(" You have been succesfully logged in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Your name or password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
