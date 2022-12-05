namespace FinalProject
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            SettingTeams settingTeams = new SettingTeams();
            settingTeams.Show();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            SettingTournament settingTournament = new SettingTournament();
            settingTournament.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
