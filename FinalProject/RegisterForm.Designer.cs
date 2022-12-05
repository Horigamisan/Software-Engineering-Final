namespace FinalProject
{
    partial class RegisterForm
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
            this.bRegister = new System.Windows.Forms.Button();
            this.bBackSignin = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbPassConfirm = new System.Windows.Forms.Label();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(370, 196);
            this.bRegister.Margin = new System.Windows.Forms.Padding(2);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(214, 34);
            this.bRegister.TabIndex = 22;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bBackSignin
            // 
            this.bBackSignin.Location = new System.Drawing.Point(40, 196);
            this.bBackSignin.Margin = new System.Windows.Forms.Padding(2);
            this.bBackSignin.Name = "bBackSignin";
            this.bBackSignin.Size = new System.Drawing.Size(214, 34);
            this.bBackSignin.TabIndex = 21;
            this.bBackSignin.Text = "Back to signin";
            this.bBackSignin.UseVisualStyleBackColor = true;
            this.bBackSignin.Click += new System.EventHandler(this.bBackSignin_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(40, 62);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(108, 20);
            this.lbPhone.TabIndex = 15;
            this.lbPhone.Text = "Phone number:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(190, 64);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(394, 27);
            this.txtPhone.TabIndex = 14;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(40, 33);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(82, 20);
            this.lbUser.TabIndex = 13;
            this.lbUser.Text = "User name:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(190, 33);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(394, 27);
            this.txtUser.TabIndex = 12;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(40, 93);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(65, 20);
            this.lbAddress.TabIndex = 19;
            this.lbAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(190, 93);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(394, 27);
            this.txtAddress.TabIndex = 16;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(40, 124);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(73, 20);
            this.lbPass.TabIndex = 21;
            this.lbPass.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(190, 124);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(394, 27);
            this.txtPass.TabIndex = 18;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lbPassConfirm
            // 
            this.lbPassConfirm.AutoSize = true;
            this.lbPassConfirm.Location = new System.Drawing.Point(40, 155);
            this.lbPassConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassConfirm.Name = "lbPassConfirm";
            this.lbPassConfirm.Size = new System.Drawing.Size(132, 20);
            this.lbPassConfirm.TabIndex = 23;
            this.lbPassConfirm.Text = "Confirm password:";
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(190, 155);
            this.txtPassConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Size = new System.Drawing.Size(394, 27);
            this.txtPassConfirm.TabIndex = 20;
            this.txtPassConfirm.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 269);
            this.Controls.Add(this.lbPassConfirm);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bBackSignin);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bRegister;
        private Button bBackSignin;
        private Label lbPhone;
        private TextBox txtPhone;
        private Label lbUser;
        private TextBox txtUser;
        private Label lbAddress;
        private TextBox txtAddress;
        private Label lbPass;
        private TextBox txtPass;
        private Label lbPassConfirm;
        private TextBox txtPassConfirm;
    }
}