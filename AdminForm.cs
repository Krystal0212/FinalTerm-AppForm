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

        public AdminForm( String adminID )
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
            if(g.Equals(grd1)) {
                String sql = "select * from CurrentGoods";
                DataTable dt = Connection.selectQuery(sql);
                g.DataSource = dt;
            }
            else if(g.Equals(grd2))
            {
                String sql = "select * from ImportedGoods";
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

            string sql = "select * from GoodstoImport";
            DataTable dt = Connection.selectQuery(sql);
            cb1.DataSource = dt;
            cb1.DisplayMember = "goodName";
            cb1.ValueMember = "goodID";
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
            txtGoodID.Text = grd2.CurrentRow.Cells[0].Value.ToString();
            cb1.Text = grd2.CurrentRow.Cells[1].Value.ToString();
            cb2.Text = grd2.CurrentRow.Cells[2].Value.ToString();
            txtTotalprice.Text = grd2.CurrentRow.Cells[3].Value.ToString();
            dtp.Text = grd2.CurrentRow.Cells[4].Value.ToString();

            bEdit.Enabled = true;

            bDelete.Enabled = true;
        }

        public int calculateDG1(int sl, ComboBox cb)
        {
            String sql = "Select Price from GoodstoImport where goodID = '" + cb1.SelectedValue.ToString() + "' ";
            DataTable dt = Connection.selectQuery(sql);
            if(dt.Rows.Count == 0 )
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

            txtGoodID.Enabled = true;

            dtp.Enabled= true;


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

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            form_load();
        }

        public Boolean isExist(string txt)
        {
            string sql = "select username from account where goodID = N'" + txt + "' ";
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
            if (isExist(ma + "0001"))
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

        private string convertDate (DateTimePicker d)
        {
            DateTime date = d.Value;
            string day = date.Day.ToString();
            string month = date.Month.ToString();

            if(date.Month < 10)
            {
                month = "0" + date.Month;
            }

            if(date.Day < 10)
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
                string s = "update ImportedGoods set goodID = '" + txtGoodID.Text + "', set goodName = '" + cb1.Text + "',set Quantity = '" + cb1.Text + ",set Price = '" + txtTotalprice.Text + " , added_date = '" + convertDate(dtp) + "' where goodId = '" + txtGoodID.Text + "'";
                Connection.actionQuery(s);
            }
            form_load();
        }


        private void cb2_TextChanged(object sender, EventArgs e)
        {
            txtTotalprice.Text = calculateDG1(Int32.Parse(cb2.Text), cb1).ToString();
        }
    }
}
