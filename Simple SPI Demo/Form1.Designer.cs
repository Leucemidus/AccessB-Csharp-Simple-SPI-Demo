namespace Simple_SPI_Demo
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
            this.btnFindDev = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbSample = new System.Windows.Forms.TextBox();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnSPIOn = new System.Windows.Forms.Button();
            this.btnSPIOff = new System.Windows.Forms.Button();
            this.btnSample = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindDev
            // 
            this.btnFindDev.Location = new System.Drawing.Point(35, 26);
            this.btnFindDev.Name = "btnFindDev";
            this.btnFindDev.Size = new System.Drawing.Size(116, 31);
            this.btnFindDev.TabIndex = 0;
            this.btnFindDev.Text = "Find Device";
            this.btnFindDev.UseVisualStyleBackColor = true;
            this.btnFindDev.Click += new System.EventHandler(this.btnFindDev_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(42, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(109, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Disconnected";
            // 
            // txbSample
            // 
            this.txbSample.Location = new System.Drawing.Point(157, 146);
            this.txbSample.Name = "txbSample";
            this.txbSample.Size = new System.Drawing.Size(100, 20);
            this.txbSample.TabIndex = 2;
            // 
            // btnConfigure
            // 
            this.btnConfigure.Enabled = false;
            this.btnConfigure.Location = new System.Drawing.Point(170, 26);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(116, 31);
            this.btnConfigure.TabIndex = 0;
            this.btnConfigure.Text = "Configure SPI";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnSPIOn
            // 
            this.btnSPIOn.Enabled = false;
            this.btnSPIOn.Location = new System.Drawing.Point(35, 63);
            this.btnSPIOn.Name = "btnSPIOn";
            this.btnSPIOn.Size = new System.Drawing.Size(116, 31);
            this.btnSPIOn.TabIndex = 0;
            this.btnSPIOn.Text = "SPI On";
            this.btnSPIOn.UseVisualStyleBackColor = true;
            this.btnSPIOn.Click += new System.EventHandler(this.btnSPIOn_Click);
            // 
            // btnSPIOff
            // 
            this.btnSPIOff.Enabled = false;
            this.btnSPIOff.Location = new System.Drawing.Point(170, 63);
            this.btnSPIOff.Name = "btnSPIOff";
            this.btnSPIOff.Size = new System.Drawing.Size(116, 31);
            this.btnSPIOff.TabIndex = 0;
            this.btnSPIOff.Text = "SPI Off";
            this.btnSPIOff.UseVisualStyleBackColor = true;
            this.btnSPIOff.Click += new System.EventHandler(this.btnSPIOff_Click);
            // 
            // btnSample
            // 
            this.btnSample.Enabled = false;
            this.btnSample.Location = new System.Drawing.Point(98, 109);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(131, 31);
            this.btnSample.TabIndex = 0;
            this.btnSample.Text = "Sample from ADC SPI";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SPI ADC value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSample);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.btnSPIOff);
            this.Controls.Add(this.btnSPIOn);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnFindDev);
            this.Name = "Form1";
            this.Text = "Simple SPI Demo (ADC SPI MCP3201)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDev;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbSample;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.Button btnSPIOn;
        private System.Windows.Forms.Button btnSPIOff;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Label label1;
    }
}

