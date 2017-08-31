using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movie_rental
{
    public partial class MovieRental : Form
    {
        movieNameMsgBox mn1;
        customerSearch c1;
        Income in1;
        CustomerReport cr1;
        public MovieRental()
        {
            InitializeComponent();
            Timer t1 = new Timer();
            t1.Interval = 1000;
            t1.Tick += new EventHandler(changeImage);
            t1.Start();
            axShockwaveFlash1.Movie = "https://www.youtube.com/v/5wfrDhgUMGI&list=PLh2QSchbA3pnI2SkRVb2ikuGAp5-BBiU3&index";
        }

        public void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.download1);
            b1.Add(Properties.Resources.download2);
            b1.Add(Properties.Resources.download3);
            b1.Add(Properties.Resources.download4);
            b1.Add(Properties.Resources.download5);
            b1.Add(Properties.Resources.download6);
            b1.Add(Properties.Resources.download7);
            b1.Add(Properties.Resources.download8);
            b1.Add(Properties.Resources.download9);
            b1.Add(Properties.Resources.download10);
            int index = DateTime.Now.Second % b1.Count;
            this.swap.Image = b1[index];
            this.swap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rect_Movie_MouseEnter(object sender, EventArgs e)
        {
            rect_Movie.Size = new Size(140, 140);
            var point = new Point(192, 85);
            label_Movie.Location = point;
        }

        private void rect_Cust_MouseLeave(object sender, EventArgs e)
        {
            rect_Cust.Size = new Size(125, 125);
            var point = new Point(16, 73);
            label_Cust.Location = point;
        }

        private void rect_Movie_MouseLeave(object sender, EventArgs e)
        {
            rect_Movie.Size = new Size(125, 125);
            var point = new Point(187, 73);
            label_Movie.Location = point;
        }

        private void rect_Cust_MouseEnter(object sender, EventArgs e)
        {
            rect_Cust.Size = new Size(140, 140);
            var point = new Point(24, 85);
            label_Cust.Location = point;
        }

        private void rect_Cust_Click(object sender, EventArgs e)
        {
            c1 = new customerSearch();
            this.Hide();
            c1.Show();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void label_Movie_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            mn1 = new movieNameMsgBox();
            this.Hide();
            mn1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            in1 = new Income();
            this.Hide();
            in1.Show();
        }

        private void label_Movie_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.label_Movie, "Customer controls");
        }

        private void label_Cust_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.label_Cust, "Movie controls");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cr1 = new CustomerReport();
            cr1.Show();
            this.Hide();
        }

        private void swap_Click(object sender, EventArgs e)
        {

        }
    }
}
