namespace RemoteConnectionToLinux
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tbArestechIPC_ = new TextBox();
            btCheckRemoteIP = new Button();
            btConnnect = new Button();
            label2 = new Label();
            label3 = new Label();
            tbArestechUser = new TextBox();
            label4 = new Label();
            tbAMRFleetIP = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbArestechPassword = new TextBox();
            tbFleetPassword = new TextBox();
            tbFleetUser = new TextBox();
            tabPage2 = new TabPage();
            statusStrip1 = new StatusStrip();
            toolStripContainer1 = new ToolStripContainer();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 394);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main Settings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 254F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 327F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbArestechIPC_, 1, 0);
            tableLayoutPanel1.Controls.Add(btCheckRemoteIP, 2, 3);
            tableLayoutPanel1.Controls.Add(btConnnect, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(tbArestechUser, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(tbAMRFleetIP, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(tbArestechPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(tbFleetPassword, 1, 5);
            tableLayoutPanel1.Controls.Add(tbFleetUser, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(784, 358);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(36, 18);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 0;
            label1.Text = "Arestech IPC IP Address:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbArestechIPC_
            // 
            tbArestechIPC_.Anchor = AnchorStyles.None;
            tbArestechIPC_.Location = new Point(317, 16);
            tbArestechIPC_.Name = "tbArestechIPC_";
            tbArestechIPC_.Size = new Size(200, 23);
            tbArestechIPC_.TabIndex = 1;
            // 
            // btCheckRemoteIP
            // 
            btCheckRemoteIP.Anchor = AnchorStyles.None;
            btCheckRemoteIP.Location = new Point(632, 188);
            btCheckRemoteIP.Name = "btCheckRemoteIP";
            btCheckRemoteIP.Size = new Size(101, 35);
            btCheckRemoteIP.TabIndex = 2;
            btCheckRemoteIP.Text = "Set as Default";
            btCheckRemoteIP.UseVisualStyleBackColor = true;
            btCheckRemoteIP.Click += btCheckRemoteIP_Click;
            // 
            // btConnnect
            // 
            btConnnect.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(btConnnect, 3);
            btConnnect.Location = new Point(269, 311);
            btConnnect.Name = "btConnnect";
            btConnnect.Size = new Size(245, 35);
            btConnnect.TabIndex = 7;
            btConnnect.Text = "Connect and copy log folders from Remote";
            btConnnect.UseVisualStyleBackColor = true;
            btConnnect.Click += btConnnect_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(85, 79);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(87, 140);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbArestechUser
            // 
            tbArestechUser.Anchor = AnchorStyles.None;
            tbArestechUser.Location = new Point(317, 77);
            tbArestechUser.Name = "tbArestechUser";
            tbArestechUser.Size = new Size(200, 23);
            tbArestechUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(44, 196);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 8;
            label4.Text = "AMR.Fleet IP Address:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbAMRFleetIP
            // 
            tbAMRFleetIP.Anchor = AnchorStyles.None;
            tbAMRFleetIP.Location = new Point(317, 194);
            tbAMRFleetIP.Name = "tbAMRFleetIP";
            tbAMRFleetIP.Size = new Size(200, 23);
            tbAMRFleetIP.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(85, 240);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 10;
            label5.Text = "Username:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(87, 272);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 11;
            label6.Text = "Password:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbArestechPassword
            // 
            tbArestechPassword.Anchor = AnchorStyles.None;
            tbArestechPassword.Location = new Point(317, 138);
            tbArestechPassword.Name = "tbArestechPassword";
            tbArestechPassword.PasswordChar = '*';
            tbArestechPassword.Size = new Size(200, 23);
            tbArestechPassword.TabIndex = 6;
            // 
            // tbFleetPassword
            // 
            tbFleetPassword.Anchor = AnchorStyles.None;
            tbFleetPassword.Location = new Point(317, 271);
            tbFleetPassword.Name = "tbFleetPassword";
            tbFleetPassword.PasswordChar = '*';
            tbFleetPassword.Size = new Size(200, 23);
            tbFleetPassword.TabIndex = 12;
            // 
            // tbFleetUser
            // 
            tbFleetUser.Anchor = AnchorStyles.None;
            tbFleetUser.Location = new Point(317, 238);
            tbFleetUser.Name = "tbFleetUser";
            tbFleetUser.Size = new Size(200, 23);
            tbFleetUser.TabIndex = 13;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 366);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Remote Executions";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.AutoScroll = true;
            toolStripContainer1.ContentPanel.Controls.Add(tabControl1);
            toolStripContainer1.ContentPanel.Size = new Size(800, 428);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 2;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "MainWindow";
            Text = "MainWindow";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TabPage tabPage2;
        private StatusStrip statusStrip1;
        private ToolStripContainer toolStripContainer1;
        private TextBox tbArestechUser;
        private Label label2;
        private TextBox tbArestechIPC_;
        private Button btCheckRemoteIP;
        private Label label3;
        private TextBox tbArestechPassword;
        private Button btConnnect;
        private Label label4;
        private TextBox tbAMRFleetIP;
        private Label label5;
        private Label label6;
        private TextBox tbFleetPassword;
        private TextBox tbFleetUser;
    }
}
