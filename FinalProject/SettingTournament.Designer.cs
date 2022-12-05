namespace FinalProject
{
    partial class SettingTournament
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTMID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridTour = new System.Windows.Forms.DataGridView();
            this.txtFinished = new System.Windows.Forms.TextBox();
            this.txtScoreOne = new System.Windows.Forms.TextBox();
            this.txtTeamTwo = new System.Windows.Forms.TextBox();
            this.txtTeamOne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtScoreTwo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTour)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(608, 557);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 29);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTMID
            // 
            this.txtTMID.Enabled = false;
            this.txtTMID.Location = new System.Drawing.Point(225, 32);
            this.txtTMID.Name = "txtTMID";
            this.txtTMID.Size = new System.Drawing.Size(498, 27);
            this.txtTMID.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "TMID";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(478, 558);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 29);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 557);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 29);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(215, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 29);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 557);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 29);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridTour
            // 
            this.dataGridTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTour.Location = new System.Drawing.Point(83, 303);
            this.dataGridTour.MultiSelect = false;
            this.dataGridTour.Name = "dataGridTour";
            this.dataGridTour.RowHeadersWidth = 51;
            this.dataGridTour.RowTemplate.Height = 29;
            this.dataGridTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTour.Size = new System.Drawing.Size(640, 236);
            this.dataGridTour.TabIndex = 28;
            this.dataGridTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTour_CellContentClick);
            this.dataGridTour.SelectionChanged += new System.EventHandler(this.dataGridTour_SelectionChanged);
            // 
            // txtFinished
            // 
            this.txtFinished.Location = new System.Drawing.Point(225, 194);
            this.txtFinished.Name = "txtFinished";
            this.txtFinished.Size = new System.Drawing.Size(498, 27);
            this.txtFinished.TabIndex = 27;
            // 
            // txtScoreOne
            // 
            this.txtScoreOne.Location = new System.Drawing.Point(225, 128);
            this.txtScoreOne.Name = "txtScoreOne";
            this.txtScoreOne.Size = new System.Drawing.Size(498, 27);
            this.txtScoreOne.TabIndex = 25;
            // 
            // txtTeamTwo
            // 
            this.txtTeamTwo.Location = new System.Drawing.Point(225, 95);
            this.txtTeamTwo.Name = "txtTeamTwo";
            this.txtTeamTwo.Size = new System.Drawing.Size(498, 27);
            this.txtTeamTwo.TabIndex = 24;
            // 
            // txtTeamOne
            // 
            this.txtTeamOne.Location = new System.Drawing.Point(225, 62);
            this.txtTeamOne.Name = "txtTeamOne";
            this.txtTeamOne.Size = new System.Drawing.Size(498, 27);
            this.txtTeamOne.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Finished:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Score\'s team two:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Score\'s team one:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Team two:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Team one:";
            // 
            // txtMatch
            // 
            this.txtMatch.Location = new System.Drawing.Point(225, 227);
            this.txtMatch.Name = "txtMatch";
            this.txtMatch.Size = new System.Drawing.Size(498, 27);
            this.txtMatch.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Match:";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(225, 260);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(498, 27);
            this.dateTimeStart.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Date start:";
            // 
            // txtScoreTwo
            // 
            this.txtScoreTwo.Location = new System.Drawing.Point(225, 161);
            this.txtScoreTwo.Name = "txtScoreTwo";
            this.txtScoreTwo.Size = new System.Drawing.Size(498, 27);
            this.txtScoreTwo.TabIndex = 40;
            // 
            // SettingTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 599);
            this.Controls.Add(this.txtScoreTwo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.txtMatch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTMID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridTour);
            this.Controls.Add(this.txtFinished);
            this.Controls.Add(this.txtScoreOne);
            this.Controls.Add(this.txtTeamTwo);
            this.Controls.Add(this.txtTeamOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingTournament";
            this.Text = "Setting tournament";
            this.Load += new System.EventHandler(this.SettingTournament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClear;
        private TextBox txtTMID;
        private Label label6;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridTour;
        private TextBox txtFinished;
        private TextBox txtScoreOne;
        private TextBox txtTeamTwo;
        private TextBox txtTeamOne;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMatch;
        private Label label7;
        private DateTimePicker dateTimeStart;
        private Label label8;
        private TextBox txtScoreTwo;
    }
}