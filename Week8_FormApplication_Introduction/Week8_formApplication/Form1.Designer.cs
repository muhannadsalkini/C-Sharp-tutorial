namespace Week8_formApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.doktor = new System.Windows.Forms.RadioButton();
            this.polis = new System.Windows.Forms.RadioButton();
            this.engneer = new System.Windows.Forms.RadioButton();
            this.ogretmen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // doktor
            // 
            this.doktor.AutoSize = true;
            this.doktor.Location = new System.Drawing.Point(298, 96);
            this.doktor.Name = "doktor";
            this.doktor.Size = new System.Drawing.Size(57, 17);
            this.doktor.TabIndex = 5;
            this.doktor.TabStop = true;
            this.doktor.Text = "Doktor";
            this.doktor.UseVisualStyleBackColor = true;
            // 
            // polis
            // 
            this.polis.AutoSize = true;
            this.polis.Location = new System.Drawing.Point(424, 96);
            this.polis.Name = "polis";
            this.polis.Size = new System.Drawing.Size(47, 17);
            this.polis.TabIndex = 6;
            this.polis.TabStop = true;
            this.polis.Text = "Polis";
            this.polis.UseVisualStyleBackColor = true;
            this.polis.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // engneer
            // 
            this.engneer.AutoSize = true;
            this.engneer.Location = new System.Drawing.Point(159, 96);
            this.engneer.Name = "engneer";
            this.engneer.Size = new System.Drawing.Size(71, 17);
            this.engneer.TabIndex = 7;
            this.engneer.TabStop = true;
            this.engneer.Text = "Engenner";
            this.engneer.UseVisualStyleBackColor = true;
            // 
            // ogretmen
            // 
            this.ogretmen.AutoSize = true;
            this.ogretmen.Location = new System.Drawing.Point(551, 96);
            this.ogretmen.Name = "ogretmen";
            this.ogretmen.Size = new System.Drawing.Size(71, 17);
            this.ogretmen.TabIndex = 8;
            this.ogretmen.TabStop = true;
            this.ogretmen.Text = "Ogretmen";
            this.ogretmen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ogretmen);
            this.Controls.Add(this.engneer);
            this.Controls.Add(this.polis);
            this.Controls.Add(this.doktor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Program1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton doktor;
        private System.Windows.Forms.RadioButton polis;
        private System.Windows.Forms.RadioButton engneer;
        private System.Windows.Forms.RadioButton ogretmen;
    }
}

