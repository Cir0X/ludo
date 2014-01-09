using System.Windows.Forms;
namespace ludo_client
{
    partial class LudoForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rootConnectTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.connectTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.connectButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.rootServerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.serverChatTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.serverAndGamePanel = new System.Windows.Forms.Panel();
            this.serverTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.roomListAndLobbyPanel = new System.Windows.Forms.Panel();
            this.roomList = new System.Windows.Forms.ListView();
            this.roomIDColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersInRoomColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomStatusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userInLobbyListBox = new System.Windows.Forms.ListBox();
            this.roomControlsPanel = new System.Windows.Forms.Panel();
            this.readyButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.createRoomButton = new System.Windows.Forms.Button();
            this.gameTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.playGroundPicture = new System.Windows.Forms.PictureBox();
            this.chatTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.chatTabControl = new System.Windows.Forms.TabControl();
            this.serverChatTabPage = new System.Windows.Forms.TabPage();
            this.messageList = new System.Windows.Forms.RichTextBox();
            this.roomChatTabPage = new System.Windows.Forms.TabPage();
            this.roomMessageList = new System.Windows.Forms.RichTextBox();
            this.messageTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.onlineUserList = new System.Windows.Forms.ListView();
            this.userNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.rootConnectTableLayout.SuspendLayout();
            this.connectTableLayout.SuspendLayout();
            this.rootServerTableLayout.SuspendLayout();
            this.serverChatTableLayout.SuspendLayout();
            this.serverAndGamePanel.SuspendLayout();
            this.serverTableLayout.SuspendLayout();
            this.roomListAndLobbyPanel.SuspendLayout();
            this.roomControlsPanel.SuspendLayout();
            this.gameTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playGroundPicture)).BeginInit();
            this.chatTableLayout.SuspendLayout();
            this.chatTabControl.SuspendLayout();
            this.serverChatTabPage.SuspendLayout();
            this.roomChatTabPage.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 708);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // pingStatusLabel
            // 
            this.pingStatusLabel.Name = "pingStatusLabel";
            this.pingStatusLabel.Size = new System.Drawing.Size(0, 17);
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
            this.rootConnectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 684F));
            this.rootConnectTableLayout.Size = new System.Drawing.Size(1008, 684);
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
            this.connectTableLayout.Location = new System.Drawing.Point(410, 278);
            this.connectTableLayout.Name = "connectTableLayout";
            this.connectTableLayout.RowCount = 3;
            this.connectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.connectTableLayout.Size = new System.Drawing.Size(187, 127);
            this.connectTableLayout.TabIndex = 5;
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
            this.rootServerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.2746F));
            this.rootServerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.725407F));
            this.rootServerTableLayout.Controls.Add(this.serverChatTableLayout, 0, 0);
            this.rootServerTableLayout.Controls.Add(this.onlineUserList, 1, 0);
            this.rootServerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootServerTableLayout.Location = new System.Drawing.Point(0, 24);
            this.rootServerTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.rootServerTableLayout.Name = "rootServerTableLayout";
            this.rootServerTableLayout.RowCount = 1;
            this.rootServerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootServerTableLayout.Size = new System.Drawing.Size(1008, 684);
            this.rootServerTableLayout.TabIndex = 5;
            // 
            // serverChatTableLayout
            // 
            this.serverChatTableLayout.ColumnCount = 1;
            this.serverChatTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serverChatTableLayout.Controls.Add(this.serverAndGamePanel, 0, 0);
            this.serverChatTableLayout.Controls.Add(this.chatTableLayout, 0, 1);
            this.serverChatTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverChatTableLayout.Location = new System.Drawing.Point(0, 0);
            this.serverChatTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.serverChatTableLayout.Name = "serverChatTableLayout";
            this.serverChatTableLayout.RowCount = 2;
            this.serverChatTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78947F));
            this.serverChatTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.serverChatTableLayout.Size = new System.Drawing.Size(920, 684);
            this.serverChatTableLayout.TabIndex = 1;
            // 
            // serverAndGamePanel
            // 
            this.serverAndGamePanel.Controls.Add(this.serverTableLayout);
            this.serverAndGamePanel.Controls.Add(this.gameTableLayout);
            this.serverAndGamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverAndGamePanel.Location = new System.Drawing.Point(3, 3);
            this.serverAndGamePanel.Name = "serverAndGamePanel";
            this.serverAndGamePanel.Size = new System.Drawing.Size(914, 443);
            this.serverAndGamePanel.TabIndex = 7;
            // 
            // serverTableLayout
            // 
            this.serverTableLayout.ColumnCount = 1;
            this.serverTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serverTableLayout.Controls.Add(this.roomListAndLobbyPanel, 0, 0);
            this.serverTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverTableLayout.Location = new System.Drawing.Point(0, 0);
            this.serverTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.serverTableLayout.Name = "serverTableLayout";
            this.serverTableLayout.RowCount = 1;
            this.serverTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serverTableLayout.Size = new System.Drawing.Size(914, 443);
            this.serverTableLayout.TabIndex = 6;
            // 
            // roomListAndLobbyPanel
            // 
            this.roomListAndLobbyPanel.Controls.Add(this.roomList);
            this.roomListAndLobbyPanel.Controls.Add(this.userInLobbyListBox);
            this.roomListAndLobbyPanel.Controls.Add(this.roomControlsPanel);
            this.roomListAndLobbyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomListAndLobbyPanel.Location = new System.Drawing.Point(0, 0);
            this.roomListAndLobbyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.roomListAndLobbyPanel.Name = "roomListAndLobbyPanel";
            this.roomListAndLobbyPanel.Size = new System.Drawing.Size(914, 443);
            this.roomListAndLobbyPanel.TabIndex = 6;
            // 
            // roomList
            // 
            this.roomList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.roomList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.roomList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomIDColumnHeader,
            this.roomNameColumnHeader,
            this.usersInRoomColumnHeader,
            this.roomStatusColumnHeader});
            this.roomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomList.FullRowSelect = true;
            this.roomList.GridLines = true;
            this.roomList.HideSelection = false;
            this.roomList.Location = new System.Drawing.Point(0, 0);
            this.roomList.Margin = new System.Windows.Forms.Padding(0);
            this.roomList.MultiSelect = false;
            this.roomList.Name = "roomList";
            this.roomList.ShowGroups = false;
            this.roomList.Size = new System.Drawing.Size(914, 403);
            this.roomList.TabIndex = 0;
            this.roomList.UseCompatibleStateImageBehavior = false;
            this.roomList.View = System.Windows.Forms.View.Details;
            this.roomList.Click += new System.EventHandler(this.roomList_Click);
            this.roomList.DoubleClick += new System.EventHandler(this.roomList_DoubleClick);
            // 
            // roomIDColumnHeader
            // 
            this.roomIDColumnHeader.Text = "ID";
            this.roomIDColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roomIDColumnHeader.Width = 25;
            // 
            // roomNameColumnHeader
            // 
            this.roomNameColumnHeader.Text = "Room Name";
            this.roomNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roomNameColumnHeader.Width = 89;
            // 
            // usersInRoomColumnHeader
            // 
            this.usersInRoomColumnHeader.Text = "Players";
            this.usersInRoomColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usersInRoomColumnHeader.Width = 58;
            // 
            // roomStatusColumnHeader
            // 
            this.roomStatusColumnHeader.Text = "Status";
            this.roomStatusColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roomStatusColumnHeader.Width = 439;
            // 
            // userInLobbyListBox
            // 
            this.userInLobbyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInLobbyListBox.FormattingEnabled = true;
            this.userInLobbyListBox.Location = new System.Drawing.Point(0, 0);
            this.userInLobbyListBox.Name = "userInLobbyListBox";
            this.userInLobbyListBox.Size = new System.Drawing.Size(914, 403);
            this.userInLobbyListBox.TabIndex = 1;
            this.userInLobbyListBox.Visible = false;
            // 
            // roomControlsPanel
            // 
            this.roomControlsPanel.Controls.Add(this.readyButton);
            this.roomControlsPanel.Controls.Add(this.startButton);
            this.roomControlsPanel.Controls.Add(this.joinButton);
            this.roomControlsPanel.Controls.Add(this.backButton);
            this.roomControlsPanel.Controls.Add(this.createRoomButton);
            this.roomControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roomControlsPanel.Location = new System.Drawing.Point(0, 403);
            this.roomControlsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.roomControlsPanel.MaximumSize = new System.Drawing.Size(0, 40);
            this.roomControlsPanel.Name = "roomControlsPanel";
            this.roomControlsPanel.Size = new System.Drawing.Size(914, 40);
            this.roomControlsPanel.TabIndex = 2;
            // 
            // readyButton
            // 
            this.readyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.readyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyButton.Location = new System.Drawing.Point(764, 0);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(75, 40);
            this.readyButton.TabIndex = 4;
            this.readyButton.Text = "Ready";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Visible = false;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(839, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 40);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.joinButton.Enabled = false;
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.Location = new System.Drawing.Point(181, 0);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 40);
            this.joinButton.TabIndex = 2;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(106, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // createRoomButton
            // 
            this.createRoomButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.createRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRoomButton.Location = new System.Drawing.Point(0, 0);
            this.createRoomButton.Name = "createRoomButton";
            this.createRoomButton.Size = new System.Drawing.Size(106, 40);
            this.createRoomButton.TabIndex = 0;
            this.createRoomButton.Text = "Create Room";
            this.createRoomButton.UseVisualStyleBackColor = true;
            this.createRoomButton.Click += new System.EventHandler(this.createRoomButton_Click);
            // 
            // gameTableLayout
            // 
            this.gameTableLayout.ColumnCount = 2;
            this.gameTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 754F));
            this.gameTableLayout.Controls.Add(this.playGroundPicture, 1, 0);
            this.gameTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTableLayout.Location = new System.Drawing.Point(0, 0);
            this.gameTableLayout.Name = "gameTableLayout";
            this.gameTableLayout.RowCount = 1;
            this.gameTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTableLayout.Size = new System.Drawing.Size(914, 443);
            this.gameTableLayout.TabIndex = 6;
            // 
            // playGroundPicture
            // 
            this.playGroundPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.playGroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGroundPicture.Image = global::ludo_client.Properties.Resources.ludo_ground;
            this.playGroundPicture.Location = new System.Drawing.Point(160, 0);
            this.playGroundPicture.Margin = new System.Windows.Forms.Padding(0);
            this.playGroundPicture.Name = "playGroundPicture";
            this.playGroundPicture.Size = new System.Drawing.Size(754, 443);
            this.playGroundPicture.TabIndex = 0;
            this.playGroundPicture.TabStop = false;
            // 
            // chatTableLayout
            // 
            this.chatTableLayout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chatTableLayout.ColumnCount = 1;
            this.chatTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatTableLayout.Controls.Add(this.chatTabControl, 0, 0);
            this.chatTableLayout.Controls.Add(this.messageTableLayout, 0, 1);
            this.chatTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTableLayout.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chatTableLayout.Location = new System.Drawing.Point(0, 449);
            this.chatTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.chatTableLayout.Name = "chatTableLayout";
            this.chatTableLayout.RowCount = 2;
            this.chatTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.76923F));
            this.chatTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.230769F));
            this.chatTableLayout.Size = new System.Drawing.Size(920, 235);
            this.chatTableLayout.TabIndex = 0;
            // 
            // chatTabControl
            // 
            this.chatTabControl.Controls.Add(this.serverChatTabPage);
            this.chatTabControl.Controls.Add(this.roomChatTabPage);
            this.chatTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTabControl.Location = new System.Drawing.Point(0, 0);
            this.chatTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.chatTabControl.Multiline = true;
            this.chatTabControl.Name = "chatTabControl";
            this.chatTabControl.SelectedIndex = 0;
            this.chatTabControl.Size = new System.Drawing.Size(920, 213);
            this.chatTabControl.TabIndex = 6;
            this.chatTabControl.SelectedIndexChanged += new System.EventHandler(this.chatTabControl_SelectedIndexChanged);
            // 
            // serverChatTabPage
            // 
            this.serverChatTabPage.Controls.Add(this.messageList);
            this.serverChatTabPage.Location = new System.Drawing.Point(4, 22);
            this.serverChatTabPage.Name = "serverChatTabPage";
            this.serverChatTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.serverChatTabPage.Size = new System.Drawing.Size(912, 187);
            this.serverChatTabPage.TabIndex = 0;
            this.serverChatTabPage.Text = "Server";
            this.serverChatTabPage.UseVisualStyleBackColor = true;
            // 
            // messageList
            // 
            this.messageList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.messageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageList.Location = new System.Drawing.Point(3, 3);
            this.messageList.Margin = new System.Windows.Forms.Padding(0);
            this.messageList.Name = "messageList";
            this.messageList.ReadOnly = true;
            this.messageList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.messageList.Size = new System.Drawing.Size(906, 181);
            this.messageList.TabIndex = 2;
            this.messageList.Text = "";
            // 
            // roomChatTabPage
            // 
            this.roomChatTabPage.Controls.Add(this.roomMessageList);
            this.roomChatTabPage.Location = new System.Drawing.Point(4, 22);
            this.roomChatTabPage.Name = "roomChatTabPage";
            this.roomChatTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomChatTabPage.Size = new System.Drawing.Size(912, 187);
            this.roomChatTabPage.TabIndex = 1;
            this.roomChatTabPage.Text = "roomChatTabPage";
            this.roomChatTabPage.UseVisualStyleBackColor = true;
            // 
            // roomMessageList
            // 
            this.roomMessageList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.roomMessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomMessageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomMessageList.Location = new System.Drawing.Point(3, 3);
            this.roomMessageList.Name = "roomMessageList";
            this.roomMessageList.ReadOnly = true;
            this.roomMessageList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.roomMessageList.Size = new System.Drawing.Size(906, 181);
            this.roomMessageList.TabIndex = 3;
            this.roomMessageList.Text = "";
            // 
            // messageTableLayout
            // 
            this.messageTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTableLayout.ColumnCount = 2;
            this.messageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.69072F));
            this.messageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.messageTableLayout.Controls.Add(this.messageTextBox, 0, 0);
            this.messageTableLayout.Controls.Add(this.sendMessageButton, 1, 0);
            this.messageTableLayout.Location = new System.Drawing.Point(0, 213);
            this.messageTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.messageTableLayout.MaximumSize = new System.Drawing.Size(0, 30);
            this.messageTableLayout.MinimumSize = new System.Drawing.Size(0, 30);
            this.messageTableLayout.Name = "messageTableLayout";
            this.messageTableLayout.RowCount = 1;
            this.messageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.messageTableLayout.Size = new System.Drawing.Size(920, 30);
            this.messageTableLayout.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(0, 0);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.messageTextBox.MaxLength = 100;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(825, 22);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyDown);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageButton.Location = new System.Drawing.Point(825, 0);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(0);
            this.sendMessageButton.MaximumSize = new System.Drawing.Size(0, 25);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(95, 25);
            this.sendMessageButton.TabIndex = 1;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // onlineUserList
            // 
            this.onlineUserList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.onlineUserList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onlineUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onlineUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userNameColumnHeader});
            this.onlineUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlineUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineUserList.FullRowSelect = true;
            this.onlineUserList.GridLines = true;
            this.onlineUserList.Location = new System.Drawing.Point(920, 0);
            this.onlineUserList.Margin = new System.Windows.Forms.Padding(0);
            this.onlineUserList.MultiSelect = false;
            this.onlineUserList.Name = "onlineUserList";
            this.onlineUserList.Size = new System.Drawing.Size(88, 684);
            this.onlineUserList.TabIndex = 0;
            this.onlineUserList.UseCompatibleStateImageBehavior = false;
            this.onlineUserList.View = System.Windows.Forms.View.List;
            // 
            // userNameColumnHeader
            // 
            this.userNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rootServerTableLayout);
            this.mainPanel.Controls.Add(this.rootConnectTableLayout);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(0, 24, 0, 22);
            this.mainPanel.Size = new System.Drawing.Size(1008, 730);
            this.mainPanel.TabIndex = 1;
            // 
            // LudoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LudoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ludo Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LudoForm_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.ludoForm_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.rootConnectTableLayout.ResumeLayout(false);
            this.connectTableLayout.ResumeLayout(false);
            this.connectTableLayout.PerformLayout();
            this.rootServerTableLayout.ResumeLayout(false);
            this.serverChatTableLayout.ResumeLayout(false);
            this.serverAndGamePanel.ResumeLayout(false);
            this.serverTableLayout.ResumeLayout(false);
            this.roomListAndLobbyPanel.ResumeLayout(false);
            this.roomControlsPanel.ResumeLayout(false);
            this.gameTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playGroundPicture)).EndInit();
            this.chatTableLayout.ResumeLayout(false);
            this.chatTabControl.ResumeLayout(false);
            this.serverChatTabPage.ResumeLayout(false);
            this.roomChatTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TableLayoutPanel rootConnectTableLayout;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TableLayoutPanel connectTableLayout;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.TableLayoutPanel rootServerTableLayout;
        private System.Windows.Forms.ListView onlineUserList;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel serverChatTableLayout;
        private System.Windows.Forms.ToolStripStatusLabel pingStatusLabel;
        private System.Windows.Forms.ColumnHeader userNameColumnHeader;
        private Panel serverAndGamePanel;
        private TableLayoutPanel serverTableLayout;
        private Panel roomListAndLobbyPanel;
        private ListView roomList;
        private ColumnHeader roomIDColumnHeader;
        private ColumnHeader roomNameColumnHeader;
        private ColumnHeader usersInRoomColumnHeader;
        private ColumnHeader roomStatusColumnHeader;
        private ListBox userInLobbyListBox;
        private Panel roomControlsPanel;
        private Button readyButton;
        private Button startButton;
        private Button joinButton;
        private Button backButton;
        private Button createRoomButton;
        private TableLayoutPanel chatTableLayout;
        private TabControl chatTabControl;
        private TabPage serverChatTabPage;
        private RichTextBox messageList;
        private TabPage roomChatTabPage;
        private RichTextBox roomMessageList;
        private TableLayoutPanel messageTableLayout;
        private TextBox messageTextBox;
        private Button sendMessageButton;
        private TableLayoutPanel gameTableLayout;
        private PictureBox playGroundPicture;
    }
}

