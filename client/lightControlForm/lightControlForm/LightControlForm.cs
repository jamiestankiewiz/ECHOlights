using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lightControlLibrary;

namespace lightControlForm
{
    public partial class LightControlForm : Form
    {
        public SocketConnection Client { get; set; }
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
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            // Connect to the socket
            try
            {
                //Client = new SocketConnection("192.168.0.14",7804);//"10.10.14.53", 7802);
                Client = new SocketConnection(ipAddressTextBox.Text, Convert.ToInt32(portTextBox.Text));
                Client.SocketSetup();
                Client.Connect();

                buttotnStatus();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Make sure the server is active.","Connection Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private async void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Disconnect from the socket
                var resp = await Task.Run(() => Client.Send("quit"));
                Client.Disconnect();

                buttotnStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}.", "Disconnect Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buttotnStatus()
        {
            if (Client.IsActive)
            {
                connectBtn.Enabled = false;
                disconnectBtn.Enabled = true;
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

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (Client != null)
            {
                Client.Disconnect();
                buttotnStatus();
            }
        }

        private async void stopBtn_Click(object sender, EventArgs e)
        {
            allBtnON();
            await Task.Run(() => Client.Send("stop"));
        }

        private async void colorWipeBtn_Click(object sender, EventArgs e)
        {
            allBtnOff();
            await Task.Run(() => Client.Send("color"));
        }

        private void allBtnON()
        {
            colorWipeBtn.Enabled = true;
            christmasLightBtn.Enabled = true;
            rainbowBtn.Enabled = true;
            stopBtn.Enabled = true;
        }

        private void allBtnOff()
        {
            colorWipeBtn.Enabled = false;
            christmasLightBtn.Enabled = false;
            rainbowBtn.Enabled = false;
        }
    }
}
