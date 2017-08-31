namespace Movie_rental
{
    partial class AddMovie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_genre = new System.Windows.Forms.ComboBox();
            this.lbl_addMovie = new System.Windows.Forms.Label();
            this.txt_noCopies = new System.Windows.Forms.TextBox();
            this.lbl_noCopies = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_movieName = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_movieName = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cmb_genre);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_addMovie);
            this.panel1.Controls.Add(this.txt_noCopies);
            this.panel1.Controls.Add(this.lbl_noCopies);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_clr);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_movieName);
            this.panel1.Controls.Add(this.lbl_price);
            this.panel1.Controls.Add(this.lbl_genre);
            this.panel1.Controls.Add(this.lbl_movieName);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 450);
            this.panel1.TabIndex = 1;
            // 
            // cmb_genre
            // 
            this.cmb_genre.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.cmb_genre.FormattingEnabled = true;
            this.cmb_genre.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Horror",
            "Romantic",
            "Science fiction",
            "Thriller",
            "War "});
            this.cmb_genre.Location = new System.Drawing.Point(17, 179);
            this.cmb_genre.Name = "cmb_genre";
            this.cmb_genre.Size = new System.Drawing.Size(236, 33);
            this.cmb_genre.TabIndex = 17;
            // 
            // lbl_addMovie
            // 
            this.lbl_addMovie.AutoSize = true;
            this.lbl_addMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lbl_addMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_addMovie.ForeColor = System.Drawing.Color.White;
            this.lbl_addMovie.Location = new System.Drawing.Point(14, 36);
            this.lbl_addMovie.Name = "lbl_addMovie";
            this.lbl_addMovie.Size = new System.Drawing.Size(118, 25);
            this.lbl_addMovie.TabIndex = 0;
            this.lbl_addMovie.Text = "ADD MOVIE";
            // 
            // txt_noCopies
            // 
            this.txt_noCopies.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noCopies.Location = new System.Drawing.Point(15, 297);
            this.txt_noCopies.Name = "txt_noCopies";
            this.txt_noCopies.Size = new System.Drawing.Size(237, 33);
            this.txt_noCopies.TabIndex = 14;
            this.txt_noCopies.Click += new System.EventHandler(this.txt_noCopies_Click);
            // 
            // lbl_noCopies
            // 
            this.lbl_noCopies.AutoSize = true;
            this.lbl_noCopies.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noCopies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lbl_noCopies.Location = new System.Drawing.Point(12, 281);
            this.lbl_noCopies.Name = "lbl_noCopies";
            this.lbl_noCopies.Size = new System.Drawing.Size(75, 13);
            this.lbl_noCopies.TabIndex = 13;
            this.lbl_noCopies.Text = "No of Copies";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(14, 235);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(238, 33);
            this.txt_price.TabIndex = 12;
            this.txt_price.Click += new System.EventHandler(this.txt_price_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(469, 369);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(60, 30);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_clr.ForeColor = System.Drawing.Color.White;
            this.btn_clr.Location = new System.Drawing.Point(403, 369);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(60, 30);
            this.btn_clr.TabIndex = 10;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(16, 355);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(160, 30);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_movieName
            // 
            this.txt_movieName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_movieName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_movieName.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_movieName.Location = new System.Drawing.Point(17, 117);
            this.txt_movieName.Name = "txt_movieName";
            this.txt_movieName.Size = new System.Drawing.Size(235, 33);
            this.txt_movieName.TabIndex = 6;
            this.txt_movieName.Click += new System.EventHandler(this.txt_movieName_Click);
            this.txt_movieName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_movieName_KeyDown);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lbl_price.Location = new System.Drawing.Point(12, 219);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(32, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lbl_genre.Location = new System.Drawing.Point(13, 162);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(38, 13);
            this.lbl_genre.TabIndex = 3;
            this.lbl_genre.Text = "Genre";
            // 
            // lbl_movieName
            // 
            this.lbl_movieName.AutoSize = true;
            this.lbl_movieName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lbl_movieName.Location = new System.Drawing.Point(14, 101);
            this.lbl_movieName.Name = "lbl_movieName";
            this.lbl_movieName.Size = new System.Drawing.Size(74, 13);
            this.lbl_movieName.TabIndex = 2;
            this.lbl_movieName.Text = "Movie Name";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(550, 450);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rectangleShape1.CornerRadius = 28;
            this.rectangleShape1.Location = new System.Drawing.Point(-40, 26);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(309, 57);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Movie_rental.Properties.Resources.back1;
            this.pictureBox2.Location = new System.Drawing.Point(424, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.panel1);
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_noCopies;
        private System.Windows.Forms.Label lbl_noCopies;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_movieName;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_movieName;
        private System.Windows.Forms.Label lbl_addMovie;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmb_genre;
    }
}