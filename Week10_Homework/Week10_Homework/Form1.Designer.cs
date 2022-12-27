namespace Week10_Homework
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Oy_Oran = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonload = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partiNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyOranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oYDataSet1 = new Week10_Homework.OYDataSet1();
            this.oYTableAdapter = new Week10_Homework.OYDataSet1TableAdapters.OYTableAdapter();
            this.buttonsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Oy_Oran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Oy_Oran
            // 
            chartArea1.Name = "ChartArea1";
            this.Oy_Oran.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Oy_Oran.Legends.Add(legend1);
            this.Oy_Oran.Location = new System.Drawing.Point(33, 44);
            this.Oy_Oran.Name = "Oy_Oran";
            this.Oy_Oran.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "OY";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "ChartDataSet";
            this.Oy_Oran.Series.Add(series1);
            this.Oy_Oran.Series.Add(series2);
            this.Oy_Oran.Size = new System.Drawing.Size(547, 285);
            this.Oy_Oran.TabIndex = 0;
            this.Oy_Oran.Text = "Oy Orani";
            // 
            // buttonload
            // 
            this.buttonload.Location = new System.Drawing.Point(222, 369);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(130, 49);
            this.buttonload.TabIndex = 1;
            this.buttonload.Text = "Load Chart";
            this.buttonload.UseVisualStyleBackColor = true;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.partiNameDataGridViewTextBoxColumn,
            this.oyOranDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.oYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(603, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 285);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // partiNameDataGridViewTextBoxColumn
            // 
            this.partiNameDataGridViewTextBoxColumn.DataPropertyName = "Parti_Name";
            this.partiNameDataGridViewTextBoxColumn.HeaderText = "Parti_Name";
            this.partiNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partiNameDataGridViewTextBoxColumn.Name = "partiNameDataGridViewTextBoxColumn";
            this.partiNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // oyOranDataGridViewTextBoxColumn
            // 
            this.oyOranDataGridViewTextBoxColumn.DataPropertyName = "Oy_Oran";
            this.oyOranDataGridViewTextBoxColumn.HeaderText = "Oy_Oran";
            this.oyOranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oyOranDataGridViewTextBoxColumn.Name = "oyOranDataGridViewTextBoxColumn";
            this.oyOranDataGridViewTextBoxColumn.Width = 125;
            // 
            // oYBindingSource
            // 
            this.oYBindingSource.DataMember = "OY";
            this.oYBindingSource.DataSource = this.oYDataSet1;
            // 
            // oYDataSet1
            // 
            this.oYDataSet1.DataSetName = "OYDataSet1";
            this.oYDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oYTableAdapter
            // 
            this.oYTableAdapter.ClearBeforeFill = true;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(736, 369);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(130, 49);
            this.buttonsave.TabIndex = 3;
            this.buttonsave.Text = "Save Data";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonload);
            this.Controls.Add(this.Oy_Oran);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Oy_Oran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Oy_Oran;
        private System.Windows.Forms.Button buttonload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OYDataSet1 oYDataSet1;
        private System.Windows.Forms.BindingSource oYBindingSource;
        private OYDataSet1TableAdapters.OYTableAdapter oYTableAdapter;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partiNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyOranDataGridViewTextBoxColumn;
    }
}

