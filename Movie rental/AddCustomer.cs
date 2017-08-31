using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Text.RegularExpressions;

namespace Movie_rental
{
    public partial class AddCustomer : Form
    {
        //hellow worlds
        customerSearch c1;
        string cusNIC;
        public AddCustomer(string n)
        {
            cusNIC = n;
            InitializeComponent();
			MessageBox.Show("Hello ");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
                if (txt_adrs.Text != "")
                {
                    if (txt_tel.Text != "" && txt_tel.Text.Length == 10 && Regex.Match(txt_tel.Text, @"^\d{10}$").Success)
                    {

                        Customer customer = new Customer();
                        customer.Cus_nic = txt_nic.Text;
                        customer.Cus_tel = Convert.ToInt32(txt_tel.Text);
                        customer.Cus_name = txt_name.Text;
                        customer.Cus_address = txt_adrs.Text;

                        int addReturn = customer.addCustomer();


                        if (addReturn == 0)
                        {
                            MessageBox.Show("Duplicate NIC", "Warning");

                        }
                        else
                        {
                            MessageBox.Show("Customer details added Succesfully", "Registered");
                            c1 = new customerSearch();
                            c1.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        txt_tel.Text = "Invalid phone number";
                        txt_tel.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    txt_adrs.Text = "Please enter your address";
                    txt_adrs.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                txt_name.Text = "Please enter your name";
                txt_name.ForeColor = System.Drawing.Color.Red;
            }           
            
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txt_nic.Text = cusNIC;
        }

        private void txt_name_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_name.ForeColor = System.Drawing.Color.Black;
        }
        
        private void txt_adrs_Click(object sender, EventArgs e)
        {
            txt_adrs.Text = "";
            txt_adrs.ForeColor = System.Drawing.Color.Black;
        }       

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MovieRental m1 = new MovieRental();
            m1.Show();
            this.Hide();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_tel.Text = "";
            txt_adrs.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_tel_Click_1(object sender, EventArgs e)
        {
            txt_tel.Text = "";
            txt_tel.ForeColor = System.Drawing.Color.Black;
        }

     }
}
