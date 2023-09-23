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
            connectButton_Click(null, null);
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

        private async void button1_Click(object sender, EventArgs e)
        {
            await _drone.Takeoff();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await _drone.Land();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await _drone.ConfirmLanding();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            bool res = await _drone.IsLandingProtectionEnabled();
            MessageBox.Show(res.ToString());
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await _drone.SetLandingProtection(landingProtectioncheckBox.Checked);
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            ControlMode mode = await _drone.GetControlMode();
            MessageBox.Show(mode.ToString());
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string str = controlModeCombo.Items[controlModeCombo.SelectedIndex]?.ToString() ?? "";
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Invalid control mode");
                return;
            }

            ControlMode mode = (ControlMode)Enum.Parse(typeof(ControlMode), str);
            await _drone.SetControlMode(mode);
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            float speed = await _drone.GetMaxSpeed();
            MessageBox.Show(speed.ToString());
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            if (float.TryParse(maxSpeedTextBox.Text, out float speed))
            {
                await _drone.SetMaxSpeed(speed);
            }
            else
                MessageBox.Show("Invalid speed");
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            float speed = await _drone.GetMaxAngularSpeed();
            MessageBox.Show(speed.ToString());
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            if (float.TryParse(maxAngSpeedTextBox.Text, out float speed))
            {
                await _drone.SetMaxAngularSpeed(speed);
            }
            else
                MessageBox.Show("Invalid speed");
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            VelocityProfile profile = await _drone.GetVelocityProfile();
            MessageBox.Show(profile.ToString());
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            string str = velocProfCombo.Items[velocProfCombo.SelectedIndex]?.ToString() ?? "";
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Invalid control mode");
                return;
            }

            VelocityProfile profile = (VelocityProfile)Enum.Parse(typeof(VelocityProfile), str);
            await _drone.SetVelocityProfile(profile);
        }
    }
}