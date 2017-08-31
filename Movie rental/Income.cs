using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using System.Collections;

namespace Movie_rental
{
    public partial class Income : Form
    {
        DateTime from, to;
        DBconnection db1;
        MovieRental mr1;
        public Income()
        {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            dateTimePicker_from.MaxDate = DateTime.Now.AddDays(-1);
            dateTimePicker_to.MaxDate = DateTime.Now;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            from = dateTimePicker_from.Value.Date;
            to = dateTimePicker_to.Value.Date;
            db1 = new DBconnection();
            DataTable dt = new DataTable();
            dt = db1.displayIncome(from, to);
            dataGridView1.DataSource = dt;
            this.Height = 500; this.Width = 550; this.Cursor = Cursors.Default;
            incomeCal();
        }

        private void incomeCal()
        {
            decimal Total = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["FARE"].Value);
            }
            label5.Text = "Rs. " + Total.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mr1 = new MovieRental();
            this.Hide();
            mr1.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox1, "Back");
        }
    }
}
