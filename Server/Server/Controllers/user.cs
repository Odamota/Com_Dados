using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Server
{
    class User
    {

        public string userid;
        public string userEmail;
        public string userPassword;
        public string userAvatar;
        public string userType;
        public string userName;
        public bool isLogged;

        List<string> onlineUsers = new List<string>();
      

        public User()
        {

        }
        public User(string UEmail, string uPass)
        {
           isLogged =  newconnection(UEmail, uPass);
            
            if(isLogged)
            {
                onlineUsers.Add(userName);
            }

        }


        public User(string UId, string uName, string UEmail, string uPass, string uAvatarPath, string uType)
        {
            userid = UId;
            userEmail = UEmail.Trim().ToLower();
            userPassword = uPass;
            userAvatar = uAvatarPath;
            userType = uType;
            userName = uName;

        }

        public bool newconnection(string email, string password)
        {

            MySqlConnection MysqlConn = new MySqlConnection();

            MysqlConn.ConnectionString = "SERVER = lhcp3020.webapps.net; PORT = 3306; DATABASE=x23l1u4r_server;UID =x23l1u4r_develop;PASSWORD=buedecenas2020!";

            MysqlConn.Open();

            var query = "SELECT * FROM users WHERE email = '" + email + "' and pass='" + password + "' ";

            var comand = new MySqlCommand(query, MysqlConn);

            MySqlDataReader result = comand.ExecuteReader();

            bool exists = false;

            if(result.Read())
            {
                exists = true;
                userid = result.GetString(0);
                userEmail = result.GetString(1).ToString();
                userPassword = result.GetString(2).ToString();
                userName = result.GetString(3);
                userType = result.GetString(4);
                userAvatar = result.GetString(7).ToString();

                //load form user or professors


            }

            return exists;


        }
    }


    }

