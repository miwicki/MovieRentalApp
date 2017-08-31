namespace Movie_rental
{
    partial class Rent_Return_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_Returning = new System.Windows.Forms.TabControl();
            this.tab_Rent = new System.Windows.Forms.TabPage();
            this.com_ReGen3 = new System.Windows.Forms.ComboBox();
            this.com_ReGen2 = new System.Windows.Forms.ComboBox();
            this.com_ReGen1 = new System.Windows.Forms.ComboBox();
            this.btn_ReExit = new System.Windows.Forms.Button();
            this.btn_ReRent = new System.Windows.Forms.Button();
            this.txt_ReReturnDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_ReMov3 = new System.Windows.Forms.Label();
            this.lbl_ReMov2 = new System.Windows.Forms.Label();
            this.lbl_ReMov1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmd_ReMov3 = new System.Windows.Forms.ComboBox();
            this.cmd_ReMov2 = new System.Windows.Forms.ComboBox();
            this.cmd_ReMov1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ReCusNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Return = new System.Windows.Forms.TabPage();
            this.txt_RuMovieRent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_RuTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.txt_fines = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_RuMovieName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_RuCusNIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_Returning.SuspendLayout();
            this.tab_Rent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_Return.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Returning
            // 
            this.tab_Returning.Controls.Add(this.tab_Rent);
            this.tab_Returning.Controls.Add(this.tab_Return);
            this.tab_Returning.Location = new System.Drawing.Point(-2, 2);
            this.tab_Returning.Name = "tab_Returning";
            this.tab_Returning.SelectedIndex = 0;
            this.tab_Returning.Size = new System.Drawing.Size(615, 537);
            this.tab_Returning.TabIndex = 0;
            // 
            // tab_Rent
            // 
            this.tab_Rent.BackColor = System.Drawing.Color.Transparent;
            this.tab_Rent.BackgroundImage = global::Movie_rental.Properties.Resources.Transformers_movies_simple_background_white_background_1920x1200;
            this.tab_Rent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Rent.Controls.Add(this.pictureBox2);
            this.tab_Rent.Controls.Add(this.com_ReGen3);
            this.tab_Rent.Controls.Add(this.com_ReGen2);
            this.tab_Rent.Controls.Add(this.com_ReGen1);
            this.tab_Rent.Controls.Add(this.btn_ReExit);
            this.tab_Rent.Controls.Add(this.btn_ReRent);
            this.tab_Rent.Controls.Add(this.txt_ReReturnDate);
            this.tab_Rent.Controls.Add(this.label11);
            this.tab_Rent.Controls.Add(this.lbl_ReMov3);
            this.tab_Rent.Controls.Add(this.lbl_ReMov2);
            this.tab_Rent.Controls.Add(this.lbl_ReMov1);
            this.tab_Rent.Controls.Add(this.label4);
            this.tab_Rent.Controls.Add(this.cmd_ReMov3);
            this.tab_Rent.Controls.Add(this.cmd_ReMov2);
            this.tab_Rent.Controls.Add(this.cmd_ReMov1);
            this.tab_Rent.Controls.Add(this.dataGridView1);
            this.tab_Rent.Controls.Add(this.txt_ReCusNIC);
            this.tab_Rent.Controls.Add(this.label2);
            this.tab_Rent.Controls.Add(this.label1);
            this.tab_Rent.ForeColor = System.Drawing.SystemColors.Control;
            this.tab_Rent.Location = new System.Drawing.Point(4, 22);
            this.tab_Rent.Name = "tab_Rent";
            this.tab_Rent.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rent.Size = new System.Drawing.Size(607, 511);
            this.tab_Rent.TabIndex = 0;
            this.tab_Rent.Text = "Renting a movie";
            // 
            // com_ReGen3
            // 
            this.com_ReGen3.Enabled = false;
            this.com_ReGen3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ReGen3.FormattingEnabled = true;
            this.com_ReGen3.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Horror",
            "Romantic",
            "Science fiction",
            "Thriller",
            "War"});
            this.com_ReGen3.Location = new System.Drawing.Point(432, 250);
            this.com_ReGen3.Name = "com_ReGen3";
            this.com_ReGen3.Size = new System.Drawing.Size(140, 29);
            this.com_ReGen3.TabIndex = 29;
            this.com_ReGen3.SelectedIndexChanged += new System.EventHandler(this.com_ReGen3_SelectedIndexChanged);
            // 
            // com_ReGen2
            // 
            this.com_ReGen2.Enabled = false;
            this.com_ReGen2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ReGen2.FormattingEnabled = true;
            this.com_ReGen2.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Horror",
            "Romantic",
            "Science fiction",
            "Thriller",
            "War"});
            this.com_ReGen2.Location = new System.Drawing.Point(281, 250);
            this.com_ReGen2.Name = "com_ReGen2";
            this.com_ReGen2.Size = new System.Drawing.Size(140, 29);
            this.com_ReGen2.TabIndex = 28;
            this.com_ReGen2.SelectedIndexChanged += new System.EventHandler(this.com_ReGen2_SelectedIndexChanged);
            // 
            // com_ReGen1
            // 
            this.com_ReGen1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_ReGen1.Enabled = false;
            this.com_ReGen1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ReGen1.FormattingEnabled = true;
            this.com_ReGen1.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Horror",
            "Romance",
            "Science_Fic",
            "Thriller",
            "War"});
            this.com_ReGen1.Location = new System.Drawing.Point(132, 250);
            this.com_ReGen1.Name = "com_ReGen1";
            this.com_ReGen1.Size = new System.Drawing.Size(140, 29);
            this.com_ReGen1.TabIndex = 27;
            this.com_ReGen1.SelectedIndexChanged += new System.EventHandler(this.com_ReGen1_SelectedIndexChanged);
            // 
            // btn_ReExit
            // 
            this.btn_ReExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btn_ReExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReExit.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReExit.ForeColor = System.Drawing.Color.White;
            this.btn_ReExit.Location = new System.Drawing.Point(481, 364);
            this.btn_ReExit.Name = "btn_ReExit";
            this.btn_ReExit.Size = new System.Drawing.Size(103, 74);
            this.btn_ReExit.TabIndex = 26;
            this.btn_ReExit.Text = "Exit";
            this.btn_ReExit.UseVisualStyleBackColor = false;
            // 
            // btn_ReRent
            // 
            this.btn_ReRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btn_ReRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReRent.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReRent.ForeColor = System.Drawing.Color.White;
            this.btn_ReRent.Location = new System.Drawing.Point(372, 364);
            this.btn_ReRent.Name = "btn_ReRent";
            this.btn_ReRent.Size = new System.Drawing.Size(103, 74);
            this.btn_ReRent.TabIndex = 24;
            this.btn_ReRent.Text = "Rent";
            this.btn_ReRent.UseVisualStyleBackColor = false;
            this.btn_ReRent.Click += new System.EventHandler(this.btn_ReRent_Click);
            // 
            // txt_ReReturnDate
            // 
            this.txt_ReReturnDate.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReReturnDate.Location = new System.Drawing.Point(186, 366);
            this.txt_ReReturnDate.Name = "txt_ReReturnDate";
            this.txt_ReReturnDate.Size = new System.Drawing.Size(168, 33);
            this.txt_ReReturnDate.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label11.Location = new System.Drawing.Point(21, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Date should Return ";
            // 
            // lbl_ReMov3
            // 
            this.lbl_ReMov3.AutoSize = true;
            this.lbl_ReMov3.Location = new System.Drawing.Point(440, 384);
            this.lbl_ReMov3.Name = "lbl_ReMov3";
            this.lbl_ReMov3.Size = new System.Drawing.Size(0, 13);
            this.lbl_ReMov3.TabIndex = 15;
            // 
            // lbl_ReMov2
            // 
            this.lbl_ReMov2.AutoSize = true;
            this.lbl_ReMov2.Location = new System.Drawing.Point(287, 384);
            this.lbl_ReMov2.Name = "lbl_ReMov2";
            this.lbl_ReMov2.Size = new System.Drawing.Size(0, 13);
            this.lbl_ReMov2.TabIndex = 14;
            // 
            // lbl_ReMov1
            // 
            this.lbl_ReMov1.AutoSize = true;
            this.lbl_ReMov1.Location = new System.Drawing.Point(129, 384);
            this.lbl_ReMov1.Name = "lbl_ReMov1";
            this.lbl_ReMov1.Size = new System.Drawing.Size(0, 13);
            this.lbl_ReMov1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(21, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select Movie";
            // 
            // cmd_ReMov3
            // 
            this.cmd_ReMov3.Enabled = false;
            this.cmd_ReMov3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ReMov3.FormattingEnabled = true;
            this.cmd_ReMov3.Location = new System.Drawing.Point(432, 295);
            this.cmd_ReMov3.Name = "cmd_ReMov3";
            this.cmd_ReMov3.Size = new System.Drawing.Size(140, 29);
            this.cmd_ReMov3.TabIndex = 11;
            this.cmd_ReMov3.SelectedIndexChanged += new System.EventHandler(this.cmd_ReMov3_SelectedIndexChanged);
            // 
            // cmd_ReMov2
            // 
            this.cmd_ReMov2.Enabled = false;
            this.cmd_ReMov2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ReMov2.FormattingEnabled = true;
            this.cmd_ReMov2.Location = new System.Drawing.Point(281, 295);
            this.cmd_ReMov2.Name = "cmd_ReMov2";
            this.cmd_ReMov2.Size = new System.Drawing.Size(140, 29);
            this.cmd_ReMov2.TabIndex = 10;
            this.cmd_ReMov2.SelectedIndexChanged += new System.EventHandler(this.cmd_ReMov2_SelectedIndexChanged);
            // 
            // cmd_ReMov1
            // 
            this.cmd_ReMov1.Enabled = false;
            this.cmd_ReMov1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ReMov1.FormattingEnabled = true;
            this.cmd_ReMov1.Location = new System.Drawing.Point(132, 295);
            this.cmd_ReMov1.Name = "cmd_ReMov1";
            this.cmd_ReMov1.Size = new System.Drawing.Size(140, 29);
            this.cmd_ReMov1.TabIndex = 9;
            this.cmd_ReMov1.SelectedIndexChanged += new System.EventHandler(this.cmd_ReMov1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CausesValidation = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(361, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 146);
            this.dataGridView1.TabIndex = 8;
            // 
            // txt_ReCusNIC
            // 
            this.txt_ReCusNIC.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReCusNIC.Location = new System.Drawing.Point(186, 86);
            this.txt_ReCusNIC.Name = "txt_ReCusNIC";
            this.txt_ReCusNIC.Size = new System.Drawing.Size(168, 33);
            this.txt_ReCusNIC.TabIndex = 6;
            this.txt_ReCusNIC.Enter += new System.EventHandler(this.txt_ReCusNIC_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer NIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "RENTING A MOVIE";
            // 
            // tab_Return
            // 
            this.tab_Return.BackgroundImage = global::Movie_rental.Properties.Resources.Hot_Rod_Transformers_The_Last_Knight_4Krotated;
            this.tab_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Return.Controls.Add(this.pictureBox1);
            this.tab_Return.Controls.Add(this.txt_RuMovieRent);
            this.tab_Return.Controls.Add(this.label5);
            this.tab_Return.Controls.Add(this.txt_RuTotal);
            this.tab_Return.Controls.Add(this.label3);
            this.tab_Return.Controls.Add(this.button2);
            this.tab_Return.Controls.Add(this.button1);
            this.tab_Return.Controls.Add(this.btn_Return);
            this.tab_Return.Controls.Add(this.txt_fines);
            this.tab_Return.Controls.Add(this.label10);
            this.tab_Return.Controls.Add(this.txt_RuMovieName);
            this.tab_Return.Controls.Add(this.label9);
            this.tab_Return.Controls.Add(this.label7);
            this.tab_Return.Controls.Add(this.dataGridView2);
            this.tab_Return.Controls.Add(this.txt_RuCusNIC);
            this.tab_Return.Controls.Add(this.label6);
            this.tab_Return.Location = new System.Drawing.Point(4, 22);
            this.tab_Return.Name = "tab_Return";
            this.tab_Return.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Return.Size = new System.Drawing.Size(607, 511);
            this.tab_Return.TabIndex = 1;
            this.tab_Return.Text = "Returning a movie";
            this.tab_Return.UseVisualStyleBackColor = true;
            // 
            // txt_RuMovieRent
            // 
            this.txt_RuMovieRent.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RuMovieRent.Location = new System.Drawing.Point(175, 275);
            this.txt_RuMovieRent.Name = "txt_RuMovieRent";
            this.txt_RuMovieRent.Size = new System.Drawing.Size(168, 33);
            this.txt_RuMovieRent.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(10, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Movie Rental\r\n";
            // 
            // txt_RuTotal
            // 
            this.txt_RuTotal.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RuTotal.Location = new System.Drawing.Point(175, 334);
            this.txt_RuTotal.Name = "txt_RuTotal";
            this.txt_RuTotal.Size = new System.Drawing.Size(168, 33);
            this.txt_RuTotal.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(10, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total Charge";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(399, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 74);
            this.button2.TabIndex = 23;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(240, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 74);
            this.button1.TabIndex = 22;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.Color.White;
            this.btn_Return.Location = new System.Drawing.Point(85, 399);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(103, 74);
            this.btn_Return.TabIndex = 21;
            this.btn_Return.Text = "Return";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // txt_fines
            // 
            this.txt_fines.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fines.Location = new System.Drawing.Point(175, 211);
            this.txt_fines.Name = "txt_fines";
            this.txt_fines.Size = new System.Drawing.Size(168, 33);
            this.txt_fines.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label10.Location = new System.Drawing.Point(10, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fines\r\n";
            // 
            // txt_RuMovieName
            // 
            this.txt_RuMovieName.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RuMovieName.Location = new System.Drawing.Point(175, 156);
            this.txt_RuMovieName.Name = "txt_RuMovieName";
            this.txt_RuMovieName.Size = new System.Drawing.Size(168, 33);
            this.txt_RuMovieName.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label9.Location = new System.Drawing.Point(10, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Movie Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(10, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "RETURNING A MOVIE";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(350, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 97);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txt_RuCusNIC
            // 
            this.txt_RuCusNIC.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RuCusNIC.Location = new System.Drawing.Point(175, 92);
            this.txt_RuCusNIC.Name = "txt_RuCusNIC";
            this.txt_RuCusNIC.Size = new System.Drawing.Size(168, 33);
            this.txt_RuCusNIC.TabIndex = 11;
            this.txt_RuCusNIC.Leave += new System.EventHandler(this.txt_RuCusNIC_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(10, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer NIC";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Movie_rental.Properties.Resources.back1;
            this.pictureBox2.Location = new System.Drawing.Point(504, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Movie_rental.Properties.Resources.back1;
            this.pictureBox1.Location = new System.Drawing.Point(501, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Rent_Return_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_rental.Properties.Resources.Transformers_movies_simple_background_white_background_1920x1200;
            this.ClientSize = new System.Drawing.Size(611, 535);
            this.Controls.Add(this.tab_Returning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rent_Return_Form";
            this.Text = "Rent/Return";
            this.Load += new System.EventHandler(this.Rent_Load);
            this.tab_Returning.ResumeLayout(false);
            this.tab_Rent.ResumeLayout(false);
            this.tab_Rent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_Return.ResumeLayout(false);
            this.tab_Return.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_Return;
        private System.Windows.Forms.TabControl tab_Returning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ReCusNIC;
        private System.Windows.Forms.Label lbl_ReMov3;
        private System.Windows.Forms.Label lbl_ReMov2;
        private System.Windows.Forms.Label lbl_ReMov1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmd_ReMov3;
        private System.Windows.Forms.ComboBox cmd_ReMov2;
        private System.Windows.Forms.ComboBox cmd_ReMov1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_RuCusNIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fines;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_RuMovieName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ReReturnDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ReExit;
        private System.Windows.Forms.Button btn_ReRent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.ComboBox com_ReGen1;
        private System.Windows.Forms.ComboBox com_ReGen3;
        private System.Windows.Forms.ComboBox com_ReGen2;
        private System.Windows.Forms.TextBox txt_RuMovieRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_RuTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tab_Rent;



    }
}