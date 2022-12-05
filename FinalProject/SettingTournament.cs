using DGVPrinterHelper;
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
using System.Xml.Linq;

namespace FinalProject
{
    public partial class SettingTournament : Form
    {
        SqlConnection conn;
        SqlDataAdapter data;
        DataTable tb;
        
        public SettingTournament()
        {
            InitializeComponent();
        }

        private void dataGridTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SettingTournament_Load(object sender, EventArgs e)
        {
            loadTours();
        }
        
        private void loadTours()
        {
            String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
            conn = new SqlConnection(s);
            conn.Open();
            data = new SqlDataAdapter("select TMID, team_name_one, score_one, team_name_two, score_two, date_start, match_state, is_finished from Tournament", conn);
            tb = new DataTable();
            data.Fill(tb);
            dataGridTour.DataSource = tb;
            dataGridTour.Columns[0].HeaderText = "TMID";
            dataGridTour.Columns[1].HeaderText = "First team";
            dataGridTour.Columns[2].HeaderText = "Score's first team";
            dataGridTour.Columns[3].HeaderText = "Second team";
            dataGridTour.Columns[4].HeaderText = "Score's second team";
            dataGridTour.Columns[5].HeaderText = "Date start";
            dataGridTour.Columns[6].HeaderText = "Match stadium";
            dataGridTour.Columns[7].HeaderText = "Finished";
            conn.Close();
        }

        private void dataGridTour_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridTour.SelectedRows.Count == 0)
            {
                return;
            }
            int index = (int)dataGridTour.SelectedRows[0].Index;
            var TMID = dataGridTour.Rows[index].Cells[0].Value;
            string teamNameOne = (string)dataGridTour.Rows[index].Cells[1].Value;
            int scoreOne = (int)dataGridTour.Rows[index].Cells[2].Value;
            string teamNameTwo = (string)dataGridTour.Rows[index].Cells[3].Value;
            int scoreTwo = (int)dataGridTour.Rows[index].Cells[4].Value;
            var dateStart = dataGridTour.Rows[index].Cells[5].Value;
            string matchState = (string)dataGridTour.Rows[index].Cells[6].Value;
            string isFinished = (string)dataGridTour.Rows[index].Cells[7].Value;
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            txtTMID.Text = TMID.ToString();
            txtTeamOne.Text = teamNameOne;
            txtScoreOne.Text = scoreOne.ToString();
            txtTeamTwo.Text = teamNameTwo;
            txtScoreTwo.Text = scoreTwo.ToString();
            dateTimeStart.Value = (DateTime)dateStart;
            txtMatch.Text = matchState;
            txtFinished.Text = isFinished;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridTour.ClearSelection();
            txtTMID.Text = "";
            txtTeamOne.Text = "";
            txtScoreOne.Text = "";
            txtTeamTwo.Text = "";
            txtScoreTwo.Text = "";
            dateTimeStart.Value = DateTime.Now;
            txtMatch.Text = "";
            txtFinished.Text = "";
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTeamOne.Text == "" || txtScoreOne.Text == "" || txtTeamTwo.Text == "" || txtScoreTwo.Text == "" || txtMatch.Text == "" || txtFinished.Text == "")
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
                    String sql = "select * from Tournament where team_name_one = '" + txtTeamOne.Text + "'" + "and team_name_two = '" + txtTeamTwo.Text + "'";
                    SqlDataAdapter data = new SqlDataAdapter(sql, cn);
                    DataTable tb = new DataTable();
                    data.Fill(tb);
                    if (tb.Rows.Count > 0)
                    {
                        MessageBox.Show("Teams are already in the tournament");
                        return;
                    }
                    else
                    {
                        int stt = 0;
                        String tmid = "";
                        String st = "select top 1 TMID from Tournament order by TMID desc";
                        SqlDataAdapter data1 = new SqlDataAdapter(st, cn);
                        DataTable tb1 = new DataTable();
                        data1.Fill(tb1);
                        if (tb1.Rows.Count > 0)
                        {
                            tmid = tb1.Rows[0][0].ToString();
                            stt = Int32.Parse(tmid.Substring(2)) + 1;
                            if (stt < 10)
                            {
                                tmid = "TM00" + stt;
                            }
                            else if (stt < 100)
                            {
                                tmid = "TM0" + stt;
                            }
                            else
                            {
                                tmid = "TM" + stt;
                            }
                        }
                        String date = dateTimeStart.Value.ToString("yyyy-MM-dd");
                        String sql1 = "insert into Tournament values('" + tmid + "', '" + txtTeamOne.Text + "', '" + txtTeamTwo.Text + "', '" + txtScoreOne.Text + "', '" + txtScoreTwo.Text + "', '" + date + "', '" + txtFinished.Text + "', '" + txtMatch.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql1, cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Add successfully");
                        loadTours();
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
                SqlConnection cn = new SqlConnection(s);
                cn.Open();
                String sql = "delete from Tournament where TMID = '" + txtTMID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                loadTours();
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
            printer.Title = "Tournament Schedule";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Tournament Schedule";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridTour);
        }
    }
}
