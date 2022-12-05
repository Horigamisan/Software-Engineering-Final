namespace FinalProject
{
    partial class RegisterTeam
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAbbre = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.bRegister = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abbreviation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start date:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtAbbre
            // 
            this.txtAbbre.Location = new System.Drawing.Point(152, 60);
            this.txtAbbre.Name = "txtAbbre";
            this.txtAbbre.Size = new System.Drawing.Size(310, 27);
            this.txtAbbre.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(152, 93);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(310, 27);
            this.txtPhone.TabIndex = 6;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(152, 126);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(310, 27);
            this.dateStart.TabIndex = 7;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(38, 186);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(156, 29);
            this.bRegister.TabIndex = 8;
            this.bRegister.Text = "Register team";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(299, 186);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(163, 29);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // RegisterTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 250);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAbbre);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterTeam";
            this.Text = "Register team";
            this.Load += new System.EventHandler(this.RegisterTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAbbre;
        private TextBox txtPhone;
        private DateTimePicker dateStart;
        private Button bRegister;
        private Button bCancel;
    }
}