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
    public partial class ReceiptForm : Form
    {
        string cName, cNIC, rented, returned, mv1, mv2, mv3, g1, g2, g3, p1, p2, p3;

        public ReceiptForm(string name,string nic,string rent,string ret,string m1,string g1)
        {
            cName = name;
            cNIC = nic;
            rented = rent;
            returned = ret;
            this.mv1 = m1;
            this.g1 = g1;            
            InitializeComponent();
        }
        public ReceiptForm(string name, string nic, string rent, string ret,string m1,string m2,string g1,string g2)
        {
            cName = name;
            cNIC = nic;
            rented = rent;
            returned = ret;
            this.mv1 = m1;
            this.g1 = g1;
            this.mv2 = m2;
            this.g2 = g2;  
            InitializeComponent();
        }
        public ReceiptForm(string name, string nic, string rent, string ret,string m1,string m2,string m3,string g1,string g2,string g3)
        {
            cName = name;
            cNIC = nic;
            rented = rent;
            returned = ret;
            this.mv1 = m1;
            this.g1 = g1;
            this.mv2 = m2;
            this.g2 = g2;
            this.mv3 = m3;
            this.g3 = g3;
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] par = new Microsoft.Reporting.WinForms.ReportParameter[]{
                new Microsoft.Reporting.WinForms.ReportParameter("cusName",cName),
                new Microsoft.Reporting.WinForms.ReportParameter("cusNIC",cNIC),
                new Microsoft.Reporting.WinForms.ReportParameter("rDate",rented),
                new Microsoft.Reporting.WinForms.ReportParameter("returnD",returned),
                new Microsoft.Reporting.WinForms.ReportParameter("mv1",mv1),
                new Microsoft.Reporting.WinForms.ReportParameter("mv2",mv2),
                new Microsoft.Reporting.WinForms.ReportParameter("mv3",mv3),
                new Microsoft.Reporting.WinForms.ReportParameter("g1",g1),
                new Microsoft.Reporting.WinForms.ReportParameter("g2",g2),
                new Microsoft.Reporting.WinForms.ReportParameter("g3",g3),
            };
            this.reportViewer1.LocalReport.SetParameters(par);

            this.reportViewer1.RefreshReport();
        }
    }
}
