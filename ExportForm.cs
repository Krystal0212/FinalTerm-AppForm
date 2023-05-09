using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FormApp
{
    public partial class ExportForm : Form
    {
        string adminID;
       
        public ExportForm()
        {
            InitializeComponent();
        }

        public ExportForm(String adminID)
        {
            this.adminID = adminID;
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            form_load();
        }

        private void ExportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void htGRD(DataGridView g)
        {
            if (g.Equals(grd1))
            {
                String sql = "select orderID as 'Order ID', resellerID as 'Reseller ID', createdDay as 'Created day', _status as 'Status', paymentMethod as 'Payment method', _address as 'Address', phoneNumber as 'Phone number', email as 'Email', totalPrice as 'Total Price', paymentStatus as 'Payment status' from orderList where _status = 'Processing'";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            else if (g.Equals(grd2))
            {
                String sql = "select goodId as 'Good ID', goodName as 'Good Name', Quantity, Price as 'Price / Item' from CurrentGoods order by goodID asc";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            else if (g.Equals(grd3))
            {
                string orderID = cbOrderID.Text;
                String sql = "select itemID as 'Item ID',itemname as 'Item name',pricePerItem as 'Price / Item',quantity as 'Quantity',totalPrice as 'Total price' from ExportedSlipsDetail where orderID = '" + orderID +"'";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }

        }

        private void form_load()
        {           
            bCancel.Enabled = false;

            bDelete.Enabled = false;

            bAccept.Enabled = false;

            bPrint.Enabled = false;

            htGRD(grd1);

            htGRD(grd2);

            htGRD(grd3);

            string sql = "select distinct orderID from ExportedSlipsDetail";
            DataTable dt = Connection.selectQuery(sql);
            cbOrderID.DataSource = dt;
            cbOrderID.DisplayMember = "orderID";
            cbOrderID.ValueMember = "orderID";

        }

        private void grd1_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = grd1.CurrentRow.Cells[0].Value.ToString();
            bDelete.Enabled = true;
            bAccept.Enabled = true;
            bCancel.Enabled = true;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            form_load();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            string currentOrderID = txtOrderID.Text;

            //Quantity change
            string sqlStock = "select goodID,quantity,goodName from CurrentGoods";
            DataTable Stock = Connection.selectQuery(sqlStock);

            string sqlOrderDetail = "select itemID,quantity from orderDetail where orderID = '" + currentOrderID + "'";
            DataTable OrderDetail = Connection.selectQuery(sqlOrderDetail);
            for (int i = 0; i < Stock.Rows.Count; i++)
            {
                string itemID = Stock.Rows[i][0].ToString();
                string quantity = Stock.Rows[i][1].ToString();
                string itemName = Stock.Rows[i][2].ToString();
                for (int j = 0; j < OrderDetail.Rows.Count; j++)
                {
                    int newquantity = 0;
                    if (itemID.Equals(OrderDetail.Rows[j][0].ToString()))
                    {
                        newquantity = Int32.Parse(quantity) - Int32.Parse(OrderDetail.Rows[j][1].ToString());
                        if(newquantity < 0) 
                        {
                            MessageBox.Show(" " +itemName+ " on stock is not enough to delivery \n They need "+ Int32.Parse(OrderDetail.Rows[j][1].ToString()) +" item but we only have "+quantity+"");
                            form_load();
                            return;
                        }
                        else
                        {
                            string sqlUpdate = "update CurrentGoods set quantity = '" + newquantity + "' where goodID = '" + itemID + "'";
                            Connection.actionQuery(sqlUpdate);
                        }
                    }
                }
            }

            string sqlMethod = "select paymentMethod from orderList where orderID = '" +currentOrderID +"'";
            DataTable MT = Connection.selectQuery(sqlMethod);
            string method = MT.Rows[0][0].ToString();

            if(method.Equals(" Purchase via Paypal"))
            {
                string sqlUpdate = "update orderList set _status = '" + "Transferred" + "', paymentStatus = '" + "Checked" + "' where orderID = '"+currentOrderID+"' ";
                Connection.actionQuery(sqlUpdate);
            }
            else
            {
                string sqlUpdate = "update orderList set _status = '" + "Transferred" + "', paymentStatus = '" + "Pay at home" + "' where orderID = '"+currentOrderID+"'";
                Connection.actionQuery(sqlUpdate);
            }

            string sqlInsertExportedSlips = "insert into ExportedSlips(orderID,resellerID,createdDay,_status,paymentMethod,_address,phoneNumber,email,totalPrice,paymentStatus)\r\nselect orderID,resellerID,createdDay,_status,paymentMethod,_address,phoneNumber,email,totalPrice,paymentStatus from orderList where orderID = '"+currentOrderID+"'";
            Connection.actionQuery(sqlInsertExportedSlips);


            string sqlInsertExportedSlipsDetail = "insert into ExportedSlipsDetail(orderID,itemID,itemname,pricePerItem,quantity,totalPrice)\r\nselect orderID,itemID,itemname,pricePerItem,quantity,totalPrice from orderDetail where orderID = '"+currentOrderID+"'";
            Connection.actionQuery(sqlInsertExportedSlipsDetail);

            txtOrderID.Clear();
            MessageBox.Show("Create successfully");
            form_load();          
        }

        private void cbOrderID_TextChanged(object sender, EventArgs e)
        {
            htGRD(grd3);
        }

        private void grd3_Click(object sender, EventArgs e)
        {
            bPrint.Enabled = true;
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            if (grd2.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {


                            PdfPTable pdfTable = new PdfPTable(grd3.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //add column
                            foreach (DataGridViewColumn column in grd3.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //add value
                            for (int i = 0; i < grd3.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd3.Columns.Count; ++j)
                                {
                                    // string s = grd.Rows[i].Cells[j].Value.ToString();
                                    pdfTable.AddCell(grd3.Rows[i].Cells[j].Value.ToString());

                                }
                            }

                            string sql = "select totalPrice from orderList where orderID = '" + cbOrderID.Text + "'";
                            DataTable a = Connection.selectQuery(sql);
                            string thanhtien = a.Rows[0][0].ToString();
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Paragraph("Export Ticket"));
                                pdfDoc.Add(new Paragraph("Order ID: " + cbOrderID.Text + ""));
                                pdfDoc.Add(new Paragraph("\n"));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Paragraph("Total price: " + thanhtien + " $"));
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                            // Application.Run(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

            string currentOrderID = txtOrderID.Text;  

            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlDelOrder = "delete from orderList where orderID = '" + currentOrderID + "' ";
                Connection.actionQuery(sqlDelOrder);

                string sqlDelOrderDetail = "delete from orderDetail where orderID = '" + currentOrderID + "' ";
                Connection.actionQuery(sqlDelOrderDetail);
                form_load();
            }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            form_load();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(adminID);
            adminForm.Show();

        }
    }
}
