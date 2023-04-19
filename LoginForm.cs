using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.Design.AxImporter;

namespace FormApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Boolean isAdmin(object data)
        {
            if (data.ToString().Equals("admin"))
            {
                return true;
            }
            return false;
        }

        Boolean countCheck(int data)
        {
            if (data==1)
            {
                return true;
            }
            return false;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string sql = "select userID, accType from account where username = N'" + textBox1.Text + "' and pass = N'" + textBox2.Text + "' ";
            DataTable dt = Connection.selectQuery(sql);

            if (countCheck(dt.Rows.Count) && isAdmin(dt.Rows[0][1])) {

                string adminID = dt.Rows[0][0].ToString();
                AdminForm adminForm = new AdminForm(adminID);
                adminForm.Show();
                this.Close();
            }
            else if (countCheck(dt.Rows.Count))
            {
                string userID = dt.Rows[0][0].ToString();
                UserForm userForm = new UserForm(userID);
                userForm.Show();
                this.Close();
            }
            
            // pop up message

        }
    }
}