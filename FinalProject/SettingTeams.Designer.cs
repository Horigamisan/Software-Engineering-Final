namespace FinalProject
{
    partial class SettingTeams
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAbbr = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            this.txtState = new System.Windows.Forms.TextBox();
            this.dataGridTeam = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTPID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team\'s name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abbreviation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date create:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "State:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(498, 27);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAbbr
            // 
            this.txtAbbr.Location = new System.Drawing.Point(183, 92);
            this.txtAbbr.Name = "txtAbbr";
            this.txtAbbr.Size = new System.Drawing.Size(498, 27);
            this.txtAbbr.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(183, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(498, 27);
            this.txtPhone.TabIndex = 7;
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.Location = new System.Drawing.Point(183, 158);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(498, 27);
            this.dateTimeCreate.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(183, 191);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(498, 27);
            this.txtState.TabIndex = 9;
            // 
            // dataGridTeam
            // 
            this.dataGridTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeam.Location = new System.Drawing.Point(65, 243);
            this.dataGridTeam.MultiSelect = false;
            this.dataGridTeam.Name = "dataGridTeam";
            this.dataGridTeam.RowHeadersWidth = 51;
            this.dataGridTeam.RowTemplate.Height = 29;
            this.dataGridTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTeam.Size = new System.Drawing.Size(616, 228);
            this.dataGridTeam.TabIndex = 10;
            this.dataGridTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridTeam.SelectionChanged += new System.EventHandler(this.dataGridTeam_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 488);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 488);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 29);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(437, 488);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 29);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "TPID";
            // 
            // txtTPID
            // 
            this.txtTPID.Enabled = false;
            this.txtTPID.Location = new System.Drawing.Point(183, 29);
            this.txtTPID.Name = "txtTPID";
            this.txtTPID.Size = new System.Drawing.Size(498, 27);
            this.txtTPID.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(562, 488);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 29);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SettingTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 541);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTPID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridTeam);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.dateTimeCreate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAbbr);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingTeams";
            this.Text = "Setting teams";
            this.Load += new System.EventHandler(this.SettingTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAbbr;
        private TextBox txtPhone;
        private DateTimePicker dateTimeCreate;
        private TextBox txtState;
        private DataGridView dataGridTeam;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnPrint;
        private Label label6;
        private TextBox txtTPID;
        private Button btnClear;
    }
}