namespace Box360_M2
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnAsset = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(870, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.Black;
            this.btnAppointment.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAppointment.Location = new System.Drawing.Point(467, 48);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(303, 95);
            this.btnAppointment.TabIndex = 1;
            this.btnAppointment.Text = "Appointment System";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.Black;
            this.btnSale.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSale.Location = new System.Drawing.Point(467, 160);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(302, 96);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Sales Inventory";
            this.btnSale.UseVisualStyleBackColor = false;
            // 
            // btnAsset
            // 
            this.btnAsset.BackColor = System.Drawing.Color.Black;
            this.btnAsset.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsset.Location = new System.Drawing.Point(466, 273);
            this.btnAsset.Name = "btnAsset";
            this.btnAsset.Size = new System.Drawing.Size(303, 97);
            this.btnAsset.TabIndex = 3;
            this.btnAsset.Text = "Asset Inventory";
            this.btnAsset.UseVisualStyleBackColor = false;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.Black;
            this.btnLogOff.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(12, 410);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(115, 40);
            this.btnLogOff.TabIndex = 4;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 473);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnAsset);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMenu";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnAsset;
        private System.Windows.Forms.Button btnLogOff;
    }
}