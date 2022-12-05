using DGVPrinterHelper;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class TournamentSchedule : Form
    {

        SqlConnection conn;
        SqlDataAdapter data;
        DataTable tb;

        public TournamentSchedule()
        {
            InitializeComponent();
        }

        private void TournamentSchedule_Load(object sender, EventArgs e)
        {
            String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
            conn = new SqlConnection(s);
            conn.Open();
            data = new SqlDataAdapter("select TMID, team_name_one, score_one, team_name_two, score_two, date_start, match_state from Tournament", conn);
            tb = new DataTable();
            data.Fill(tb);
            gridViewTour.DataSource = tb;
            gridViewTour.Columns[0].HeaderText = "TMID";
            gridViewTour.Columns[1].HeaderText = "First team";
            gridViewTour.Columns[2].HeaderText = "Score's first team";
            gridViewTour.Columns[3].HeaderText = "Second team";
            gridViewTour.Columns[4].HeaderText = "Score's second team";
            gridViewTour.Columns[5].HeaderText = "Date start";
            gridViewTour.Columns[6].HeaderText = "Match stadium";
            conn.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPrintTour_Click(object sender, EventArgs e)
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
            printer.PrintDataGridView(gridViewTour);
        }

        private void gridViewTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
