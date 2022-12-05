namespace FinalProject
{
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void bViewTeam_Click(object sender, EventArgs e)
        {
            UserViewTeam userViewTeam = new UserViewTeam();
            userViewTeam.Show();
        }

        private void bRegisterTeam_Click(object sender, EventArgs e)
        {
            RegisterTeam registerTeam = new RegisterTeam();
            registerTeam.Show();
        }

        private void bViewSchedule_Click(object sender, EventArgs e)
        {
            TournamentSchedule tournamentSchedule = new TournamentSchedule();
            tournamentSchedule.Show();
        }

        private void bLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardUser leaderboardUser = new LeaderboardUser();
            leaderboardUser.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserPage_Load(object sender, EventArgs e)
        {

        }
    }
}
