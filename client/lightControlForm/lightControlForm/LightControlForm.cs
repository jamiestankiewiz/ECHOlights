﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lightControlForm.Properties;
using lightControlLibrary;

namespace lightControlForm
{
    public partial class LightControlForm : Form
    {
        public SocketConnection Client { get; set; }
        private bool disconnectSwitch;
        private bool initSwitch;

        public LightControlForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disconnectBtn.Enabled = false;
            stopBtn.Enabled = false;
            connectBtn.Focus();
            allBtnOff();
            portTextBox.Text = Settings.Default.Port.ToString();
            ipAddressTextBox.Text = Settings.Default.IpAdd;
            initSwitch = false;
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            // Connect to the socket
            try
            {
                Client = new SocketConnection(ipAddressTextBox.Text, Convert.ToInt32(portTextBox.Text));
                Client.SocketSetup();
                Client.Connect();

                buttotnStatus();
                initSwitch = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Make sure the server is active.","Connection Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private async void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client.IsActive = false;
                connectBtn.Enabled = false;
                buttotnStatus();

                // Disconnect from the socket
                var resp = await Task.Run(() => Client.Send("quit"));
                //Client.Send("quit");
                Client.Disconnect();
                connectBtn.Enabled = true;
                disconnectSwitch = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}.", "Disconnect Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttotnStatus()
        {
            if (Client.IsActive)
            {
                connectBtn.Enabled = false;
                disconnectBtn.Enabled = false;
                allBtnON();


            }
            else
            {
                connectBtn.Enabled = true;
                disconnectBtn.Enabled = false;
                stopBtn.Enabled = false;
                allBtnOff();
            }
        }

        private async void formClosing(object sender, FormClosingEventArgs e)
        {
            if (!initSwitch)
            {
                e.Cancel = false;
                return;
            }
            //var res = MessageBox.Show(this, "You really want to quit?", "Exit",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (res == DialogResult.Yes)
            //{
                if (!disconnectSwitch)
                {
                    e.Cancel = true;
                    MessageBox.Show("To safely exit the application, click 'DISCONNECT'\n\nIf 'DISCONNECT' is greyed out, click 'STOP' then 'DISCONNECT'","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    e.Cancel = false;
                    if (Client != null)
                    {
                        await Task.Run(() => Client.Send("stop"));

                        var resp = await Task.Run(() => Client.Send("quit"));
                        //Client.Send("quit");
                        Client.Disconnect();
                        buttotnStatus();
                    }
                }
            //}
            //else
            //{
            //    e.Cancel = true;
            //}

            //if (Client != null)
            //{
            //    await Task.Run(() => Client.Send("stop"));

            //    var resp = await Task.Run(() => Client.Send("quit"));
            //    //Client.Send("quit");
            //    Client.Disconnect();
            //    buttotnStatus();
            //}
        }

        private void allBtnON()
        {
            colorWipeBtn.Enabled = true;
            christmasLightBtn.Enabled = true;
            rainbowBtn.Enabled = true;
            stopBtn.Enabled = true;
            rainbowBtn.Enabled = true;
            rainbowCycleBtn.Enabled = true;
            meteorRainBtn.Enabled = true;
            fillRandomBtn.Enabled = true;
            randomColorsBtn.Enabled = true;
            theaterChaseBtn.Enabled = true;
            theaterChaseRainbowBtn.Enabled = true;
            alternateSingleBtn.Enabled = true;
            zipBtn.Enabled = true;
            StackBtn.Enabled = true;
        }

        private void allBtnOff()
        {
            colorWipeBtn.Enabled = false;
            christmasLightBtn.Enabled = false;
            rainbowBtn.Enabled = false;
            rainbowBtn.Enabled = false;
            rainbowCycleBtn.Enabled = false;
            meteorRainBtn.Enabled = false;
            fillRandomBtn.Enabled = false;
            randomColorsBtn.Enabled = false;
            theaterChaseBtn.Enabled = false;
            theaterChaseRainbowBtn.Enabled = false;
            alternateSingleBtn.Enabled = false;
            zipBtn.Enabled = false;
            StackBtn.Enabled = false;
        }

        private async void christmasLightBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("christmas"));
        }

        private async void rainbowBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("rainbow"));
        }

        private async void stopBtn_Click(object sender, EventArgs e)
        {
            allBtnON();
            disconnectBtn.Enabled = true;
            await Task.Run(() => Client.Send("stop"));
        }

        private async void colorWipeBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("color"));
        }

        private async void rainbowCycle_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("rainbowCycle"));
        }

        private async void meteorRainBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("meteorRain"));
        }

        private async void fillRandomBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("fillRandom"));
        }

        private async void theaterChaseBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("theaterChase"));
        }

        private async void theaterChaseRainbow_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("theaterChaseRainbow"));
        }

        private async void alternateSingleBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("alternateSingle"));
        }

        private async void zipBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("zip"));
        }

        private async void StackBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("stack"));
        }

        private async void randomColorsBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("randomColors"));
        }

        private void textChanged(object sender, EventArgs e)
        {
            Settings.Default.Port = Convert.ToInt32(portTextBox.Text);
            Settings.Default.IP = ipAddressTextBox.Text;
            Settings.Default.Save();
            
        }
    }
}
