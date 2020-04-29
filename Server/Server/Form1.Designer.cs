namespace Server
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.Emaillogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnl_UserPanel = new System.Windows.Forms.Panel();
            this.pnl_SideMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCommunications = new System.Windows.Forms.Panel();
            this.Btn_SendFile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SendMessage = new System.Windows.Forms.Button();
            this.tbTextToSend = new System.Windows.Forms.TextBox();
            this.ChatScreen = new System.Windows.Forms.TextBox();
            this.OnlineUsersList = new System.Windows.Forms.ListBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnConnectToSession = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbClientConnectPort = new System.Windows.Forms.TextBox();
            this.btnCancelConnection = new System.Windows.Forms.Button();
            this.tb_ClientConnectIp = new System.Windows.Forms.TextBox();
            this.btnfinishConnection = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.MyIpBox = new System.Windows.Forms.TextBox();
            this.btnStartConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Login.SuspendLayout();
            this.pnl_UserPanel.SuspendLayout();
            this.pnl_SideMenu.SuspendLayout();
            this.panelCommunications.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Login.Controls.Add(this.label2);
            this.pnl_Login.Controls.Add(this.label1);
            this.pnl_Login.Controls.Add(this.PasswordLogin);
            this.pnl_Login.Controls.Add(this.lblWelcome);
            this.pnl_Login.Controls.Add(this.Emaillogin);
            this.pnl_Login.Controls.Add(this.btnLogin);
            this.pnl_Login.Location = new System.Drawing.Point(1111, 50);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1318, 689);
            this.pnl_Login.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(209, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduza os seus dados para aceder à Plataforma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ainda não tem uma conta?";
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.Location = new System.Drawing.Point(267, 236);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(216, 20);
            this.PasswordLogin.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblWelcome.Location = new System.Drawing.Point(207, 62);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(355, 29);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Bem-Vindo ao College Central";
            // 
            // Emaillogin
            // 
            this.Emaillogin.Location = new System.Drawing.Point(267, 197);
            this.Emaillogin.Name = "Emaillogin";
            this.Emaillogin.Size = new System.Drawing.Size(216, 20);
            this.Emaillogin.TabIndex = 1;
            this.Emaillogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(267, 313);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(215, 25);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Iniciar Sessão";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnl_UserPanel
            // 
            this.pnl_UserPanel.Controls.Add(this.panelCommunications);
            this.pnl_UserPanel.Controls.Add(this.OnlineUsersList);
            this.pnl_UserPanel.Controls.Add(this.MainPanel);
            this.pnl_UserPanel.Controls.Add(this.label3);
            this.pnl_UserPanel.Location = new System.Drawing.Point(118, 31);
            this.pnl_UserPanel.Name = "pnl_UserPanel";
            this.pnl_UserPanel.Size = new System.Drawing.Size(782, 451);
            this.pnl_UserPanel.TabIndex = 1;
            // 
            // pnl_SideMenu
            // 
            this.pnl_SideMenu.Controls.Add(this.label4);
            this.pnl_SideMenu.Controls.Add(this.label5);
            this.pnl_SideMenu.Location = new System.Drawing.Point(12, 31);
            this.pnl_SideMenu.Name = "pnl_SideMenu";
            this.pnl_SideMenu.Size = new System.Drawing.Size(100, 451);
            this.pnl_SideMenu.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Versão Beta 0.3";
            // 
            // panelCommunications
            // 
            this.panelCommunications.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCommunications.Controls.Add(this.Btn_SendFile);
            this.panelCommunications.Controls.Add(this.button3);
            this.panelCommunications.Controls.Add(this.SendMessage);
            this.panelCommunications.Controls.Add(this.tbTextToSend);
            this.panelCommunications.Controls.Add(this.ChatScreen);
            this.panelCommunications.Location = new System.Drawing.Point(124, 183);
            this.panelCommunications.Name = "panelCommunications";
            this.panelCommunications.Size = new System.Drawing.Size(447, 246);
            this.panelCommunications.TabIndex = 9;
            // 
            // Btn_SendFile
            // 
            this.Btn_SendFile.Location = new System.Drawing.Point(259, 212);
            this.Btn_SendFile.Name = "Btn_SendFile";
            this.Btn_SendFile.Size = new System.Drawing.Size(52, 21);
            this.Btn_SendFile.TabIndex = 12;
            this.Btn_SendFile.Text = "Anexar";
            this.Btn_SendFile.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 21);
            this.button3.TabIndex = 11;
            this.button3.Text = "Partilhar Ecrã";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SendMessage
            // 
            this.SendMessage.Enabled = false;
            this.SendMessage.Location = new System.Drawing.Point(195, 213);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(58, 23);
            this.SendMessage.TabIndex = 10;
            this.SendMessage.Text = "Enviar";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // tbTextToSend
            // 
            this.tbTextToSend.Location = new System.Drawing.Point(31, 213);
            this.tbTextToSend.Name = "tbTextToSend";
            this.tbTextToSend.Size = new System.Drawing.Size(158, 20);
            this.tbTextToSend.TabIndex = 9;
            this.tbTextToSend.TextChanged += new System.EventHandler(this.tbTextToSend_TextChanged);
            // 
            // ChatScreen
            // 
            this.ChatScreen.Location = new System.Drawing.Point(31, 23);
            this.ChatScreen.Multiline = true;
            this.ChatScreen.Name = "ChatScreen";
            this.ChatScreen.Size = new System.Drawing.Size(280, 184);
            this.ChatScreen.TabIndex = 8;
            // 
            // OnlineUsersList
            // 
            this.OnlineUsersList.FormattingEnabled = true;
            this.OnlineUsersList.Location = new System.Drawing.Point(590, 123);
            this.OnlineUsersList.Name = "OnlineUsersList";
            this.OnlineUsersList.Size = new System.Drawing.Size(104, 186);
            this.OnlineUsersList.TabIndex = 7;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnConnectToSession);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.tbClientConnectPort);
            this.MainPanel.Controls.Add(this.btnCancelConnection);
            this.MainPanel.Controls.Add(this.tb_ClientConnectIp);
            this.MainPanel.Controls.Add(this.btnfinishConnection);
            this.MainPanel.Controls.Add(this.portBox);
            this.MainPanel.Controls.Add(this.MyIpBox);
            this.MainPanel.Controls.Add(this.btnStartConnection);
            this.MainPanel.Location = new System.Drawing.Point(124, 13);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(447, 155);
            this.MainPanel.TabIndex = 6;
            // 
            // btnConnectToSession
            // 
            this.btnConnectToSession.Location = new System.Drawing.Point(244, 74);
            this.btnConnectToSession.Name = "btnConnectToSession";
            this.btnConnectToSession.Size = new System.Drawing.Size(176, 23);
            this.btnConnectToSession.TabIndex = 13;
            this.btnConnectToSession.Text = "Iniciar Transmissão";
            this.btnConnectToSession.UseVisualStyleBackColor = true;
            this.btnConnectToSession.Click += new System.EventHandler(this.btnConnectToSession_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(223, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 113);
            this.panel2.TabIndex = 12;
            // 
            // tbClientConnectPort
            // 
            this.tbClientConnectPort.Location = new System.Drawing.Point(365, 48);
            this.tbClientConnectPort.Name = "tbClientConnectPort";
            this.tbClientConnectPort.Size = new System.Drawing.Size(55, 20);
            this.tbClientConnectPort.TabIndex = 11;
            // 
            // btnCancelConnection
            // 
            this.btnCancelConnection.Location = new System.Drawing.Point(244, 103);
            this.btnCancelConnection.Name = "btnCancelConnection";
            this.btnCancelConnection.Size = new System.Drawing.Size(176, 23);
            this.btnCancelConnection.TabIndex = 10;
            this.btnCancelConnection.Text = "Sair da Transmisão";
            this.btnCancelConnection.UseVisualStyleBackColor = true;
            // 
            // tb_ClientConnectIp
            // 
            this.tb_ClientConnectIp.Location = new System.Drawing.Point(244, 48);
            this.tb_ClientConnectIp.Name = "tb_ClientConnectIp";
            this.tb_ClientConnectIp.Size = new System.Drawing.Size(103, 20);
            this.tb_ClientConnectIp.TabIndex = 8;
            // 
            // btnfinishConnection
            // 
            this.btnfinishConnection.Location = new System.Drawing.Point(31, 103);
            this.btnfinishConnection.Name = "btnfinishConnection";
            this.btnfinishConnection.Size = new System.Drawing.Size(176, 23);
            this.btnfinishConnection.TabIndex = 7;
            this.btnfinishConnection.Text = "Terminar Transmissão";
            this.btnfinishConnection.UseVisualStyleBackColor = true;
            this.btnfinishConnection.Click += new System.EventHandler(this.btnfinishConnection_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(152, 48);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(55, 20);
            this.portBox.TabIndex = 6;
            // 
            // MyIpBox
            // 
            this.MyIpBox.Location = new System.Drawing.Point(31, 48);
            this.MyIpBox.Name = "MyIpBox";
            this.MyIpBox.Size = new System.Drawing.Size(103, 20);
            this.MyIpBox.TabIndex = 5;
            // 
            // btnStartConnection
            // 
            this.btnStartConnection.Location = new System.Drawing.Point(31, 74);
            this.btnStartConnection.Name = "btnStartConnection";
            this.btnStartConnection.Size = new System.Drawing.Size(176, 23);
            this.btnStartConnection.TabIndex = 4;
            this.btnStartConnection.Text = "Iniciar Transmissão";
            this.btnStartConnection.UseVisualStyleBackColor = true;
            this.btnStartConnection.Click += new System.EventHandler(this.btnStartConnection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Online";
            // 
            // profilePic
            // 
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(935, 12);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(63, 42);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Location = new System.Drawing.Point(932, 57);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(65, 13);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "Estudante A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conexões";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 716);
            this.Controls.Add(this.pnl_SideMenu);
            this.Controls.Add(this.pnl_UserPanel);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.welcomelbl);
            this.Name = "ServerForm";
            this.Text = "Bem-Vindo";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.pnl_UserPanel.ResumeLayout(false);
            this.pnl_UserPanel.PerformLayout();
            this.pnl_SideMenu.ResumeLayout(false);
            this.pnl_SideMenu.PerformLayout();
            this.panelCommunications.ResumeLayout(false);
            this.panelCommunications.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox Emaillogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnl_UserPanel;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox MyIpBox;
        private System.Windows.Forms.Button btnStartConnection;
        private System.Windows.Forms.ListBox OnlineUsersList;
        private System.Windows.Forms.Button btnfinishConnection;
        private System.Windows.Forms.Panel panelCommunications;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.TextBox tbTextToSend;
        private System.Windows.Forms.TextBox ChatScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_SendFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbClientConnectPort;
        private System.Windows.Forms.Button btnCancelConnection;
        private System.Windows.Forms.TextBox tb_ClientConnectIp;
        private System.Windows.Forms.Panel pnl_SideMenu;
        private System.Windows.Forms.Button btnConnectToSession;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
    }
}

