namespace ludo_client
{
    partial class ludoForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rootConnectTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.connectTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.connectButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.rootServerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.serverTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.chatTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.messageTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.chatListView = new System.Windows.Forms.ListView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.rootConnectTableLayout.SuspendLayout();
            this.connectTableLayout.SuspendLayout();
            this.rootServerTableLayout.SuspendLayout();
            this.serverTableLayout.SuspendLayout();
            this.chatTableLayout.SuspendLayout();
            this.messageTableLayout.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rootConnectTableLayout
            // 
            this.rootConnectTableLayout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rootConnectTableLayout.ColumnCount = 1;
            this.rootConnectTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.12849F));
            this.rootConnectTableLayout.Controls.Add(this.connectTableLayout, 0, 0);
            this.rootConnectTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootConnectTableLayout.Location = new System.Drawing.Point(0, 24);
            this.rootConnectTableLayout.Name = "rootConnectTableLayout";
            this.rootConnectTableLayout.RowCount = 1;
            this.rootConnectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.45283F));
            this.rootConnectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.rootConnectTableLayout.Size = new System.Drawing.Size(722, 453);
            this.rootConnectTableLayout.TabIndex = 2;
            // 
            // connectTableLayout
            // 
            this.connectTableLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectTableLayout.ColumnCount = 2;
            this.connectTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectTableLayout.Controls.Add(this.connectButton, 1, 2);
            this.connectTableLayout.Controls.Add(this.userNameLabel, 0, 0);
            this.connectTableLayout.Controls.Add(this.serverTextBox, 1, 1);
            this.connectTableLayout.Controls.Add(this.serverLabel, 0, 1);
            this.connectTableLayout.Controls.Add(this.userNameTextBox, 1, 0);
            this.connectTableLayout.Location = new System.Drawing.Point(267, 163);
            this.connectTableLayout.Name = "connectTableLayout";
            this.connectTableLayout.RowCount = 3;
            this.connectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.connectTableLayout.Size = new System.Drawing.Size(187, 127);
            this.connectTableLayout.TabIndex = 5;
            this.connectTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.connectTableLayout_Paint);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(96, 93);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(88, 30);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(3, 12);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(87, 20);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username:";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTextBox.Location = new System.Drawing.Point(96, 54);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(88, 26);
            this.serverTextBox.TabIndex = 3;
            this.serverTextBox.Text = "localhost";
            // 
            // serverLabel
            // 
            this.serverLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.Location = new System.Drawing.Point(31, 57);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(59, 20);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Server:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(96, 9);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(88, 26);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Text = "Cir0X";
            // 
            // rootServerTableLayout
            // 
            this.rootServerTableLayout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rootServerTableLayout.ColumnCount = 2;
            this.rootServerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.10249F));
            this.rootServerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.89751F));
            this.rootServerTableLayout.Controls.Add(this.serverTableLayout, 0, 0);
            this.rootServerTableLayout.Controls.Add(this.listView1, 1, 0);
            this.rootServerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootServerTableLayout.Location = new System.Drawing.Point(0, 24);
            this.rootServerTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.rootServerTableLayout.Name = "rootServerTableLayout";
            this.rootServerTableLayout.RowCount = 1;
            this.rootServerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootServerTableLayout.Size = new System.Drawing.Size(722, 453);
            this.rootServerTableLayout.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(600, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(122, 453);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // serverTableLayout
            // 
            this.serverTableLayout.ColumnCount = 1;
            this.serverTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serverTableLayout.Controls.Add(this.chatTableLayout, 0, 1);
            this.serverTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverTableLayout.Location = new System.Drawing.Point(0, 0);
            this.serverTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.serverTableLayout.Name = "serverTableLayout";
            this.serverTableLayout.RowCount = 2;
            this.serverTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.73068F));
            this.serverTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.26932F));
            this.serverTableLayout.Size = new System.Drawing.Size(600, 453);
            this.serverTableLayout.TabIndex = 1;
            // 
            // chatTableLayout
            // 
            this.chatTableLayout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chatTableLayout.ColumnCount = 1;
            this.chatTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatTableLayout.Controls.Add(this.messageTableLayout, 0, 1);
            this.chatTableLayout.Controls.Add(this.chatListView, 0, 0);
            this.chatTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTableLayout.Location = new System.Drawing.Point(3, 336);
            this.chatTableLayout.Name = "chatTableLayout";
            this.chatTableLayout.RowCount = 2;
            this.chatTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.78571F));
            this.chatTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.21428F));
            this.chatTableLayout.Size = new System.Drawing.Size(594, 114);
            this.chatTableLayout.TabIndex = 0;
            // 
            // messageTableLayout
            // 
            this.messageTableLayout.ColumnCount = 2;
            this.messageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.69072F));
            this.messageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.messageTableLayout.Controls.Add(this.messageTextBox, 0, 0);
            this.messageTableLayout.Controls.Add(this.sendMessageButton, 1, 0);
            this.messageTableLayout.Location = new System.Drawing.Point(0, 87);
            this.messageTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.messageTableLayout.Name = "messageTableLayout";
            this.messageTableLayout.RowCount = 1;
            this.messageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messageTableLayout.Size = new System.Drawing.Size(594, 27);
            this.messageTableLayout.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(0, 0);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.messageTextBox.MaxLength = 20;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(532, 26);
            this.messageTextBox.TabIndex = 0;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageButton.Location = new System.Drawing.Point(532, 0);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(0);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(62, 27);
            this.sendMessageButton.TabIndex = 1;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // chatListView
            // 
            this.chatListView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chatListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatListView.Location = new System.Drawing.Point(0, 0);
            this.chatListView.Margin = new System.Windows.Forms.Padding(0);
            this.chatListView.Name = "chatListView";
            this.chatListView.Size = new System.Drawing.Size(594, 87);
            this.chatListView.TabIndex = 2;
            this.chatListView.UseCompatibleStateImageBehavior = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rootServerTableLayout);
            this.mainPanel.Controls.Add(this.rootConnectTableLayout);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(0, 24, 0, 22);
            this.mainPanel.Size = new System.Drawing.Size(722, 499);
            this.mainPanel.TabIndex = 1;
            // 
            // ludoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 499);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ludoForm";
            this.Text = "Ludo Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rootConnectTableLayout.ResumeLayout(false);
            this.connectTableLayout.ResumeLayout(false);
            this.connectTableLayout.PerformLayout();
            this.rootServerTableLayout.ResumeLayout(false);
            this.serverTableLayout.ResumeLayout(false);
            this.chatTableLayout.ResumeLayout(false);
            this.messageTableLayout.ResumeLayout(false);
            this.messageTableLayout.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel rootConnectTableLayout;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TableLayoutPanel connectTableLayout;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.TableLayoutPanel rootServerTableLayout;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel serverTableLayout;
        private System.Windows.Forms.TableLayoutPanel chatTableLayout;
        private System.Windows.Forms.TableLayoutPanel messageTableLayout;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.ListView chatListView;
    }
}

