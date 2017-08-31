namespace Movie_rental
{
    partial class MovieRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieRental));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect_Movie = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect_Cust = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label_Cust = new System.Windows.Forms.Label();
            this.label_Movie = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.swap = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.swap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1,
            this.rect_Movie,
            this.rect_Cust});
            this.shapeContainer1.Size = new System.Drawing.Size(534, 411);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rectangleShape2.CornerRadius = 17;
            this.rectangleShape2.Location = new System.Drawing.Point(-15, 255);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(122, 66);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rectangleShape1.CornerRadius = 17;
            this.rectangleShape1.Location = new System.Drawing.Point(-15, 210);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(122, 35);
            // 
            // rect_Movie
            // 
            this.rect_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rect_Movie.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rect_Movie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rect_Movie.BorderWidth = 2;
            this.rect_Movie.CornerRadius = 5;
            this.rect_Movie.Location = new System.Drawing.Point(166, 30);
            this.rect_Movie.Name = "rect_Movie";
            this.rect_Movie.Size = new System.Drawing.Size(125, 125);
            this.rect_Movie.Click += new System.EventHandler(this.label_Movie_Click);
            this.rect_Movie.MouseEnter += new System.EventHandler(this.rect_Movie_MouseEnter);
            this.rect_Movie.MouseLeave += new System.EventHandler(this.rect_Movie_MouseLeave);
            // 
            // rect_Cust
            // 
            this.rect_Cust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rect_Cust.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rect_Cust.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rect_Cust.BorderWidth = 2;
            this.rect_Cust.CornerRadius = 5;
            this.rect_Cust.Location = new System.Drawing.Point(15, 30);
            this.rect_Cust.Name = "rect_Cust";
            this.rect_Cust.Size = new System.Drawing.Size(125, 125);
            this.rect_Cust.Click += new System.EventHandler(this.rect_Cust_Click);
            this.rect_Cust.MouseEnter += new System.EventHandler(this.rect_Cust_MouseEnter);
            this.rect_Cust.MouseLeave += new System.EventHandler(this.rect_Cust_MouseLeave);
            // 
            // label_Cust
            // 
            this.label_Cust.AutoSize = true;
            this.label_Cust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label_Cust.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cust.ForeColor = System.Drawing.Color.White;
            this.label_Cust.Location = new System.Drawing.Point(16, 73);
            this.label_Cust.Name = "label_Cust";
            this.label_Cust.Size = new System.Drawing.Size(125, 32);
            this.label_Cust.TabIndex = 2;
            this.label_Cust.Text = "Customer";
            this.label_Cust.Click += new System.EventHandler(this.rect_Cust_Click);
            this.label_Cust.MouseHover += new System.EventHandler(this.label_Cust_MouseHover);
            // 
            // label_Movie
            // 
            this.label_Movie.AutoSize = true;
            this.label_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label_Movie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Movie.ForeColor = System.Drawing.Color.White;
            this.label_Movie.Location = new System.Drawing.Point(187, 73);
            this.label_Movie.Name = "label_Movie";
            this.label_Movie.Size = new System.Drawing.Size(86, 32);
            this.label_Movie.TabIndex = 3;
            this.label_Movie.Text = "Movie";
            this.label_Movie.Click += new System.EventHandler(this.label_Movie_Click);
            this.label_Movie.MouseEnter += new System.EventHandler(this.rect_Movie_MouseEnter);
            this.label_Movie.MouseLeave += new System.EventHandler(this.rect_Movie_MouseLeave);
            this.label_Movie.MouseHover += new System.EventHandler(this.label_Movie_MouseHover);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.Transparent;
            this.button_exit.Location = new System.Drawing.Point(415, 362);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(107, 40);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // swap
            // 
            this.swap.Image = global::Movie_rental.Properties.Resources.download0;
            this.swap.Location = new System.Drawing.Point(336, 30);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(186, 326);
            this.swap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swap.TabIndex = 8;
            this.swap.TabStop = false;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(4, 216);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Check income";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(116, 177);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(213, 192);
            this.axShockwaveFlash1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(4, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Customer Reports";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MovieRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_rental.Properties.Resources.Batman_v_Superman_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.swap);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_Movie);
            this.Controls.Add(this.label_Cust);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MovieRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieRental";
            ((System.ComponentModel.ISupportInitialize)(this.swap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect_Movie;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect_Cust;
        private System.Windows.Forms.Label label_Cust;
        private System.Windows.Forms.Label label_Movie;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox swap;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button button1;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Button button2;
    }
}