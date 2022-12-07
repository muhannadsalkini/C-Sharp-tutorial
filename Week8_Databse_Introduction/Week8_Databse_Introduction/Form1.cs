using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //We added the library.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_Databse_Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Provider
        OleDbConnection Aconnection = 
            new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=D:\\Uni\\5. Semester\\Visual Programming\\C-Sharp-tutorial\\Databse\\Information.mdb");

        private void showInformation() // Database codes
        {
            TableListView.Items.Clear(); // clear data
            Aconnection.Open();
            OleDbCommand AccessCommand = new OleDbCommand();
            AccessCommand.Connection = Aconnection;
            AccessCommand.CommandText = ("Select * from Members");
            OleDbDataReader read = AccessCommand.ExecuteReader();

            while (read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["ID"].ToString();
                addNew.SubItems.Add(read["mName"].ToString());
                addNew.SubItems.Add(read["Surname"].ToString());
                addNew.SubItems.Add(read["mail"].ToString());
                addNew.SubItems.Add(read["mPosition"].ToString());
                TableListView.Items.Add(addNew);
            }
            Aconnection.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showInformation();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Aconnection.Open();
            string sqlText = "INSERT INTO Members (mName,Surname,mail,mPosition) values ('" + nameTextBox.Text.ToString() + "','" + surnameTextBox.Text.ToString() + "','" + emailTextbox.Text.ToString() + "','" + levelComboBox.SelectedItem.ToString() + "')";
            OleDbCommand AccessCommand = new OleDbCommand(sqlText, Aconnection);
            AccessCommand.ExecuteNonQuery();
            Aconnection.Close();
            showInformation();
            nameTextBox.Clear();
            surnameTextBox.Clear();
            emailTextbox.Clear();
            levelComboBox.Refresh();
        }
        private void levelListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
