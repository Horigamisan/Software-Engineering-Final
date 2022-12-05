using DGVPrinterHelper;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class LeaderboardUser : Form
    {
        SqlConnection conn;
        SqlDataAdapter data;
        DataTable tb;

        public LeaderboardUser()
        {
            InitializeComponent();
        }

        private void gridViewLeaderboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LeaderboardUser_Load(object sender, EventArgs e)
        {
            String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
            conn = new SqlConnection(s);
            conn.Open();
            data = new SqlDataAdapter("select LBID, team_name, score_home, score_away, sum_score from Leaderboard order by sum_score desc", conn);
            tb = new DataTable();
            data.Fill(tb);
            gridViewLeaderboard.DataSource = tb;
            gridViewLeaderboard.Columns[0].HeaderText = "LBID";
            gridViewLeaderboard.Columns[1].HeaderText = "Team's name";
            gridViewLeaderboard.Columns[2].HeaderText = "Score's home";
            gridViewLeaderboard.Columns[3].HeaderText = "Score's away";
            gridViewLeaderboard.Columns[4].HeaderText = "Total score";
            conn.Close();
        }

        private void btPrintLead_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Leaderboard";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Leaderboard";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(gridViewLeaderboard);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
