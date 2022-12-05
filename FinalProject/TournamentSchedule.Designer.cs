namespace FinalProject
{
    partial class TournamentSchedule
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btPrintTour = new System.Windows.Forms.Button();
            this.gridViewTour = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTour)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(563, 472);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(389, 29);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btPrintTour
            // 
            this.btPrintTour.Location = new System.Drawing.Point(54, 472);
            this.btPrintTour.Name = "btPrintTour";
            this.btPrintTour.Size = new System.Drawing.Size(389, 29);
            this.btPrintTour.TabIndex = 4;
            this.btPrintTour.Text = "Print schedules";
            this.btPrintTour.UseVisualStyleBackColor = true;
            this.btPrintTour.Click += new System.EventHandler(this.btPrintTour_Click);
            // 
            // gridViewTour
            // 
            this.gridViewTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTour.Location = new System.Drawing.Point(54, 36);
            this.gridViewTour.MultiSelect = false;
            this.gridViewTour.Name = "gridViewTour";
            this.gridViewTour.ReadOnly = true;
            this.gridViewTour.RowHeadersWidth = 51;
            this.gridViewTour.RowTemplate.Height = 29;
            this.gridViewTour.Size = new System.Drawing.Size(898, 396);
            this.gridViewTour.TabIndex = 3;
            this.gridViewTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTour_CellContentClick);
            // 
            // TournamentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 527);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btPrintTour);
            this.Controls.Add(this.gridViewTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TournamentSchedule";
            this.Text = "Tournament schedule";
            this.Load += new System.EventHandler(this.TournamentSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btCancel;
        private Button btPrintTour;
        private DataGridView gridViewTour;
    }
}