namespace FinalProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bRegister = new System.Windows.Forms.Button();
            this.bsignin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(318, 99);
            this.bRegister.Margin = new System.Windows.Forms.Padding(2);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(214, 34);
            this.bRegister.TabIndex = 11;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bsignin
            // 
            this.bsignin.Location = new System.Drawing.Point(35, 99);
            this.bsignin.Margin = new System.Windows.Forms.Padding(2);
            this.bsignin.Name = "bsignin";
            this.bsignin.Size = new System.Drawing.Size(214, 34);
            this.bsignin.TabIndex = 10;
            this.bsignin.Text = "Sign in";
            this.bsignin.UseVisualStyleBackColor = true;
            this.bsignin.Click += new System.EventHandler(this.bsignin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(139, 57);
            this.txtpass.Margin = new System.Windows.Forms.Padding(2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(394, 27);
            this.txtpass.TabIndex = 8;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "User name:";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(139, 28);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(394, 27);
            this.txtuser.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 159);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bsignin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bRegister;
        private Button bsignin;
        private Label label2;
        private TextBox txtpass;
        private Label label1;
        private TextBox txtuser;
    }
}