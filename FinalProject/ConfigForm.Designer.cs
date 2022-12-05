namespace FinalProject
{
    partial class ConfigForm
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
            this.bSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(25, 179);
            this.bSave.Margin = new System.Windows.Forms.Padding(2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(436, 33);
            this.bSave.TabIndex = 14;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 146);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Windows authenication";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(101, 105);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(361, 27);
            this.txtpwd.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pwd";
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(101, 75);
            this.txtuid.Margin = new System.Windows.Forms.Padding(2);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(361, 27);
            this.txtuid.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uid";
            // 
            // txtdb
            // 
            this.txtdb.Location = new System.Drawing.Point(101, 45);
            this.txtdb.Margin = new System.Windows.Forms.Padding(2);
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(361, 27);
            this.txtdb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Database";
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(101, 16);
            this.txtserver.Margin = new System.Windows.Forms.Padding(2);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(361, 27);
            this.txtserver.TabIndex = 9;
            this.txtserver.TextChanged += new System.EventHandler(this.txtserver_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 234);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Config database";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bSave;
        private CheckBox checkBox1;
        private TextBox txtpwd;
        private Label label4;
        private TextBox txtuid;
        private Label label3;
        private TextBox txtdb;
        private Label label2;
        private TextBox txtserver;
        private Label label1;
    }
}