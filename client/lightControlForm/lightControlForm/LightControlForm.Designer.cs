namespace lightControlForm
{
    partial class LightControlForm
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
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.christmasLightBtn = new System.Windows.Forms.Button();
            this.rainbowBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.colorWipeBtn = new System.Windows.Forms.Button();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(47, 63);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(107, 40);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectBtn.Location = new System.Drawing.Point(179, 63);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(107, 40);
            this.disconnectBtn.TabIndex = 1;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // christmasLightBtn
            // 
            this.christmasLightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.christmasLightBtn.Location = new System.Drawing.Point(62, 132);
            this.christmasLightBtn.Name = "christmasLightBtn";
            this.christmasLightBtn.Size = new System.Drawing.Size(151, 34);
            this.christmasLightBtn.TabIndex = 2;
            this.christmasLightBtn.Text = "Christmas Light";
            this.christmasLightBtn.UseVisualStyleBackColor = true;
            this.christmasLightBtn.Click += new System.EventHandler(this.christmasLightBtn_Click);
            // 
            // rainbowBtn
            // 
            this.rainbowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainbowBtn.Location = new System.Drawing.Point(62, 181);
            this.rainbowBtn.Name = "rainbowBtn";
            this.rainbowBtn.Size = new System.Drawing.Size(151, 34);
            this.rainbowBtn.TabIndex = 3;
            this.rainbowBtn.Text = "Rainbow";
            this.rainbowBtn.UseVisualStyleBackColor = true;
            this.rainbowBtn.Click += new System.EventHandler(this.rainbowBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(219, 132);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(39, 157);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "S\r\nT\r\nO\r\nP";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // colorWipeBtn
            // 
            this.colorWipeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorWipeBtn.Location = new System.Drawing.Point(62, 230);
            this.colorWipeBtn.Name = "colorWipeBtn";
            this.colorWipeBtn.Size = new System.Drawing.Size(151, 34);
            this.colorWipeBtn.TabIndex = 5;
            this.colorWipeBtn.Text = "Color Wipe";
            this.colorWipeBtn.UseVisualStyleBackColor = true;
            this.colorWipeBtn.Click += new System.EventHandler(this.colorWipeBtn_Click);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(76, 7);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipAddressTextBox.TabIndex = 6;
            this.ipAddressTextBox.Text = "10.10.14.53";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(76, 33);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 7;
            this.portTextBox.Text = "7804";
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(12, 11);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(58, 13);
            this.ipAddressLabel.TabIndex = 8;
            this.ipAddressLabel.Text = "IP Address";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(24, 37);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 9;
            this.portLabel.Text = "Port";
            // 
            // LightControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lightControlForm.Properties.Resources.AdobeStock_96977357;
            this.ClientSize = new System.Drawing.Size(345, 404);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.colorWipeBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.rainbowBtn);
            this.Controls.Add(this.christmasLightBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Name = "LightControlForm";
            this.Text = "LightControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button christmasLightBtn;
        private System.Windows.Forms.Button rainbowBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button colorWipeBtn;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label portLabel;
    }
}

