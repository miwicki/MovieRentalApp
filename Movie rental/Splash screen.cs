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
    public partial class Splash_screen : Form
    {
        public Splash_screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 1;
                if (rectangleShape2.Width == 539)
                {
                    timer1.Stop();
                    this.Hide();
                    MovieRental mr1 = new MovieRental();
                    mr1.Show();
                }
            }
            catch {
                return;
            }
        }

        
    }
}
