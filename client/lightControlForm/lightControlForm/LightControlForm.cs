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
            christmasLightBtn.Enabled = false;
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            // Connect to the socket
            try
            {
                Client = new SocketConnection("10.10.14.53", 7792);
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
                var resp = await Task.Run(() => Client.Send("exit"));
                MessageBox.Show(resp);
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
            // Christmas Light

            //var resp = Client.Send("testing1");

            var resp = await Task.Run(() => Client.Send("testing1"));

            //var resp = Client.Send("testing");
            MessageBox.Show(resp);
        }

        private void rainbowBtn_Click(object sender, EventArgs e)
        {
            var resp = Task.Run(() => Client.Send("testing2"));
            MessageBox.Show(resp.Result);
        }

        private void buttotnStatus()
        {
            if (Client.IsActive)
            {
                connectBtn.Enabled = false;
                disconnectBtn.Enabled = true;
                christmasLightBtn.Enabled = true;
            }
            else
            {
                connectBtn.Enabled = true;
                disconnectBtn.Enabled = false;
                christmasLightBtn.Enabled = false;
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Client.Disconnect();

            buttotnStatus();
        }
    }
}
