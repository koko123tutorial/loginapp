namespace Login_Ulang
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            greeting = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            logout = new Button();
            savebtn = new Button();
            txtId = new TextBox();
            txtPass = new TextBox();
            txtRole = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // greeting
            // 
            greeting.Dock = DockStyle.Top;
            greeting.Font = new Font("Segoe UI", 20F);
            greeting.ForeColor = SystemColors.ActiveCaptionText;
            greeting.Location = new Point(0, 0);
            greeting.Name = "greeting";
            greeting.Size = new Size(981, 54);
            greeting.TabIndex = 0;
            greeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(665, 396);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.BackColor = Color.Red;
            logout.ForeColor = SystemColors.ButtonFace;
            logout.Location = new Point(857, 12);
            logout.Name = "logout";
            logout.Size = new Size(112, 34);
            logout.TabIndex = 2;
            logout.Text = "Log out";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            savebtn.ForeColor = SystemColors.ActiveCaptionText;
            savebtn.Location = new Point(857, 361);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(112, 77);
            savebtn.TabIndex = 3;
            savebtn.Text = "Change";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Visible = false;
            savebtn.Click += savebtn_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Right;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(709, 109);
            txtId.Name = "txtId";
            txtId.Size = new Size(221, 34);
            txtId.TabIndex = 6;
            txtId.Visible = false;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Right;
            txtPass.Font = new Font("Segoe UI", 10F);
            txtPass.Location = new Point(709, 194);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(221, 34);
            txtPass.TabIndex = 7;
            txtPass.Visible = false;
            // 
            // txtRole
            // 
            txtRole.Anchor = AnchorStyles.Right;
            txtRole.Font = new Font("Segoe UI", 10F);
            txtRole.Location = new Point(709, 263);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(221, 34);
            txtRole.TabIndex = 8;
            txtRole.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(709, 81);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 9;
            label1.Text = "Id:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(709, 166);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(709, 235);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 11;
            label3.Text = "Role:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(780, 145);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 12;
            label4.Text = "Changes:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonShadow;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(785, 61);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 13;
            label5.Text = "Search:";
            label5.Visible = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(981, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtPass);
            Controls.Add(txtId);
            Controls.Add(savebtn);
            Controls.Add(logout);
            Controls.Add(dataGridView1);
            Controls.Add(greeting);
            ForeColor = SystemColors.Control;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greeting;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private Button logout;
        private Button savebtn;
        private TextBox txtId;
        private TextBox txtPass;
        private TextBox txtRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}