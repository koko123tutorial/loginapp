namespace Login_Ulang
{
    partial class register
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
            label1 = new Label();
            name = new TextBox();
            password = new TextBox();
            passwordCom = new TextBox();
            send = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            info = new Label();
            directLogin = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(115, 50);
            label1.Name = "label1";
            label1.Size = new Size(167, 54);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 11F);
            name.Location = new Point(47, 133);
            name.Name = "name";
            name.Size = new Size(296, 37);
            name.TabIndex = 1;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 11F);
            password.Location = new Point(47, 198);
            password.Name = "password";
            password.Size = new Size(296, 37);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // passwordCom
            // 
            passwordCom.Font = new Font("Segoe UI", 11F);
            passwordCom.Location = new Point(47, 262);
            passwordCom.Name = "passwordCom";
            passwordCom.Size = new Size(296, 37);
            passwordCom.TabIndex = 3;
            passwordCom.UseSystemPasswordChar = true;
            // 
            // send
            // 
            send.Location = new Point(140, 351);
            send.Name = "send";
            send.Size = new Size(112, 34);
            send.TabIndex = 4;
            send.Text = "Send";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 105);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 170);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 235);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password:";
            label4.Click += label4_Click;
            // 
            // info
            // 
            info.ForeColor = Color.Red;
            info.Location = new Point(0, 323);
            info.Name = "info";
            info.Size = new Size(395, 25);
            info.TabIndex = 8;
            info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // directLogin
            // 
            directLogin.AutoSize = true;
            directLogin.Location = new Point(108, 384);
            directLogin.Name = "directLogin";
            directLogin.Size = new Size(184, 25);
            directLogin.TabIndex = 9;
            directLogin.TabStop = true;
            directLogin.Text = "Already have Account";
            directLogin.LinkClicked += directLogin_LinkClicked;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(395, 438);
            Controls.Add(directLogin);
            Controls.Add(info);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(send);
            Controls.Add(passwordCom);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox password;
        private TextBox passwordCom;
        private Button send;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label info;
        private LinkLabel directLogin;
    }
}