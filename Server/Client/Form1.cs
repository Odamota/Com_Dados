using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //bool isLogged = false;

        public void loadOlineUsers()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point locationsPoint = new Point(12,12);
           
            //check_userLogin
            pnl_Login.Visible = true;
            pnl_Login.Location = locationsPoint;

           

        }
    }
}
