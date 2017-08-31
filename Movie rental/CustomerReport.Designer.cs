namespace Movie_rental
{
    partial class CustomerReport
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
            this.btn_export = new System.Windows.Forms.Button();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.rbn_notReturned = new System.Windows.Forms.RadioButton();
            this.rbn_allCusRange = new System.Windows.Forms.RadioButton();
            this.rbn_allCusRent = new System.Windows.Forms.RadioButton();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbn_allCus = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_export.Location = new System.Drawing.Point(349, 445);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(141, 51);
            this.btn_export.TabIndex = 19;
            this.btn_export.Text = "Export as PDF";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // txt_nic
            // 
            this.txt_nic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_nic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nic.Enabled = false;
            this.txt_nic.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nic.Location = new System.Drawing.Point(215, 25);
            this.txt_nic.MaxLength = 10;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(144, 29);
            this.txt_nic.TabIndex = 18;
            // 
            // rbn_notReturned
            // 
            this.rbn_notReturned.AutoSize = true;
            this.rbn_notReturned.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_notReturned.Location = new System.Drawing.Point(61, 189);
            this.rbn_notReturned.Name = "rbn_notReturned";
            this.rbn_notReturned.Size = new System.Drawing.Size(185, 25);
            this.rbn_notReturned.TabIndex = 17;
            this.rbn_notReturned.TabStop = true;
            this.rbn_notReturned.Text = "Not retuned customers";
            this.rbn_notReturned.UseVisualStyleBackColor = true;
            this.rbn_notReturned.CheckedChanged += new System.EventHandler(this.rbn_notReturned_CheckedChanged);
            // 
            // rbn_allCusRange
            // 
            this.rbn_allCusRange.AutoSize = true;
            this.rbn_allCusRange.BackColor = System.Drawing.Color.White;
            this.rbn_allCusRange.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_allCusRange.Location = new System.Drawing.Point(61, 123);
            this.rbn_allCusRange.Name = "rbn_allCusRange";
            this.rbn_allCusRange.Size = new System.Drawing.Size(312, 25);
            this.rbn_allCusRange.TabIndex = 16;
            this.rbn_allCusRange.TabStop = true;
            this.rbn_allCusRange.Text = "Rent/Return details of Customer on range";
            this.rbn_allCusRange.UseVisualStyleBackColor = false;
            this.rbn_allCusRange.CheckedChanged += new System.EventHandler(this.rbn_allCusRange_CheckedChanged);
            // 
            // rbn_allCusRent
            // 
            this.rbn_allCusRent.AutoSize = true;
            this.rbn_allCusRent.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_allCusRent.Location = new System.Drawing.Point(61, 93);
            this.rbn_allCusRent.Name = "rbn_allCusRent";
            this.rbn_allCusRent.Size = new System.Drawing.Size(249, 25);
            this.rbn_allCusRent.TabIndex = 15;
            this.rbn_allCusRent.TabStop = true;
            this.rbn_allCusRent.Text = "Rent/Return Details of Customer";
            this.rbn_allCusRent.UseVisualStyleBackColor = true;
            this.rbn_allCusRent.CheckedChanged += new System.EventHandler(this.rbn_allCusRent_CheckedChanged);
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Generate.Location = new System.Drawing.Point(349, 185);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(141, 51);
            this.btn_Generate.TabIndex = 14;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(305, 150);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 188);
            this.dataGridView1.TabIndex = 10;
            // 
            // rbn_allCus
            // 
            this.rbn_allCus.AutoSize = true;
            this.rbn_allCus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_allCus.Location = new System.Drawing.Point(61, 63);
            this.rbn_allCus.Name = "rbn_allCus";
            this.rbn_allCus.Size = new System.Drawing.Size(123, 25);
            this.rbn_allCus.TabIndex = 20;
            this.rbn_allCus.TabStop = true;
            this.rbn_allCus.Text = "All Customers";
            this.rbn_allCus.UseVisualStyleBackColor = true;
            this.rbn_allCus.CheckedChanged += new System.EventHandler(this.rbn_allCus_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(56, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customer NIC";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Movie_rental.Properties.Resources.back1;
            this.pictureBox2.Location = new System.Drawing.Point(454, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Movie_rental.Properties.Resources.superman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 508);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbn_allCus);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.rbn_notReturned);
            this.Controls.Add(this.rbn_allCusRange);
            this.Controls.Add(this.rbn_allCusRent);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.RadioButton rbn_notReturned;
        private System.Windows.Forms.RadioButton rbn_allCusRange;
        private System.Windows.Forms.RadioButton rbn_allCusRent;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbn_allCus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}