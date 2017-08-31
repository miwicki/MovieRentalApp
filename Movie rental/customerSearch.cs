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

namespace Movie_rental
{
    
    
    public partial class customerSearch : Form
    {
        ArrayList l1;
        string nicNo,cusN, cusA;
        int telph=1;
        DBconnection dbc1;
        MovieRental m1;
        AddCustomer ac1;
        EditCustomer ec1;
        Rent_Return_Form rrf1;
        public customerSearch()
        {
            InitializeComponent();
            animationLoad(false, 255,255,255);            
            
        }
        public void animationLoad(bool valTF, int r,int g,int b)
        {
            //Animation-to disable button and to change colour of buttons 
            editL.Enabled = valTF;
            deleteL.Enabled = valTF;
            rentL.Enabled = valTF;
            editR.Enabled = valTF;
            deleteR.Enabled = valTF;
            rentR.Enabled = valTF;
            editL.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            deleteL.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            rentL.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            editR.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            deleteR.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            rentR.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            //Animation

        }

        private void nicI_Click(object sender, EventArgs e)//Animation to clear out text field when a click
        {
            nicI.Text = "";
            nicI.ForeColor = System.Drawing.SystemColors.ControlDark;
            nicI.ForeColor = System.Drawing.Color.Black;
            nicI.TextAlign = HorizontalAlignment.Left;
            animationLoad(false, 255, 255, 255);            
        }

        private void nicI_KeyDown(object sender, KeyEventArgs e)//when press enter after the insertion of NIC
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = nicI.Text;
                if ((str.Count(char.IsDigit) == 9) && // only 9 digits(NIC rule)            
                str.EndsWith("V", StringComparison.OrdinalIgnoreCase) && //a letter at the end 'x' or 'v'(NIC rule)
                (str[2] != '4' && str[2] != '9')) //3rd digit can not be equal to 4 or 9(NIC rle)
                {
                    dbc1 = new DBconnection();
                    nicNo = nicI.Text;
                    l1 = dbc1.searchCustomerDetails(nicNo, "customer_data");

                    int val = Convert.ToInt32(l1[0].ToString());
                    if (val == 1) // registered customer
                    {
                        this.cusN = l1[2].ToString();
                        this.cusA = l1[3].ToString();
                        this.telph = Convert.ToInt32(l1[1].ToString());

                        label_custN.Text = cusN;
                        label_addr.Text = cusA;
                        label_tp.Text = telph.ToString();
                        animationLoad(true, 45, 170, 230);
                        this.Cursor = Cursors.Default;
                    }
                    else if (val == 0) //unregistered customer
                    {
                        string cN = nicI.Text.ToLower();
                        animationLoad(false, 255,255,255); 
                        nicI.Text = "Unregistered nic no";
                        nicI.ForeColor = System.Drawing.Color.Red;
                        nicI.TextAlign = HorizontalAlignment.Center;
                        DialogResult d1 = MessageBox.Show("Do you want to register this customer?", "Unregistered customer", MessageBoxButtons.YesNo);
                        if (d1 == DialogResult.Yes)
                        {
                            ac1 = new AddCustomer(cN);
                            ac1.Show();
                            this.Hide();
                        }
                        else
                        {
                            this.Show();
                        }

                    }
                
                }
                else
                {
                    MessageBox.Show("Invalid NIC number");
                    animationLoad(false, 255,255,255); 
                    nicI.Text = "Invalid ID";
                    nicI.ForeColor = System.Drawing.Color.Red;
                    nicI.TextAlign = HorizontalAlignment.Center;
                } 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)//back button
        {
            m1 = new MovieRental();
            m1.Show();
            this.Hide();
        }

        private void editR_Click(object sender, EventArgs e)
        {
            String name = label_custN.Text;
            String address = label_addr.Text;
            String tel = label_tp.Text;
            string cN = nicI.Text;
            ec1 = new EditCustomer(cN, name, address, tel);
            ec1.Show();
            this.Hide(); 
 

        }


        private void customerSearch_Load(object sender, EventArgs e)
        {
            dbc1 = new DBconnection();
            AutoCompleteStringCollection at1 = dbc1.dataLoadToSuggestion("nic","customer");
            nicI.AutoCompleteCustomSource = at1;
        }

        private void deleteR_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("This customer may have some transactions\nAre you sure?", "Delete", MessageBoxButtons.YesNo);
            if (r1 == DialogResult.Yes)
            {
                dbc1 = new DBconnection();
                dbc1.deleteCust(nicI.Text);
                MessageBox.Show("Sucessfully deleted customer data related to nic no : " + nicI.Text, "Completed");
                customerSearch_Load(this, null);
            }
            else
            {
                this.Show();
                animationLoad(false, 255,255,255); 
            }


            
        }

        private void rentR_Click(object sender, EventArgs e)
        {
            rrf1 = new Rent_Return_Form(nicI.Text,label_custN.Text);
            this.Hide();
            rrf1.Show();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox2, "Back");
        }


    }

}
