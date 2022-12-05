namespace FinalProject
{
    partial class UserViewTeam
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
            this.gridViewTeams = new System.Windows.Forms.DataGridView();
            this.btPrintTeam = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewTeams
            // 
            this.gridViewTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTeams.Location = new System.Drawing.Point(56, 38);
            this.gridViewTeams.MultiSelect = false;
            this.gridViewTeams.Name = "gridViewTeams";
            this.gridViewTeams.ReadOnly = true;
            this.gridViewTeams.RowHeadersWidth = 51;
            this.gridViewTeams.RowTemplate.Height = 29;
            this.gridViewTeams.Size = new System.Drawing.Size(692, 311);
            this.gridViewTeams.TabIndex = 0;
            this.gridViewTeams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTeams_CellContentClick);
            // 
            // btPrintTeam
            // 
            this.btPrintTeam.Location = new System.Drawing.Point(56, 388);
            this.btPrintTeam.Name = "btPrintTeam";
            this.btPrintTeam.Size = new System.Drawing.Size(313, 29);
            this.btPrintTeam.TabIndex = 1;
            this.btPrintTeam.Text = "Print list teams";
            this.btPrintTeam.UseVisualStyleBackColor = true;
            this.btPrintTeam.Click += new System.EventHandler(this.btPrintTeam_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(424, 388);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(324, 29);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // UserViewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btPrintTeam);
            this.Controls.Add(this.gridViewTeams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserViewTeam";
            this.Text = "Teams participate";
            this.Load += new System.EventHandler(this.UserViewTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridViewTeams;
        private Button btPrintTeam;
        private Button btCancel;
    }
}