namespace FinalProject
{
    partial class UserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHome = new System.Windows.Forms.Label();
            this.bRegisterTeam = new System.Windows.Forms.Button();
            this.bViewTeam = new System.Windows.Forms.Button();
            this.bViewSchedule = new System.Windows.Forms.Button();
            this.bLeaderboard = new System.Windows.Forms.Button();
            this.bLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHome.Location = new System.Drawing.Point(404, 9);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(183, 41);
            this.lbHome.TabIndex = 1;
            this.lbHome.Text = "HOMEPAGE";
            this.lbHome.Click += new System.EventHandler(this.label1_Click);
            // 
            // bRegisterTeam
            // 
            this.bRegisterTeam.Location = new System.Drawing.Point(48, 73);
            this.bRegisterTeam.Name = "bRegisterTeam";
            this.bRegisterTeam.Size = new System.Drawing.Size(232, 29);
            this.bRegisterTeam.TabIndex = 2;
            this.bRegisterTeam.Text = "Register team";
            this.bRegisterTeam.UseVisualStyleBackColor = true;
            this.bRegisterTeam.Click += new System.EventHandler(this.bRegisterTeam_Click);
            // 
            // bViewTeam
            // 
            this.bViewTeam.Location = new System.Drawing.Point(48, 151);
            this.bViewTeam.Name = "bViewTeam";
            this.bViewTeam.Size = new System.Drawing.Size(232, 29);
            this.bViewTeam.TabIndex = 3;
            this.bViewTeam.Text = "View teams participate";
            this.bViewTeam.UseVisualStyleBackColor = true;
            this.bViewTeam.Click += new System.EventHandler(this.bViewTeam_Click);
            // 
            // bViewSchedule
            // 
            this.bViewSchedule.Location = new System.Drawing.Point(48, 229);
            this.bViewSchedule.Name = "bViewSchedule";
            this.bViewSchedule.Size = new System.Drawing.Size(232, 29);
            this.bViewSchedule.TabIndex = 4;
            this.bViewSchedule.Text = "Tournament schedules";
            this.bViewSchedule.UseVisualStyleBackColor = true;
            this.bViewSchedule.Click += new System.EventHandler(this.bViewSchedule_Click);
            // 
            // bLeaderboard
            // 
            this.bLeaderboard.Location = new System.Drawing.Point(48, 306);
            this.bLeaderboard.Name = "bLeaderboard";
            this.bLeaderboard.Size = new System.Drawing.Size(232, 29);
            this.bLeaderboard.TabIndex = 5;
            this.bLeaderboard.Text = "View leaderboard ";
            this.bLeaderboard.UseVisualStyleBackColor = true;
            this.bLeaderboard.Click += new System.EventHandler(this.bLeaderboard_Click);
            // 
            // bLogout
            // 
            this.bLogout.Location = new System.Drawing.Point(819, 378);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(94, 29);
            this.bLogout.TabIndex = 6;
            this.bLogout.Text = "Log out";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.bLeaderboard);
            this.Controls.Add(this.bViewSchedule);
            this.Controls.Add(this.bViewTeam);
            this.Controls.Add(this.bRegisterTeam);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserPage";
            this.Text = "Home page";
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbHome;
        private Button bRegisterTeam;
        private Button bViewTeam;
        private Button bViewSchedule;
        private Button bLeaderboard;
        private Button bLogout;
    }
}