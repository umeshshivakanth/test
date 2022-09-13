
namespace SendEmail
{
    partial class Form1
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
            this.txt_from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_body = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_smtpserver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.PortNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(118, 25);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(217, 20);
            this.txt_from.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(118, 64);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(217, 20);
            this.txt_to.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(118, 106);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(217, 20);
            this.txt_subject.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject";
            // 
            // txt_body
            // 
            this.txt_body.Location = new System.Drawing.Point(118, 151);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(347, 287);
            this.txt_body.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Body";
            // 
            // txt_smtpserver
            // 
            this.txt_smtpserver.Location = new System.Drawing.Point(491, 25);
            this.txt_smtpserver.Name = "txt_smtpserver";
            this.txt_smtpserver.Size = new System.Drawing.Size(217, 20);
            this.txt_smtpserver.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SMTP Server";
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(491, 64);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(217, 20);
            this.txt_uname.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "UserName";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(491, 106);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(217, 20);
            this.txt_pwd.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password";
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.Location = new System.Drawing.Point(593, 203);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(75, 23);
            this.btn_SendEmail.TabIndex = 2;
            this.btn_SendEmail.Text = "Send Email";
            this.btn_SendEmail.UseVisualStyleBackColor = true;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(533, 151);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(217, 20);
            this.txt_port.TabIndex = 0;
            // 
            // PortNo
            // 
            this.PortNo.AutoSize = true;
            this.PortNo.Location = new System.Drawing.Point(471, 158);
            this.PortNo.Name = "PortNo";
            this.PortNo.Size = new System.Drawing.Size(40, 13);
            this.PortNo.TabIndex = 1;
            this.PortNo.Text = "PortNo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SendEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_body);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.txt_smtpserver);
            this.Controls.Add(this.txt_from);
            this.Name = "Form1";
            this.Text = "Send Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_body;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_smtpserver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label PortNo;
    }
}

