namespace Box360_M2
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblC_Username = new System.Windows.Forms.Label();
            this.txtC_Password = new System.Windows.Forms.TextBox();
            this.lblC_Password = new System.Windows.Forms.Label();
            this.btnC_Login = new System.Windows.Forms.Button();
            this.txtC_Username = new System.Windows.Forms.TextBox();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.btnM_Login = new System.Windows.Forms.Button();
            this.txtM_Password = new System.Windows.Forms.TextBox();
            this.lblM_Password = new System.Windows.Forms.Label();
            this.txtM_Username = new System.Windows.Forms.TextBox();
            this.lblM_Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1249, 593);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(993, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1049, 519);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(187, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClient);
            this.tabControl1.Controls.Add(this.tabManager);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(397, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 527);
            this.tabControl1.TabIndex = 7;
            // 
            // tabClient
            // 
            this.tabClient.BackColor = System.Drawing.Color.White;
            this.tabClient.Controls.Add(this.groupBox2);
            this.tabClient.Controls.Add(this.groupBox1);
            this.tabClient.ForeColor = System.Drawing.Color.Black;
            this.tabClient.Location = new System.Drawing.Point(4, 37);
            this.tabClient.Margin = new System.Windows.Forms.Padding(4);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(4);
            this.tabClient.Size = new System.Drawing.Size(539, 486);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Client";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(24, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 179);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not A Client ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Button Below To Become A Client";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(149, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.lblC_Username);
            this.groupBox1.Controls.Add(this.txtC_Password);
            this.groupBox1.Controls.Add(this.lblC_Password);
            this.groupBox1.Controls.Add(this.btnC_Login);
            this.groupBox1.Controls.Add(this.txtC_Username);
            this.groupBox1.Location = new System.Drawing.Point(24, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 229);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Login";
            // 
            // lblC_Username
            // 
            this.lblC_Username.AutoSize = true;
            this.lblC_Username.Location = new System.Drawing.Point(12, 40);
            this.lblC_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC_Username.Name = "lblC_Username";
            this.lblC_Username.Size = new System.Drawing.Size(106, 28);
            this.lblC_Username.TabIndex = 0;
            this.lblC_Username.Text = "Username";
            // 
            // txtC_Password
            // 
            this.txtC_Password.BackColor = System.Drawing.Color.White;
            this.txtC_Password.Location = new System.Drawing.Point(129, 104);
            this.txtC_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txtC_Password.Name = "txtC_Password";
            this.txtC_Password.Size = new System.Drawing.Size(316, 34);
            this.txtC_Password.TabIndex = 3;
            this.txtC_Password.TextChanged += new System.EventHandler(this.txtC_Password_TextChanged);
            // 
            // lblC_Password
            // 
            this.lblC_Password.AutoSize = true;
            this.lblC_Password.Location = new System.Drawing.Point(12, 110);
            this.lblC_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC_Password.Name = "lblC_Password";
            this.lblC_Password.Size = new System.Drawing.Size(101, 28);
            this.lblC_Password.TabIndex = 1;
            this.lblC_Password.Text = "Password";
            // 
            // btnC_Login
            // 
            this.btnC_Login.BackColor = System.Drawing.Color.White;
            this.btnC_Login.Location = new System.Drawing.Point(245, 169);
            this.btnC_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btnC_Login.Name = "btnC_Login";
            this.btnC_Login.Size = new System.Drawing.Size(200, 43);
            this.btnC_Login.TabIndex = 4;
            this.btnC_Login.Text = "Login";
            this.btnC_Login.UseVisualStyleBackColor = false;
            this.btnC_Login.Click += new System.EventHandler(this.btnC_Login_Click);
            // 
            // txtC_Username
            // 
            this.txtC_Username.BackColor = System.Drawing.Color.White;
            this.txtC_Username.Location = new System.Drawing.Point(129, 34);
            this.txtC_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txtC_Username.Name = "txtC_Username";
            this.txtC_Username.Size = new System.Drawing.Size(316, 34);
            this.txtC_Username.TabIndex = 2;
            // 
            // tabManager
            // 
            this.tabManager.BackColor = System.Drawing.Color.White;
            this.tabManager.Controls.Add(this.btnM_Login);
            this.tabManager.Controls.Add(this.txtM_Password);
            this.tabManager.Controls.Add(this.lblM_Password);
            this.tabManager.Controls.Add(this.txtM_Username);
            this.tabManager.Controls.Add(this.lblM_Username);
            this.tabManager.Location = new System.Drawing.Point(4, 37);
            this.tabManager.Margin = new System.Windows.Forms.Padding(4);
            this.tabManager.Name = "tabManager";
            this.tabManager.Padding = new System.Windows.Forms.Padding(4);
            this.tabManager.Size = new System.Drawing.Size(539, 486);
            this.tabManager.TabIndex = 1;
            this.tabManager.Text = "Manager";
            // 
            // btnM_Login
            // 
            this.btnM_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnM_Login.Location = new System.Drawing.Point(313, 188);
            this.btnM_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btnM_Login.Name = "btnM_Login";
            this.btnM_Login.Size = new System.Drawing.Size(200, 43);
            this.btnM_Login.TabIndex = 6;
            this.btnM_Login.Text = "Login";
            this.btnM_Login.UseVisualStyleBackColor = false;
            this.btnM_Login.Click += new System.EventHandler(this.btnM_Login_Click);
            // 
            // txtM_Password
            // 
            this.txtM_Password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtM_Password.Location = new System.Drawing.Point(197, 113);
            this.txtM_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txtM_Password.Name = "txtM_Password";
            this.txtM_Password.Size = new System.Drawing.Size(316, 34);
            this.txtM_Password.TabIndex = 5;
            // 
            // lblM_Password
            // 
            this.lblM_Password.AutoSize = true;
            this.lblM_Password.Location = new System.Drawing.Point(31, 113);
            this.lblM_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM_Password.Name = "lblM_Password";
            this.lblM_Password.Size = new System.Drawing.Size(101, 28);
            this.lblM_Password.TabIndex = 4;
            this.lblM_Password.Text = "Password";
            // 
            // txtM_Username
            // 
            this.txtM_Username.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtM_Username.Location = new System.Drawing.Point(197, 28);
            this.txtM_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txtM_Username.Name = "txtM_Username";
            this.txtM_Username.Size = new System.Drawing.Size(316, 34);
            this.txtM_Username.TabIndex = 3;
            // 
            // lblM_Username
            // 
            this.lblM_Username.AutoSize = true;
            this.lblM_Username.Location = new System.Drawing.Point(24, 27);
            this.lblM_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM_Username.Name = "lblM_Username";
            this.lblM_Username.Size = new System.Drawing.Size(106, 28);
            this.lblM_Username.TabIndex = 1;
            this.lblM_Username.Text = "Username";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1249, 593);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabManager.ResumeLayout(false);
            this.tabManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.Button btnC_Login;
        private System.Windows.Forms.Label lblC_Username;
        private System.Windows.Forms.Label lblC_Password;
        private System.Windows.Forms.TextBox txtC_Password;
        private System.Windows.Forms.TextBox txtC_Username;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.Button btnM_Login;
        private System.Windows.Forms.TextBox txtM_Password;
        private System.Windows.Forms.Label lblM_Password;
        private System.Windows.Forms.TextBox txtM_Username;
        private System.Windows.Forms.Label lblM_Username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

