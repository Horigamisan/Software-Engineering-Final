using DGVPrinterHelper;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class SettingTeams : Form
    {
        SqlConnection conn;
        SqlDataAdapter data;
        DataTable tb;

        public SettingTeams()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SettingTeams_Load(object sender, EventArgs e)
        {
            loadTeams();
        }
        private void loadTeams()
        {
            String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
            conn = new SqlConnection(s);
            conn.Open();
            data = new SqlDataAdapter("select TPID, team_name, abbreviation, phone_number_team,date_create,state_check from Teams", conn);
            tb = new DataTable();
            data.Fill(tb);
            dataGridTeam.DataSource = tb;
            dataGridTeam.Columns[0].HeaderText = "TPID";
            dataGridTeam.Columns[1].HeaderText = "Team Name";
            dataGridTeam.Columns[2].HeaderText = "Abbreviation";
            dataGridTeam.Columns[3].HeaderText = "Phone number";
            dataGridTeam.Columns[4].HeaderText = "Date Create";
            dataGridTeam.Columns[5].HeaderText = "State";
            conn.Close();
        }

        private void dataGridTeam_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridTeam.SelectedRows.Count == 0)
            {
                return;
            }
            int index = (int)dataGridTeam.SelectedRows[0].Index;
            var TPID = dataGridTeam.Rows[index].Cells[0].Value;
            string teamName = (string)dataGridTeam.Rows[index].Cells[1].Value;
            string abbreviation = (string)dataGridTeam.Rows[index].Cells[2].Value;
            string phone = (string)dataGridTeam.Rows[index].Cells[3].Value;
            var dateCreate = dataGridTeam.Rows[index].Cells[4].Value;
            string state = (string)dataGridTeam.Rows[index].Cells[5].Value;
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            txtTPID.Text = (string)TPID;
            txtName.Text = teamName;
            txtAbbr.Text = abbreviation;
            txtPhone.Text = phone;
            dateTimeCreate.Value = (DateTime)dateCreate;
            txtState.Text = state;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridTeam.ClearSelection();
            btnAdd.Enabled = true;
            txtTPID.Text = "";
            txtPhone.Text = "";
            txtState.Text = "";
            txtAbbr.Text = "";
            txtName.Text = "";
            dateTimeCreate.Value = DateTime.Now;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text == "" || txtAbbr.Text == null || txtAbbr.Text == "" || txtPhone.Text == null || txtPhone.Text == "" || txtState.Text == null || txtState.Text == "")
            {
                MessageBox.Show("Please fill all information");
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
                        String date = dateTimeCreate.Value.ToString("yyyy-MM-dd");
                        sql = "insert into Teams values ('" + tpid + "', '" + txtName.Text + "', '" + txtAbbr.Text + "', '" + txtPhone.Text + "', '" + date + "', '" + "checking" + "')";
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.ExecuteNonQuery();
                        loadTeams();
                        MessageBox.Show("Register team successfully");
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                String date = dateTimeCreate.Value.ToString("yyyy-MM-dd");
                sql = "update Teams set team_name = '" + txtName.Text + "', abbreviation = '" + txtAbbr.Text + "', phone_number_team = '" + txtPhone.Text + "', date_create = '" + date + "', state_check = '" + txtState.Text + "' where TPID = '" + txtTPID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                loadTeams();
                MessageBox.Show("Update team successfully");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
                SqlConnection cn = new SqlConnection(s);
                cn.Open();
                String sql = "delete from Teams where TPID = '" + txtTPID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                loadTeams();
                MessageBox.Show("Delete team successfully");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Team List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Team List";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridTeam);
        }
    }
}
