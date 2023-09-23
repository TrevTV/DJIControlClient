using DJIControlClient;
using System.Text.RegularExpressions;

namespace ExampleGUI
{
    public partial class MainWindow : Form
    {
        private Drone _drone;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            ipAddrTextBox.Text = "192.168.12.131:8080";
#endif
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            const string IP_PORT_RGX = "^\\b(?:[0-9]{1,3}\\.){3}[0-9]{1,3}:[0-9]+\\b|\\b[0-9a-fA-F:]+\\[[0-9a-fA-F]+\\]:[0-9]+\\b";

            Regex rgx = new(IP_PORT_RGX);

            if (!rgx.IsMatch(ipAddrTextBox.Text))
            {
                MessageBox.Show("Your IP:Port is invalid.");
                return;
            }

            connectedLabel.Text = "Connected: Waiting";

            _drone = new(ipAddrTextBox.Text);
            bool connected = await _drone.IsConnected();

            connectedLabel.Text = "Connected: " + connected;
        }
    }
}