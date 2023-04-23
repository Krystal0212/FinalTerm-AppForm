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


        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (data == 1)
            {
                return true;
            }
            return false;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string sql = "select username, accType from account where username = N'" + textBox1.Text + "' and pass = N'" + textBox2.Text + "' ";
            DataTable dt = Connection.selectQuery(sql);

            if (countCheck(dt.Rows.Count) && isAdmin(dt.Rows[0][1]))
            {

                string adminID = dt.Rows[0][0].ToString();
                this.Close();
                AdminForm adminForm = new AdminForm(adminID);
                adminForm.Show();

            }
            else if (countCheck(dt.Rows.Count))
            {
                string userID = dt.Rows[0][0].ToString();
                UserForm userForm = new UserForm(userID);
                userForm.Show();
                this.Close();
            }
            else
            {
                string message = "Invalid information, do you want to try again ?";
                string title = "Caution !";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                }
                else
                {
                    Application.Exit();
                }
            }
            // pop up message

        }
    }
}