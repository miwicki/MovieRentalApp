using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Movie_rental
{
    public partial class CustomerReport : Form
    {
        DBconnection db;
        MovieRental m1;
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (rbn_allCusRent.Checked||rbn_allCusRange.Checked)
            {
                if (string.IsNullOrEmpty(txt_nic.Text))
                {
                    MessageBox.Show("Enter NIC", "Alert1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows.RemoveAt(0);
                    }
                    txt_nic.Focus();
                }
            }
            string d1 = "", d2 = "", nic = txt_nic.Text;
            int value1 = 3;

            if (rbn_allCusRent.Checked)
            {
                value1 = 0;

            }

            if (rbn_allCusRange.Checked)
            {
                value1 = 1;
                d1 = dateTimePicker1.Value.ToShortDateString();
                d2 = dateTimePicker2.Value.ToShortDateString();
            }

            if (rbn_notReturned.Checked)
            {
                value1 = 2;
            }

            if (rbn_allCus.Checked)
            {
                value1 = 3;
            }

            db = new DBconnection();
            dataGridView1.DataSource = db.repcus(value1, d1, d2, nic);

            if (dataGridView1.RowCount==0)
            {
                MessageBox.Show("No Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }


                //Exporting to PDF
                string folderPath = "C:\\PDFs\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Exported Successfully to "+ folderPath, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exporting Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            db = new DBconnection();
            AutoCompleteStringCollection at1 = db.dataLoadToSuggestion("nic", "customer");
            txt_nic.AutoCompleteCustomSource = at1;
        }

        private void rbn_allCusRent_CheckedChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            txt_nic.Enabled = true;
            txt_nic.Focus();
            MessageBox.Show("Enter NIC", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbn_allCus_CheckedChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            txt_nic.Enabled = false;
        }

        private void rbn_allCusRange_CheckedChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            txt_nic.Enabled = true;
            txt_nic.Focus();
            MessageBox.Show("Enter NIC","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void rbn_notReturned_CheckedChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            txt_nic.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            m1 = new MovieRental();
            m1.Show();
            this.Hide();
        }
    }
}
