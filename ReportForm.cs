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
    public partial class ReportForm : Form
    {
        string adminID;

        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(String adminID)
        {
            this.adminID = adminID;
            InitializeComponent();
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void form_load()
        {

            cbOut.Text = "";
            cbIn.Text = "";

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            form_load();
        }

        private void htGRD(DataGridView g)
        {
            if (g.Equals(grd1))
            {
                string month = cbOut.Text;
                string sql = "select orderID as 'Order ID', createdDay as 'Created day', totalPrice as 'Total price' from ExportedSlips where MONTH(createdDay) = '" + month + "'";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            else if (g.Equals(grd2))
            {
                String sql = "select itemId as 'Item ID', itemName as 'Item Name', pricePerItem as 'Price / Item', quantity as 'Quantity', totalPrice as 'Total price' from ExportedSlipsDetail where orderID = '"+OrderIDlabel.Text+"'";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            else if (g.Equals(grd3))
            {
                string month = cbIn.Text;
                String sql = "select goodID as 'Good ID',goodName as 'Good Name', quantity as 'Quantity', price as 'Total price', added_date as 'Imported day' from Detail_Ticket where MONTH(added_date) = '" + month + "'";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            else if (g.Equals(grd4))
            {
                string month = cbRevenue.Text;
                String sql = "select cast(SUM(totalPrice) as nvarchar(30)) + ' $' as Revenue from ExportedSlips where MONTH(createdDay) = '" + month + "'";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }

        }

        private void cbOut_TextChanged(object sender, EventArgs e)
        {

            htGRD(grd1);
        }

        private void grd1_Click(object sender, EventArgs e)
        {
            OrderIDlabel.Text = grd1.CurrentRow.Cells[0].Value.ToString();
            htGRD(grd2);
        }

        private void cbIn_TextChanged(object sender, EventArgs e)
        {
            htGRD(grd3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select TOP 1 itemName\r\nfrom ExportedSlipsDetail\r\ngroup by itemname\r\norder by Count(itemName) DESC";
            DataTable dt = Connection.selectQuery(sql);
            string bestselling = dt.Rows[0][0].ToString();
            MessageBox.Show(" "+bestselling+" ", "Best selling products");
        }

        private void cbRevenue_TextChanged(object sender, EventArgs e)
        {
            htGRD(grd4);
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(adminID);
            adminForm.Show();
        }
    }
}
