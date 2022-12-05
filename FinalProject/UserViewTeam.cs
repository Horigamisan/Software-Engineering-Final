using DGVPrinterHelper;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class UserViewTeam : Form
    {
        SqlConnection conn;
        SqlDataAdapter data;
        DataTable tb;
        public UserViewTeam()
        {
            InitializeComponent();
        }

        private void gridViewTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserViewTeam_Load(object sender, EventArgs e)
        {
            String s = "server = " + Program.server + "; database = " + Program.db + "; uid = " + Program.uid + "; pwd = " + Program.pwd + "; Trusted_Connection=true";
            conn = new SqlConnection(s);
            conn.Open();
            data = new SqlDataAdapter("select TPID, team_name, abbreviation, date_create from Teams", conn);
            tb = new DataTable();
            data.Fill(tb);
            gridViewTeams.DataSource = tb;
            gridViewTeams.Columns[0].HeaderText = "TPID";
            gridViewTeams.Columns[1].HeaderText = "Team Name";
            gridViewTeams.Columns[2].HeaderText = "Abbreviation";
            gridViewTeams.Columns[3].HeaderText = "Date Create";
            conn.Close();
        }

        private void btPrintTeam_Click(object sender, EventArgs e)
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
            printer.PrintDataGridView(gridViewTeams);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
