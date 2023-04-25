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

namespace FormApp
{
    public partial class AdminForm : Form
    {
        string adminID;
        int dk = 0;
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(String adminID)
        {
            this.adminID = adminID;
            InitializeComponent();
        }
        void vohieuhoa(System.Windows.Forms.GroupBox g, bool b)
        {

            g.Enabled = b;

        }
        private void htGRD(DataGridView g)
        {
            if (g.Equals(grd1))
            {
                String sql = "select goodId as 'Good ID', goodName as 'Good Name', Quantity, Price as 'Price / Item' from CurrentGoods order by goodID asc";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            else if (g.Equals(grd2))
            {
                String sql = "select goodId as 'Good ID', goodName as 'Good Name', Quantity, Price as 'Total Price', added_date as 'Added Date' from ImportedGoods order by goodID asc";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            else if (g.Equals(grd3))
            {
                String sql = "select ticketID as 'Ticket ID', username as 'Added by' from Ticket order by ticketID asc";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            
        }

        private void form_load()
        {
            cb1.Enabled = false;

            cb2.Enabled = false;

            txtTotalprice.Enabled = false;

            txtGoodID.Enabled = false;

            dtp.Enabled = false;

            bAdd.Enabled = true;

            bCancel.Enabled = false;

            bEdit.Enabled = true;

            bDelete.Enabled = false;

            bSave.Enabled = false;

            htGRD(grd1);

            htGRD(grd2);

            htGRD(grd3);
            string sql = "select * from GoodstoImport";
            DataTable dt = Connection.selectQuery(sql);
            cb1.DataSource = dt;
            cb1.DisplayMember = "goodName";
            cb1.ValueMember = "goodID";

            string sql2 = "select username from account where username = '" + adminID + "'";
            DataTable dt2 = Connection.selectQuery(sql2);

            user.Text = dt2.Rows[0][0].ToString();
            user.Text = "Welcome " + user.Text;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            form_load();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void grd2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int calculateDG1(int sl, ComboBox cb)
        {
            String sql = "Select Price from GoodstoImport where goodID = '" + cb1.SelectedValue.ToString() + "' ";
            DataTable dt = Connection.selectQuery(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("cc");
                return 0;
            }
            int dg = Int32.Parse(dt.Rows[0][0].ToString());
            int result = sl * dg;
            return result;
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            cb1.Focus();

            cb1.Enabled = true;

            cb2.Enabled = true;

            txtGoodID.ReadOnly = true;

            dtp.Enabled = true;

            txtGoodID.Text = getID("I", "ImportedGoods", "goodID");

            dk = 1;

            bSave.Enabled = true;
            bCancel.Enabled = true;

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            cb1.Focus();
            cb1.Enabled = true;

            cb2.Enabled = true;
            dtp.Enabled = true;

            dk = 2;

            bSave.Enabled = true;
            bCancel.Enabled = true;

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from ImportedGoods where goodId ='" + txtGoodID.Text + "'";
                Connection.actionQuery(sql);
                form_load();
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb2.Focus();

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            form_load();
        }

        Boolean countCheck(int data)
        {
            if (data == 1)
            {
                return true;
            }
            return false;
        }
        public Boolean isExist(string txt, string tableName, string IDName)
        {
            string sql = " select * from " + tableName + " where " + IDName + " = N'" + txt + "' ";
            DataTable dt = Connection.selectQuery(sql);
            if (countCheck(dt.Rows.Count))
            {
                return true;
            }
            return false;
        }

        private string checkCurrentID(string tableName, string IDName)
        {
            string sql = " select * from " + tableName + " order by " + IDName + "";
            DataTable dt = Connection.selectQuery(sql);


            return dt.Rows[dt.Rows.Count - 1][0].ToString();
        }

        private string getID(string ma, string tableName, string IDName)
        {
            string slang = "";
            if (!isExist(ma + "0001", tableName, IDName))
            {
                slang = ma + "0001";
            }
            else
            {
                string maIDtruoc = checkCurrentID(tableName, IDName);
                int txtNum = Int16.Parse(maIDtruoc.Substring(maIDtruoc.Length - 4));
                slang = ma + generateID(txtNum);
            }

            return slang;
        }

        private string generateID(int num)
        {
            string res = (++num).ToString();
            int checker = 10;
            while (res.Length < 4)
            {
                double a = res.Length;
                if (Int16.Parse(res) > checker)
                {
                    checker = checker * 10;
                }
                else
                {
                    res = "0" + res;
                }
            }
            return res;
        }

        private string convertDate(DateTimePicker d)
        {
            DateTime date = d.Value;
            string day = date.Day.ToString();
            string month = date.Month.ToString();

            if (date.Month < 10)
            {
                month = "0" + date.Month;
            }

            if (date.Day < 10)
            {
                day = "0" + date.Day;
            }

            string year = date.Year.ToString();
            string final = year + "/" + month + "/" + day;
            string a = "";
            return final;

        }
        private void bSave_Click(object sender, EventArgs e)
        {

            if (dk == 1)
            {
                string s = "select * from ImportedGoods where goodId = '" + txtGoodID.Text + "' ";
                DataTable data = Connection.selectQuery(s);
                if (data.Rows.Count > 0)
                {
                    MessageBox.Show("Goods already existed, please choose the others or change the quantity !");
                    return;
                }

                s = "insert into ImportedGoods values ('" + txtGoodID.Text + "','" + cb1.Text + "','" + cb2.Text + "','" + txtTotalprice.Text + "','" + convertDate(dtp) + "')";
                Connection.actionQuery(s);
            }
            else //dk =2
            {
                //Update
                string s = "update ImportedGoods set goodID = '" + txtGoodID.Text + "', goodName = '" + cb1.Text + "',Quantity = '" + cb2.Text + "',Price = '" + txtTotalprice.Text + "' , added_date = '" + convertDate(dtp) + "' where goodId = '" + txtGoodID.Text + "'";
                Connection.actionQuery(s);
            }
            form_load();
        }


        private void cb2_TextChanged(object sender, EventArgs e)
        {
            txtTotalprice.Text = calculateDG1(Int32.Parse(cb2.Text), cb1).ToString();
        }

        private void grd2_Click(object sender, EventArgs e)
        {
            txtGoodID.Text = grd2.CurrentRow.Cells[0].Value.ToString();
            cb1.Text = grd2.CurrentRow.Cells[1].Value.ToString();
            cb2.Text = grd2.CurrentRow.Cells[2].Value.ToString();
            txtTotalprice.Text = grd2.CurrentRow.Cells[3].Value.ToString();
            dtp.Text = grd2.CurrentRow.Cells[4].Value.ToString();

            bEdit.Enabled = true;

            bDelete.Enabled = true;
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            string sql = "Select * from ImportedGoods";
            DataTable data = Connection.selectQuery(sql);
            if (data.Rows.Count > 0)
            {
                string sql2 = "Delete from ImportedGoods";
                Connection.actionQuery(sql2);
                form_load();
                MessageBox.Show("Succesful deleted all of your added goods !");
            }
            else
            {
                MessageBox.Show("Nothing here to be deleted !");
            }
        }

        private void insert_DetailTicket()
        {
            string sql2 = "insert into Detail_Ticket (goodID, goodName,Quantity, Price, added_date)\r\nselect * from importedgoods";
            Connection.actionQuery(sql2);
        }

        private void update_DetailTicketID(string ticketID)
        {
            string sql3 = "update Detail_Ticket set ticketID = '" + ticketID + "' where ticketID is Null";
            Connection.actionQuery(sql3);

        }

        private void StockChange(string ticketID)
        {
            string sql = "select goodID, goodName, Quantity from CurrentGoods order by goodID asc";
            DataTable data1 = Connection.selectQuery(sql);

            string sql2 = "select goodID, goodName, Quantity, Price from Detail_Ticket where ticketID = '" + ticketID + "' order by goodID asc";
            DataTable data2 = Connection.selectQuery(sql2);

            for (int i = 0; i < data2.Rows.Count; i++)
            {
                data1 = Connection.selectQuery(sql);
                data2 = Connection.selectQuery(sql2);
                string goodName = data2.Rows[i][1].ToString();
                int checker = 0;
                for (int j = 0; j < data1.Rows.Count; j++)
                {
                    int newQuantity = 0;
                    if (goodName.Equals(data1.Rows[j][1].ToString()))
                    {
                        newQuantity = Int32.Parse(data1.Rows[j][2].ToString()) + Int32.Parse(data2.Rows[i][2].ToString());
                        string sql3 = "update CurrentGoods set quantity = '"+ newQuantity+ "' where goodName = '" + goodName + "'";
                        Connection.actionQuery(sql3);
                    }
                    else if(goodName.Equals(data1.Rows[j][1].ToString()) == false)
                    {
                        checker = checker + 1;
                        if(checker == data1.Rows.Count)
                        {
                            string sql4 = "insert into CurrentGoods values('" + getID("I", "CurrentGoods", "goodID") + "', '" + data2.Rows[i][1].ToString() + "', '" + Int32.Parse(data2.Rows[i][2].ToString()) + "', '" + Int32.Parse(data2.Rows[i][3].ToString()) / Int32.Parse(data2.Rows[i][2].ToString()) + "')";
                            Connection.actionQuery(sql4);
                        }
                    }
                }
            }
        }
        private void bExport_Click(object sender, EventArgs e)
        {
            string sq3 = "Select * from ImportedGoods";
            DataTable data = Connection.selectQuery(sq3);
            if (data.Rows.Count > 0)
            {
                string sql = "insert into Ticket values('" + getID("TK", "Ticket", "ticketID") + "','" + adminID + "')";
                Connection.actionQuery(sql);
                form_load();

                insert_DetailTicket();

                string sql2 = "select ticketID from Ticket order by ticketID desc";
                DataTable data2 = Connection.selectQuery(sql2);
                update_DetailTicketID(data2.Rows[0][0].ToString());

                StockChange(data2.Rows[0][0].ToString());
                htGRD(grd1);
            }
            else
            {
                MessageBox.Show("Nothing here to be exported !");
            }

            

        }

        private void htDetail_Ticket(string ticketID)
        {

            String sql = "select goodId as 'Good ID', goodName as 'Good Name', Quantity, Price as 'Total Price', added_date as 'Added Date' from Detail_Ticket where ticketID = '" + ticketID + "' order by goodID asc ";
            DataTable dt = Connection.selectQuery(sql);
            grd4.DataSource = dt;

        }
        private void grd3_Click(object sender, EventArgs e)
        {
            ticketLabel.Text = grd3.CurrentRow.Cells[0].Value.ToString();
            htDetail_Ticket(ticketLabel.Text);
        }

    }
}
