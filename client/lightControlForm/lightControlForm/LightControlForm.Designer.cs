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
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.colorWipeBtn = new System.Windows.Forms.Button();
            this.rainbowCycleBtn = new System.Windows.Forms.Button();
            this.meteorRainBtn = new System.Windows.Forms.Button();
            this.fillRandomBtn = new System.Windows.Forms.Button();
            this.randomColorsBtn = new System.Windows.Forms.Button();
            this.theaterChaseBtn = new System.Windows.Forms.Button();
            this.theaterChaseRainbowBtn = new System.Windows.Forms.Button();
            this.alternateSingleBtn = new System.Windows.Forms.Button();
            this.StackBtn = new System.Windows.Forms.Button();
            this.zipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(87, 66);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(107, 40);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.disconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectBtn.Location = new System.Drawing.Point(219, 66);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(107, 40);
            this.disconnectBtn.TabIndex = 1;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = false;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // christmasLightBtn
            // 
            this.christmasLightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.christmasLightBtn.Location = new System.Drawing.Point(34, 129);
            this.christmasLightBtn.Name = "christmasLightBtn";
            this.christmasLightBtn.Size = new System.Drawing.Size(169, 24);
            this.christmasLightBtn.TabIndex = 2;
            this.christmasLightBtn.Text = "Christmas Light";
            this.christmasLightBtn.UseVisualStyleBackColor = true;
            this.christmasLightBtn.Click += new System.EventHandler(this.christmasLightBtn_Click);
            // 
            // rainbowBtn
            // 
            this.rainbowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainbowBtn.Location = new System.Drawing.Point(34, 159);
            this.rainbowBtn.Name = "rainbowBtn";
            this.rainbowBtn.Size = new System.Drawing.Size(169, 24);
            this.rainbowBtn.TabIndex = 3;
            this.rainbowBtn.Text = "Rainbow";
            this.rainbowBtn.UseVisualStyleBackColor = true;
            this.rainbowBtn.Click += new System.EventHandler(this.rainbowBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.SystemColors.Control;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(34, 316);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(347, 37);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(76, 7);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipAddressTextBox.TabIndex = 6;
            this.ipAddressTextBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(76, 33);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 7;
            this.portTextBox.TextChanged += new System.EventHandler(this.textChanged);
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
            // colorWipeBtn
            // 
            this.colorWipeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorWipeBtn.Location = new System.Drawing.Point(34, 189);
            this.colorWipeBtn.Name = "colorWipeBtn";
            this.colorWipeBtn.Size = new System.Drawing.Size(169, 24);
            this.colorWipeBtn.TabIndex = 5;
            this.colorWipeBtn.Text = "Color Wipe";
            this.colorWipeBtn.UseVisualStyleBackColor = true;
            this.colorWipeBtn.Click += new System.EventHandler(this.colorWipeBtn_Click);
            // 
            // rainbowCycleBtn
            // 
            this.rainbowCycleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainbowCycleBtn.Location = new System.Drawing.Point(34, 219);
            this.rainbowCycleBtn.Name = "rainbowCycleBtn";
            this.rainbowCycleBtn.Size = new System.Drawing.Size(169, 24);
            this.rainbowCycleBtn.TabIndex = 10;
            this.rainbowCycleBtn.Text = "Rainbow Cycle";
            this.rainbowCycleBtn.UseVisualStyleBackColor = true;
            this.rainbowCycleBtn.Click += new System.EventHandler(this.rainbowCycle_Click);
            // 
            // meteorRainBtn
            // 
            this.meteorRainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meteorRainBtn.Location = new System.Drawing.Point(34, 249);
            this.meteorRainBtn.Name = "meteorRainBtn";
            this.meteorRainBtn.Size = new System.Drawing.Size(169, 24);
            this.meteorRainBtn.TabIndex = 11;
            this.meteorRainBtn.Text = "Meteor Rain";
            this.meteorRainBtn.UseVisualStyleBackColor = true;
            this.meteorRainBtn.Click += new System.EventHandler(this.meteorRainBtn_Click);
            // 
            // fillRandomBtn
            // 
            this.fillRandomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillRandomBtn.Location = new System.Drawing.Point(34, 279);
            this.fillRandomBtn.Name = "fillRandomBtn";
            this.fillRandomBtn.Size = new System.Drawing.Size(169, 24);
            this.fillRandomBtn.TabIndex = 12;
            this.fillRandomBtn.Text = "Fill Random";
            this.fillRandomBtn.UseVisualStyleBackColor = true;
            this.fillRandomBtn.Click += new System.EventHandler(this.fillRandomBtn_Click);
            // 
            // randomColorsBtn
            // 
            this.randomColorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomColorsBtn.Location = new System.Drawing.Point(212, 279);
            this.randomColorsBtn.Name = "randomColorsBtn";
            this.randomColorsBtn.Size = new System.Drawing.Size(169, 24);
            this.randomColorsBtn.TabIndex = 13;
            this.randomColorsBtn.Text = "Random Colors";
            this.randomColorsBtn.UseVisualStyleBackColor = true;
            this.randomColorsBtn.Click += new System.EventHandler(this.randomColorsBtn_Click);
            // 
            // theaterChaseBtn
            // 
            this.theaterChaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theaterChaseBtn.Location = new System.Drawing.Point(212, 129);
            this.theaterChaseBtn.Name = "theaterChaseBtn";
            this.theaterChaseBtn.Size = new System.Drawing.Size(169, 24);
            this.theaterChaseBtn.TabIndex = 14;
            this.theaterChaseBtn.Text = "Theater Chase";
            this.theaterChaseBtn.UseVisualStyleBackColor = true;
            this.theaterChaseBtn.Click += new System.EventHandler(this.theaterChaseBtn_Click);
            // 
            // theaterChaseRainbowBtn
            // 
            this.theaterChaseRainbowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theaterChaseRainbowBtn.Location = new System.Drawing.Point(212, 159);
            this.theaterChaseRainbowBtn.Name = "theaterChaseRainbowBtn";
            this.theaterChaseRainbowBtn.Size = new System.Drawing.Size(169, 24);
            this.theaterChaseRainbowBtn.TabIndex = 15;
            this.theaterChaseRainbowBtn.Text = "Theater Chase Rainbow";
            this.theaterChaseRainbowBtn.UseVisualStyleBackColor = true;
            this.theaterChaseRainbowBtn.Click += new System.EventHandler(this.theaterChaseRainbow_Click);
            // 
            // alternateSingleBtn
            // 
            this.alternateSingleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alternateSingleBtn.Location = new System.Drawing.Point(212, 189);
            this.alternateSingleBtn.Name = "alternateSingleBtn";
            this.alternateSingleBtn.Size = new System.Drawing.Size(169, 24);
            this.alternateSingleBtn.TabIndex = 16;
            this.alternateSingleBtn.Text = "Alternate Single";
            this.alternateSingleBtn.UseVisualStyleBackColor = true;
            this.alternateSingleBtn.Click += new System.EventHandler(this.alternateSingleBtn_Click);
            // 
            // StackBtn
            // 
            this.StackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackBtn.Location = new System.Drawing.Point(212, 249);
            this.StackBtn.Name = "StackBtn";
            this.StackBtn.Size = new System.Drawing.Size(169, 24);
            this.StackBtn.TabIndex = 17;
            this.StackBtn.Text = "Stack";
            this.StackBtn.UseVisualStyleBackColor = true;
            this.StackBtn.Click += new System.EventHandler(this.StackBtn_Click);
            // 
            // zipBtn
            // 
            this.zipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipBtn.Location = new System.Drawing.Point(212, 219);
            this.zipBtn.Name = "zipBtn";
            this.zipBtn.Size = new System.Drawing.Size(169, 24);
            this.zipBtn.TabIndex = 18;
            this.zipBtn.Text = "Zip";
            this.zipBtn.UseVisualStyleBackColor = true;
            this.zipBtn.Click += new System.EventHandler(this.zipBtn_Click);
            // 
            // LightControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lightControlForm.Properties.Resources.AdobeStock_96977357;
            this.ClientSize = new System.Drawing.Size(412, 384);
            this.Controls.Add(this.zipBtn);
            this.Controls.Add(this.StackBtn);
            this.Controls.Add(this.alternateSingleBtn);
            this.Controls.Add(this.theaterChaseRainbowBtn);
            this.Controls.Add(this.theaterChaseBtn);
            this.Controls.Add(this.randomColorsBtn);
            this.Controls.Add(this.fillRandomBtn);
            this.Controls.Add(this.meteorRainBtn);
            this.Controls.Add(this.rainbowCycleBtn);
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
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button colorWipeBtn;
        private System.Windows.Forms.Button rainbowCycleBtn;
        private System.Windows.Forms.Button meteorRainBtn;
        private System.Windows.Forms.Button fillRandomBtn;
        private System.Windows.Forms.Button randomColorsBtn;
        private System.Windows.Forms.Button theaterChaseBtn;
        private System.Windows.Forms.Button theaterChaseRainbowBtn;
        private System.Windows.Forms.Button alternateSingleBtn;
        private System.Windows.Forms.Button StackBtn;
        private System.Windows.Forms.Button zipBtn;
    }
}

