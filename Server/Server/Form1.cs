using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }
        Point locationsPoint = new Point(0, 0);
        public string userIP;
        bool isLogged = false;
        User UserData = new User();
        ServerController newSession = new ServerController();
        public void loadLoginPanel()
        {
            pnl_Login.Visible = true;
            pnl_Login.Location = locationsPoint;
            pnl_UserPanel.Visible = false;

        }
        private void ServerForm_Load(object sender, EventArgs e)
        {

            //check_userLogin
            loadLoginPanel();

            Emaillogin.Text = "develop-team@buedecenas.com";
            PasswordLogin.Text = "buedecenas2019";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        public void changePanelsLoggin()
        {
            pnl_Login.Visible = false;
            pnl_UserPanel.Location = locationsPoint;
            pnl_UserPanel.Visible = true;
            MainPanel.Visible = true;


        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserData = new User(Emaillogin.Text, PasswordLogin.Text);
           
           
            if(UserData.isLogged)
            {
                isLogged = true;
                changePanelsLoggin();
                userIP = GetLocalIPAddress();
                MyIpBox.Text = userIP;
                welcomelbl.Text = UserData.userName;
                OnlineUsersList.Items.Add(UserData.userName);
                //load panel for users
                //load disciplinas em que o aluno está inscrito
                /*
                 * Cada Disciplina irá estar associada ao IP de um Professor e a porta.
                 * 
                 */
            }
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get Selected name 
            //send message to user

        }

        private void btnStartConnection_Click(object sender, EventArgs e)
        {
            
            if(portBox.Text != "" && MyIpBox.Text !="")
            { 
            int port = Convert.ToInt32(portBox.Text);
            newSession.Start( port );
               // backgroundWorker1.RunWorkerAsync();

                MessageBox.Show("Conexão iniciada com Sucesso");
                ChatScreen.AppendText("Conectado a " + MyIpBox.Text + "na porta " + port + "...\n" );

                panelCommunications.Visible = true;
         //  Server newServer = new 
            }
            else
            {
                MessageBox.Show("Preencha os campos com o seu ip e a porta desejada.");
            }
        }

        private void tbTextToSend_TextChanged(object sender, EventArgs e)
        {
            SendMessage.Enabled = true;
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            
            //envia para o ecrã
            ChatScreen.AppendText("\n" +UserData.userName+ ":" + SendMessage.Text +"\n"  );
            newSession.sendMessage(MyIpBox.Text, Convert.ToInt32(portBox.Text), tbTextToSend.Text);


            MessageBox.Show("Mensagem Enviada p/ servidor");

        }

        private void btnConnectToSession_Click(object sender, EventArgs e)
        {
            if(tb_ClientConnectIp.Text != "" && tbClientConnectPort.Text != "")
            {
                ChatScreen.Clear();
                tbTextToSend.Clear();
                tbTextToSend.Focus();



                //check if is connected
                btnCancelConnection.Enabled = true;
                //connectar a um ip e porta definidos
                
                
                //newSession.UserConnectsToClass(tb_ClientConnectIp.Text, Convert.ToInt32(tbClientConnectPort.Text));


            }

        }

        private void btnfinishConnection_Click(object sender, EventArgs e)
        {
            try{ 
            int porta = Convert.ToInt32(portBox.Text);
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
