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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}