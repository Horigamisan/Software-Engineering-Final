namespace FinalProject
{
    partial class LeaderboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridViewLeaderboard = new System.Windows.Forms.DataGridView();
            this.btCancel = new System.Windows.Forms.Button();
            this.btPrintLead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gridViewLeaderboard
            // 
            this.gridViewLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLeaderboard.Location = new System.Drawing.Point(470, 54);
            this.gridViewLeaderboard.Name = "gridViewLeaderboard";
            this.gridViewLeaderboard.RowHeadersWidth = 51;
            this.gridViewLeaderboard.RowTemplate.Height = 29;
            this.gridViewLeaderboard.Size = new System.Drawing.Size(638, 299);
            this.gridViewLeaderboard.TabIndex = 1;
            this.gridViewLeaderboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewLeaderboard_CellContentClick);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(623, 412);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(485, 29);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btPrintLead
            // 
            this.btPrintLead.Location = new System.Drawing.Point(54, 412);
            this.btPrintLead.Name = "btPrintLead";
            this.btPrintLead.Size = new System.Drawing.Size(508, 29);
            this.btPrintLead.TabIndex = 6;
            this.btPrintLead.Text = "Print leaderboard";
            this.btPrintLead.UseVisualStyleBackColor = true;
            this.btPrintLead.Click += new System.EventHandler(this.btPrintLead_Click);
            // 
            // LeaderboardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 503);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btPrintLead);
            this.Controls.Add(this.gridViewLeaderboard);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeaderboardUser";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.LeaderboardUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLeaderboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView gridViewLeaderboard;
        private Button btCancel;
        private Button btPrintLead;
    }
}