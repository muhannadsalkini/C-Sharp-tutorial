namespace Week8_Databse_Introduction
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabe = new System.Windows.Forms.Label();
            this.emailLable = new System.Windows.Forms.Label();
            this.levelLable = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.TableListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(92, 55);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(85, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(92, 102);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(380, 84);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(121, 20);
            this.emailTextbox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(380, 58);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(121, 20);
            this.surnameTextBox.TabIndex = 5;
            // 
            // surnameLabe
            // 
            this.surnameLabe.AutoSize = true;
            this.surnameLabe.Location = new System.Drawing.Point(293, 65);
            this.surnameLabe.Name = "surnameLabe";
            this.surnameLabe.Size = new System.Drawing.Size(49, 13);
            this.surnameLabe.TabIndex = 7;
            this.surnameLabe.Text = "Surname";
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Location = new System.Drawing.Point(293, 91);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(35, 13);
            this.emailLable.TabIndex = 8;
            this.emailLable.Text = "E-mail";
            // 
            // levelLable
            // 
            this.levelLable.AutoSize = true;
            this.levelLable.Location = new System.Drawing.Point(293, 117);
            this.levelLable.Name = "levelLable";
            this.levelLable.Size = new System.Drawing.Size(33, 13);
            this.levelLable.TabIndex = 9;
            this.levelLable.Text = "Level";
            // 
            // levelComboBox
            // 
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "Student",
            "Teatcher"});
            this.levelComboBox.Location = new System.Drawing.Point(380, 114);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(121, 21);
            this.levelComboBox.TabIndex = 12;
            this.levelComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TableListView
            // 
            this.TableListView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TableListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.Surname,
            this.Level});
            this.TableListView.HideSelection = false;
            this.TableListView.Location = new System.Drawing.Point(70, 156);
            this.TableListView.Name = "TableListView";
            this.TableListView.Size = new System.Drawing.Size(455, 148);
            this.TableListView.TabIndex = 13;
            this.TableListView.UseCompatibleStateImageBehavior = false;
            this.TableListView.View = System.Windows.Forms.View.Details;
            this.TableListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 130;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 130;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 130;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(380, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(293, 39);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(35, 13);
            this.nameLable.TabIndex = 6;
            this.nameLable.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableListView);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.levelLable);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(this.emailTextbox);
            this.groupBox1.Controls.Add(this.surnameLabe);
            this.groupBox1.Controls.Add(this.emailLable);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.levelComboBox);
            this.groupBox1.Controls.Add(this.nameLable);
            this.groupBox1.Location = new System.Drawing.Point(71, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 341);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Week8_Databse_Introduction.Properties.Resources.fd62de2e52da822d2bc2dbbb67fa9a68;
            this.ClientSize = new System.Drawing.Size(770, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabe;
        private System.Windows.Forms.Label emailLable;
        private System.Windows.Forms.Label levelLable;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ListView TableListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

