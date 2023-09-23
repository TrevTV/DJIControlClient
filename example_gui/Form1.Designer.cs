namespace ExampleGUI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ipAddrTextBox = new TextBox();
            connectButton = new Button();
            connectedLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            landingProtectioncheckBox = new CheckBox();
            button6 = new Button();
            button7 = new Button();
            controlModeCombo = new ComboBox();
            button8 = new Button();
            button9 = new Button();
            maxSpeedTextBox = new TextBox();
            maxAngSpeedTextBox = new TextBox();
            button10 = new Button();
            button11 = new Button();
            velocProfCombo = new ComboBox();
            button12 = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // ipAddrTextBox
            // 
            ipAddrTextBox.Location = new Point(12, 12);
            ipAddrTextBox.Name = "ipAddrTextBox";
            ipAddrTextBox.PlaceholderText = "IP:Port";
            ipAddrTextBox.Size = new Size(174, 23);
            ipAddrTextBox.TabIndex = 0;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(192, 12);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(75, 23);
            connectButton.TabIndex = 1;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // connectedLabel
            // 
            connectedLabel.AutoSize = true;
            connectedLabel.Location = new Point(12, 38);
            connectedLabel.Name = "connectedLabel";
            connectedLabel.Size = new Size(97, 15);
            connectedLabel.TabIndex = 2;
            connectedLabel.Text = "Connected: False";
            // 
            // button1
            // 
            button1.Location = new Point(12, 67);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Takeoff";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 67);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Land";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 67);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 5;
            button3.Text = "Confirm Landing";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(611, 12);
            button4.Name = "button4";
            button4.Size = new Size(177, 23);
            button4.TabIndex = 6;
            button4.Text = "Is Landing Protection Enabled";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(632, 41);
            button5.Name = "button5";
            button5.Size = new Size(156, 23);
            button5.TabIndex = 7;
            button5.Text = "Set Landing Protection";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // landingProtectioncheckBox
            // 
            landingProtectioncheckBox.AutoSize = true;
            landingProtectioncheckBox.Location = new Point(611, 46);
            landingProtectioncheckBox.Name = "landingProtectioncheckBox";
            landingProtectioncheckBox.Size = new Size(15, 14);
            landingProtectioncheckBox.TabIndex = 8;
            landingProtectioncheckBox.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(675, 99);
            button6.Name = "button6";
            button6.Size = new Size(113, 23);
            button6.TabIndex = 9;
            button6.Text = "Set Control Mode";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(611, 70);
            button7.Name = "button7";
            button7.Size = new Size(177, 23);
            button7.TabIndex = 10;
            button7.Text = "Get Control Mode";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // controlModeCombo
            // 
            controlModeCombo.FormattingEnabled = true;
            controlModeCombo.Items.AddRange(new object[] { "POSITION", "VELOCITY" });
            controlModeCombo.Location = new Point(611, 99);
            controlModeCombo.Name = "controlModeCombo";
            controlModeCombo.Size = new Size(58, 23);
            controlModeCombo.TabIndex = 11;
            // 
            // button8
            // 
            button8.Location = new Point(611, 128);
            button8.Name = "button8";
            button8.Size = new Size(177, 23);
            button8.TabIndex = 12;
            button8.Text = "Get Max Speed";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(689, 157);
            button9.Name = "button9";
            button9.Size = new Size(99, 23);
            button9.TabIndex = 13;
            button9.Text = "Set Max Speed";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // maxSpeedTextBox
            // 
            maxSpeedTextBox.Location = new Point(611, 158);
            maxSpeedTextBox.Name = "maxSpeedTextBox";
            maxSpeedTextBox.Size = new Size(72, 23);
            maxSpeedTextBox.TabIndex = 14;
            maxSpeedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // maxAngSpeedTextBox
            // 
            maxAngSpeedTextBox.Location = new Point(611, 217);
            maxAngSpeedTextBox.Name = "maxAngSpeedTextBox";
            maxAngSpeedTextBox.Size = new Size(47, 23);
            maxAngSpeedTextBox.TabIndex = 17;
            maxAngSpeedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button10
            // 
            button10.Location = new Point(664, 216);
            button10.Name = "button10";
            button10.Size = new Size(124, 23);
            button10.TabIndex = 16;
            button10.Text = "Set Max Ang Speed";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(611, 187);
            button11.Name = "button11";
            button11.Size = new Size(177, 23);
            button11.TabIndex = 15;
            button11.Text = "Get Max Angular Speed";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // velocProfCombo
            // 
            velocProfCombo.FormattingEnabled = true;
            velocProfCombo.Items.AddRange(new object[] { "CONSTANT", "TRAPEZOIDAL", "S_CURVE" });
            velocProfCombo.Location = new Point(611, 275);
            velocProfCombo.Name = "velocProfCombo";
            velocProfCombo.Size = new Size(58, 23);
            velocProfCombo.TabIndex = 20;
            // 
            // button12
            // 
            button12.Location = new Point(611, 246);
            button12.Name = "button12";
            button12.Size = new Size(177, 23);
            button12.TabIndex = 19;
            button12.Text = "Get Velocity Profile";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(675, 275);
            button13.Name = "button13";
            button13.Size = new Size(113, 23);
            button13.TabIndex = 18;
            button13.Text = "Set Velocity Profile";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(velocProfCombo);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(maxAngSpeedTextBox);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(maxSpeedTextBox);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(controlModeCombo);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(landingProtectioncheckBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(connectedLabel);
            Controls.Add(connectButton);
            Controls.Add(ipAddrTextBox);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "DJIControlClient Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ipAddrTextBox;
        private Button connectButton;
        private Label connectedLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckBox landingProtectioncheckBox;
        private Button button6;
        private Button button7;
        private ComboBox controlModeCombo;
        private Button button8;
        private Button button9;
        private TextBox maxSpeedTextBox;
        private TextBox maxAngSpeedTextBox;
        private Button button10;
        private Button button11;
        private ComboBox velocProfCombo;
        private Button button12;
        private Button button13;
    }
}