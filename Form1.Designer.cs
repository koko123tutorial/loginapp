namespace Login_Ulang
{
    partial class Form1
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
            label1 = new Label();
            name = new TextBox();
            password = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            info = new Label();
            directRegister = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(155, 47);
            label1.Name = "label1";
            label1.Size = new Size(122, 54);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 11F);
            name.Location = new Point(70, 143);
            name.Name = "name";
            name.Size = new Size(286, 37);
            name.TabIndex = 1;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 11F);
            password.Location = new Point(70, 206);
            password.Name = "password";
            password.Size = new Size(286, 37);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(160, 306);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(70, 249);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 115);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 181);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // info
            // 
            info.ForeColor = Color.Red;
            info.Location = new Point(2, 278);
            info.Name = "info";
            info.Size = new Size(425, 25);
            info.TabIndex = 7;
            info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // directRegister
            // 
            directRegister.AutoSize = true;
            directRegister.Location = new Point(135, 336);
            directRegister.Name = "directRegister";
            directRegister.Size = new Size(169, 25);
            directRegister.TabIndex = 8;
            directRegister.TabStop = true;
            directRegister.Text = "Create new Account";
            directRegister.LinkClicked += directRegister_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(425, 450);
            Controls.Add(directRegister);
            Controls.Add(info);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox password;
        private Button button1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
        private Label info;
        private LinkLabel directRegister;
    }
}
