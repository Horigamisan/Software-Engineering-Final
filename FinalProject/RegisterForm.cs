using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void bBackSignin_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == null || txtPass.Text == "" || txtPassConfirm.Text == null || txtPassConfirm.Text == "" || txtUser.Text == null || txtUser.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else if (txtPass.Text != txtPassConfirm.Text)
            {
                MessageBox.Show("Password does not match");
                return;
            }
            else
                if (LoginForm.readConfigFile() == false)
            {
                ConfigForm f = new ConfigForm();
                f.ShowDialog();
            }
            LoginForm.readConfigFile();
            try
            {
                String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
                MessageBox.Show(s);
                SqlConnection cn = new SqlConnection(s);
                cn.Open();
                String sql = "select * from Account where username = '" + txtUser.Text + "'";
                SqlDataAdapter data = new SqlDataAdapter(sql, cn);
                DataTable tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exists");
                }
                else
                {
                    sql = "insert into Account values('" + txtUser.Text + "', '" + txtPass.Text + "', '" + txtAddress.Text + "', '" + txtPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register successfully");
                    this.Close();
                    LoginForm f = new LoginForm();
                    f.Show();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
