using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            vohieuhoa(grp1, false);

            bAdd.Enabled = true;

            bEdit.Enabled = false;

            bDelete.Enabled = false;

            bSave.Enabled = false;

            htGRD(grd1);
            htGRD(grd2);
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
            bEdit.Enabled = true;

            bDelete.Enabled = true;
        }
    }
}
