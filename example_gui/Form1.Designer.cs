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
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            label1 = new Label();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            angleTextBox = new TextBox();
            twodimDist = new TextBox();
            threedDist = new TextBox();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            velocityTextBox = new TextBox();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
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
            // button14
            // 
            button14.Location = new Point(9, 457);
            button14.Name = "button14";
            button14.Size = new Size(177, 23);
            button14.TabIndex = 21;
            button14.Text = "Get Current IMU State";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(9, 316);
            button15.Name = "button15";
            button15.Size = new Size(177, 23);
            button15.TabIndex = 22;
            button15.Text = "Start Collecting IMU States";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(9, 345);
            button16.Name = "button16";
            button16.Size = new Size(177, 23);
            button16.TabIndex = 23;
            button16.Text = "Stop Collecting IMU States";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 298);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 24;
            label1.Text = "1000ms interval";
            // 
            // button17
            // 
            button17.Location = new Point(9, 374);
            button17.Name = "button17";
            button17.Size = new Size(177, 23);
            button17.TabIndex = 25;
            button17.Text = "Clear Collected IMU States";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(9, 403);
            button18.Name = "button18";
            button18.Size = new Size(177, 23);
            button18.TabIndex = 26;
            button18.Text = "Get Collected IMU States";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Location = new Point(276, 187);
            button19.Name = "button19";
            button19.Size = new Size(75, 23);
            button19.TabIndex = 27;
            button19.Text = "Forward";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.Location = new Point(204, 216);
            button20.Name = "button20";
            button20.Size = new Size(75, 23);
            button20.TabIndex = 28;
            button20.Text = "Left";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.Location = new Point(347, 216);
            button21.Name = "button21";
            button21.Size = new Size(75, 23);
            button21.TabIndex = 29;
            button21.Text = "Right";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // button22
            // 
            button22.Location = new Point(276, 245);
            button22.Name = "button22";
            button22.Size = new Size(75, 23);
            button22.TabIndex = 30;
            button22.Text = "Backward";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button23.Location = new Point(204, 128);
            button23.Name = "button23";
            button23.Size = new Size(75, 32);
            button23.TabIndex = 31;
            button23.Text = "↶";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // button24
            // 
            button24.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button24.Location = new Point(347, 128);
            button24.Name = "button24";
            button24.Size = new Size(75, 32);
            button24.TabIndex = 32;
            button24.Text = "↷";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button24_Click;
            // 
            // button25
            // 
            button25.Location = new Point(456, 245);
            button25.Name = "button25";
            button25.Size = new Size(75, 23);
            button25.TabIndex = 34;
            button25.Text = "Down";
            button25.UseVisualStyleBackColor = true;
            button25.Click += button25_Click;
            // 
            // button26
            // 
            button26.Location = new Point(456, 187);
            button26.Name = "button26";
            button26.Size = new Size(75, 23);
            button26.TabIndex = 33;
            button26.Text = "Up";
            button26.UseVisualStyleBackColor = true;
            button26.Click += button26_Click;
            // 
            // angleTextBox
            // 
            angleTextBox.Location = new Point(285, 129);
            angleTextBox.Name = "angleTextBox";
            angleTextBox.PlaceholderText = "Angle";
            angleTextBox.Size = new Size(56, 23);
            angleTextBox.TabIndex = 35;
            // 
            // twodimDist
            // 
            twodimDist.Location = new Point(285, 217);
            twodimDist.Name = "twodimDist";
            twodimDist.PlaceholderText = "Distance";
            twodimDist.Size = new Size(56, 23);
            twodimDist.TabIndex = 36;
            // 
            // threedDist
            // 
            threedDist.Location = new Point(465, 216);
            threedDist.Name = "threedDist";
            threedDist.PlaceholderText = "Distance";
            threedDist.Size = new Size(56, 23);
            threedDist.TabIndex = 37;
            // 
            // button27
            // 
            button27.Location = new Point(226, 345);
            button27.Name = "button27";
            button27.Size = new Size(177, 23);
            button27.TabIndex = 41;
            button27.Text = "Stop Velocity Control";
            button27.UseVisualStyleBackColor = true;
            button27.Click += button27_Click;
            // 
            // button28
            // 
            button28.Location = new Point(226, 403);
            button28.Name = "button28";
            button28.Size = new Size(177, 23);
            button28.TabIndex = 40;
            button28.Text = "Get Current Velocity";
            button28.UseVisualStyleBackColor = true;
            button28.Click += button28_Click;
            // 
            // button29
            // 
            button29.Location = new Point(324, 374);
            button29.Name = "button29";
            button29.Size = new Size(79, 23);
            button29.TabIndex = 39;
            button29.Text = "Set Velocity";
            button29.UseVisualStyleBackColor = true;
            button29.Click += button29_Click;
            // 
            // button30
            // 
            button30.Location = new Point(226, 316);
            button30.Name = "button30";
            button30.Size = new Size(177, 23);
            button30.TabIndex = 38;
            button30.Text = "Start Velocity Control";
            button30.UseVisualStyleBackColor = true;
            button30.Click += button30_Click;
            // 
            // velocityTextBox
            // 
            velocityTextBox.Location = new Point(226, 374);
            velocityTextBox.Name = "velocityTextBox";
            velocityTextBox.PlaceholderText = "X,Y,Z,YawRate";
            velocityTextBox.Size = new Size(92, 23);
            velocityTextBox.TabIndex = 42;
            velocityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button31
            // 
            button31.Location = new Point(611, 456);
            button31.Name = "button31";
            button31.Size = new Size(177, 23);
            button31.TabIndex = 43;
            button31.Text = "Get Heading";
            button31.UseVisualStyleBackColor = true;
            button31.Click += button31_Click;
            // 
            // button32
            // 
            button32.Location = new Point(611, 427);
            button32.Name = "button32";
            button32.Size = new Size(177, 23);
            button32.TabIndex = 44;
            button32.Text = "Get Altitude";
            button32.UseVisualStyleBackColor = true;
            button32.Click += button32_Click;
            // 
            // button33
            // 
            button33.Location = new Point(12, 99);
            button33.Name = "button33";
            button33.Size = new Size(75, 23);
            button33.TabIndex = 45;
            button33.Text = "Reboot";
            button33.UseVisualStyleBackColor = true;
            button33.Click += button33_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(button33);
            Controls.Add(button32);
            Controls.Add(button31);
            Controls.Add(velocityTextBox);
            Controls.Add(button27);
            Controls.Add(button28);
            Controls.Add(button29);
            Controls.Add(button30);
            Controls.Add(threedDist);
            Controls.Add(twodimDist);
            Controls.Add(angleTextBox);
            Controls.Add(button25);
            Controls.Add(button26);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(label1);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
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
        private Button button14;
        private Button button15;
        private Button button16;
        private Label label1;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private TextBox angleTextBox;
        private TextBox twodimDist;
        private TextBox threedDist;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private TextBox velocityTextBox;
        private Button button31;
        private Button button32;
        private Button button33;
    }
}