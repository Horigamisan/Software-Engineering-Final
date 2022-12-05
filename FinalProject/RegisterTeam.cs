using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class RegisterTeam : Form
    {
        public RegisterTeam()
        {
            InitializeComponent();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text == "" || txtAbbre.Text == null || txtAbbre.Text == "" || txtPhone.Text == null || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                try
                {
                    String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
                    SqlConnection cn = new SqlConnection(s);
                    cn.Open();
                    String sql = "select * from Teams where team_name = '" + txtName.Text + "'";
                    SqlDataAdapter data = new SqlDataAdapter(sql, cn);
                    DataTable tb = new DataTable();
                    data.Fill(tb);
                    if (tb.Rows.Count > 0)
                    {
                        MessageBox.Show("Team name already exists");
                        return;
                    }
                    else
                    {
                        int stt = 0;
                        String tpid = "";
                        String st = "select top 1 TPID from Teams order by TPID desc";
                        SqlDataAdapter data1 = new SqlDataAdapter(st, cn);
                        DataTable tb1 = new DataTable();
                        data1.Fill(tb1);
                        if (tb1.Rows.Count > 0)
                        {
                            tpid = tb1.Rows[0][0].ToString();
                            stt = Int32.Parse(tpid.Substring(2)) + 1;
                            if (stt < 10)
                            {
                                tpid = "TP00" + stt;
                            }
                            else if (stt < 100)
                            {
                                tpid = "TP0" + stt;
                            }
                            else
                            {
                                tpid = "TP" + stt;
                            }
                        }
                        String date = dateStart.Value.ToString("yyyy-MM-dd");
                        sql = "insert into Teams values ('" + tpid + "', '" + txtName.Text + "', '" + txtAbbre.Text + "', '" + txtPhone.Text + "', '" + date + "', '" + "checking" + "')";
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Register team successfully");
                        this.Close();
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegisterTeam_Load(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
