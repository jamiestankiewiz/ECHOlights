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
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(47, 52);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(107, 52);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectBtn.Location = new System.Drawing.Point(183, 52);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(107, 52);
            this.disconnectBtn.TabIndex = 1;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // christmasLightBtn
            // 
            this.christmasLightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.christmasLightBtn.Location = new System.Drawing.Point(62, 138);
            this.christmasLightBtn.Name = "christmasLightBtn";
            this.christmasLightBtn.Size = new System.Drawing.Size(151, 34);
            this.christmasLightBtn.TabIndex = 2;
            this.christmasLightBtn.Text = "Christmas Light";
            this.christmasLightBtn.UseVisualStyleBackColor = true;
            this.christmasLightBtn.Click += new System.EventHandler(this.christmasLightBtn_Click);
            // 
            // rainbowBtn
            // 
            this.rainbowBtn.Location = new System.Drawing.Point(62, 178);
            this.rainbowBtn.Name = "rainbowBtn";
            this.rainbowBtn.Size = new System.Drawing.Size(151, 34);
            this.rainbowBtn.TabIndex = 3;
            this.rainbowBtn.Text = "Rainbow";
            this.rainbowBtn.UseVisualStyleBackColor = true;
            this.rainbowBtn.Click += new System.EventHandler(this.rainbowBtn_Click);
            // 
            // LightControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lightControlForm.Properties.Resources.AdobeStock_96977357;
            this.ClientSize = new System.Drawing.Size(345, 404);
            this.Controls.Add(this.rainbowBtn);
            this.Controls.Add(this.christmasLightBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Name = "LightControlForm";
            this.Text = "LightControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button christmasLightBtn;
        private System.Windows.Forms.Button rainbowBtn;
    }
}

