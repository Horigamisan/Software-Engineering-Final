namespace FinalProject
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtuid.Enabled = false;
                txtpwd.Enabled = false;
            }
            else
            {
                txtuid.Enabled = true;
                txtpwd.Enabled = true;
                txtserver.Focus();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("config.txt");
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Configuration file has been saved");
                sw.WriteLine("window");
                sw.WriteLine(txtserver.Text);
                sw.Write(txtdb.Text);

            }
            else
            {
                sw.WriteLine("sql");
                sw.WriteLine(txtserver.Text);
                sw.WriteLine(txtdb.Text);
                sw.WriteLine(txtuid.Text);
                sw.Write(txtpwd.Text);

            }
            sw.Close();
            this.Close();
        }

        private void txtserver_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }
    }
}
