
namespace QuanLyNhaHang
{
    partial class Login
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
            this.m_txt_ID = new System.Windows.Forms.TextBox();
            this.m_txt_MK = new System.Windows.Forms.TextBox();
            this.m_btn_Login = new System.Windows.Forms.Button();
            this.m_btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // m_txt_ID
            // 
            this.m_txt_ID.Location = new System.Drawing.Point(104, 60);
            this.m_txt_ID.Name = "m_txt_ID";
            this.m_txt_ID.Size = new System.Drawing.Size(146, 20);
            this.m_txt_ID.TabIndex = 1;
            // 
            // m_txt_MK
            // 
            this.m_txt_MK.Location = new System.Drawing.Point(104, 100);
            this.m_txt_MK.Name = "m_txt_MK";
            this.m_txt_MK.Size = new System.Drawing.Size(146, 20);
            this.m_txt_MK.TabIndex = 1;
            // 
            // m_btn_Login
            // 
            this.m_btn_Login.Location = new System.Drawing.Point(83, 163);
            this.m_btn_Login.Name = "m_btn_Login";
            this.m_btn_Login.Size = new System.Drawing.Size(75, 23);
            this.m_btn_Login.TabIndex = 2;
            this.m_btn_Login.Text = "Login";
            this.m_btn_Login.UseVisualStyleBackColor = true;
            this.m_btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // m_btn_Exit
            // 
            this.m_btn_Exit.Location = new System.Drawing.Point(201, 163);
            this.m_btn_Exit.Name = "m_btn_Exit";
            this.m_btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.m_btn_Exit.TabIndex = 2;
            this.m_btn_Exit.Text = "Exit";
            this.m_btn_Exit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_txt_ID);
            this.groupBox1.Controls.Add(this.m_btn_Exit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_btn_Login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_txt_MK);
            this.groupBox1.Location = new System.Drawing.Point(248, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_ID;
        private System.Windows.Forms.TextBox m_txt_MK;
        private System.Windows.Forms.Button m_btn_Login;
        private System.Windows.Forms.Button m_btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}