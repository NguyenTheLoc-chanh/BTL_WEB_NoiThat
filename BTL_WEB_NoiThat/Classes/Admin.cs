using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat.Classes
{
    public class Admin
    {
        private string username;
        private string password;

        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string SUserName { get => username; set => password = value; }
        public string SPassWord { get => password; set => password = value; }
    }
}