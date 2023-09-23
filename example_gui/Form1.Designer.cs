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
            button4.Location = new Point(611, 67);
            button4.Name = "button4";
            button4.Size = new Size(177, 23);
            button4.TabIndex = 6;
            button4.Text = "Is Landing Protection Enabled";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}