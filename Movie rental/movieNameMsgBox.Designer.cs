namespace Movie_rental
{
    partial class movieNameMsgBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_del = new System.Windows.Forms.Button();
            this.movieI = new System.Windows.Forms.TextBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label_movie = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_copies = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter movie name";
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.button_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_del.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_del.Location = new System.Drawing.Point(3, 172);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(86, 32);
            this.button_del.TabIndex = 4;
            this.button_del.Text = "Delete";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Visible = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // movieI
            // 
            this.movieI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.movieI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.movieI.BackColor = System.Drawing.Color.Gainsboro;
            this.movieI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieI.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.movieI.Location = new System.Drawing.Point(12, 122);
            this.movieI.Name = "movieI";
            this.movieI.Size = new System.Drawing.Size(260, 26);
            this.movieI.TabIndex = 10;
            this.movieI.Text = "Enter movie name to search ";
            this.movieI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.movieI.Click += new System.EventHandler(this.movieI_Click);
            
            this.movieI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.movieI_KeyDown);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_edit.Location = new System.Drawing.Point(95, 172);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(93, 32);
            this.button_edit.TabIndex = 11;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Visible = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(284, 261);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.White;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape2.Location = new System.Drawing.Point(-2, 261);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(292, 199);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(0, -19);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(290, 280);
            // 
            // label_movie
            // 
            this.label_movie.AutoSize = true;
            this.label_movie.BackColor = System.Drawing.Color.White;
            this.label_movie.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_movie.Location = new System.Drawing.Point(12, 287);
            this.label_movie.Name = "label_movie";
            this.label_movie.Size = new System.Drawing.Size(168, 37);
            this.label_movie.TabIndex = 12;
            this.label_movie.Text = "Movie name";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.BackColor = System.Drawing.Color.White;
            this.label_genre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genre.Location = new System.Drawing.Point(15, 324);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(54, 21);
            this.label_genre.TabIndex = 13;
            this.label_genre.Text = "Genre";
            // 
            // label_copies
            // 
            this.label_copies.AutoSize = true;
            this.label_copies.BackColor = System.Drawing.Color.White;
            this.label_copies.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copies.Location = new System.Drawing.Point(15, 364);
            this.label_copies.Name = "label_copies";
            this.label_copies.Size = new System.Drawing.Size(136, 21);
            this.label_copies.TabIndex = 14;
            this.label_copies.Text = "Available copies :\r\n";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.White;
            this.label_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(15, 385);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(54, 21);
            this.label_price.TabIndex = 15;
            this.label_price.Text = "Price :";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add.Location = new System.Drawing.Point(191, 172);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(93, 32);
            this.button_add.TabIndex = 16;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Visible = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Movie_rental.Properties.Resources.back1;
            this.pictureBox1.Location = new System.Drawing.Point(204, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // movieNameMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_rental.Properties.Resources.moviesBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_copies);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_movie);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.movieI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "movieNameMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "movieNameMsgBox";
            this.Load += new System.EventHandler(this.movieNameMsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.TextBox movieI;
        private System.Windows.Forms.Button button_edit;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label_movie;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_copies;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}