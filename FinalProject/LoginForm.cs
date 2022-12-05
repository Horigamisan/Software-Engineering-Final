using System.Data;
using System.Data.SqlClient;
namespace FinalProject
{
    public partial class LoginForm : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        DataTable tb;

        public LoginForm()
        {
            InitializeComponent();
        }

        public static bool readConfigFile()
        {
            if (File.Exists("config.txt"))
            {
                StreamReader sr = new StreamReader("config.txt");
                string s = sr.ReadLine();
                Program.server = sr.ReadLine();
                Program.db = sr.ReadLine();
                if (s.Equals("sql"))
                {
                    Program.uid = sr.ReadLine();
                    Program.pwd = sr.ReadLine();
                }

                sr.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Configuration file does not exist");
                return false;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {


        }

        public void signin()
        {
            if (readConfigFile() == false)
            {
                ConfigForm f = new ConfigForm();
                f.ShowDialog();
            }
            try
            {
                readConfigFile();
                String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
                MessageBox.Show(s);
                cn = new SqlConnection(s);
                cn.Open();
                String sql = "select * from Account where username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);

                if (tb.Rows.Count == 0)
                {
                    MessageBox.Show("Account does not exist");
                }
                else
                {
                    this.Hide();
                    if (tb.Rows[0][0].ToString().Equals("admin"))
                    {
                        AdminPage f = new AdminPage();
                        f.ShowDialog();
                        cn.Close();
                    }
                    else
                    {
                        UserPage f = new UserPage();
                        f.ShowDialog();
                        cn.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Please configure system");
                ConfigForm f = new ConfigForm();
                f.ShowDialog();
            }

        }

        private void bsignin_Click(object sender, EventArgs e)
        {
            signin();
        }

        private void txtpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rg = new RegisterForm();
            rg.Show();
            this.Hide();
        }
    }
}