using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Collections;
using System.Text.RegularExpressions;

namespace Movie_rental
{
    public partial class EditCustomer : Form
    {
        String CusNic;
        String CusName;
        String CusAdrs;
        String CusTel;
        public EditCustomer(String nic, String name, String addrs, String tel)
        {
            CusNic = nic;
            CusName = name;
            CusAdrs = addrs;
            CusTel = tel;
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nic_Click(object sender, EventArgs e)
        {
            txt_nic.Text = "";
            txt_nic.ForeColor = System.Drawing.Color.Black;
        }             
               

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            customerSearch m1 = new customerSearch();
            m1.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
                if (txt_adrs.Text != "")
                {
                    if (txt_tel.Text != "" && txt_tel.Text.Length == 10 && Regex.Match(txt_tel.Text, @"^\d{10}$").Success)
                    {

                        Customer customer = new Customer();
                        customer.Cus_nic = txt_nic.Text;
                        customer.Cus_name = txt_name.Text;
                        customer.Cus_address = txt_adrs.Text;
                        customer.Cus_tel = Convert.ToInt32(txt_tel.Text);

                        int editReturn = customer.editCustomer();

                        if (editReturn == 0)
                        {
                            MessageBox.Show("Wrong Information", "Warning");
                        }
                        else
                        {
                            MessageBox.Show("Updated Succesfully", "Sucessful");
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

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            txt_nic.Text = CusNic;
            txt_name.Text = CusName;
            txt_tel.Text = CusTel;
            txt_adrs.Text = CusAdrs;
        }

        private void txt_name_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_name.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_tel_Click(object sender, EventArgs e)
        {
            txt_tel.Text = "";
            txt_tel.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_adrs_Click(object sender, EventArgs e)
        {
            txt_adrs.Text = "";
            txt_adrs.ForeColor = System.Drawing.Color.Black;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_adrs.Text = "";
            txt_tel.Text = "";
        }



        
       

        
    }
}
