namespace FinalProject
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTeam = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.btnLeader = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTeam
            // 
            this.btnTeam.Location = new System.Drawing.Point(33, 459);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(224, 29);
            this.btnTeam.TabIndex = 1;
            this.btnTeam.Text = "Setting teams";
            this.btnTeam.UseVisualStyleBackColor = true;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // btnTour
            // 
            this.btnTour.Location = new System.Drawing.Point(493, 459);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(224, 29);
            this.btnTour.TabIndex = 2;
            this.btnTour.Text = "Setting tournament";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnLeader
            // 
            this.btnLeader.Location = new System.Drawing.Point(723, 459);
            this.btnLeader.Name = "btnLeader";
            this.btnLeader.Size = new System.Drawing.Size(224, 29);
            this.btnLeader.TabIndex = 3;
            this.btnLeader.Text = "Setting leaderboard";
            this.btnLeader.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(263, 459);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(224, 29);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Setting users";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(723, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(224, 29);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 533);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnLeader);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.btnTeam);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPage";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnTeam;
        private Button btnTour;
        private Button btnLeader;
        private Button btnUsers;
        private Button btnLogout;
    }
}