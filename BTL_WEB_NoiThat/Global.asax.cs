using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_WEB_NoiThat
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["users"] = new List<User>();

            List<User> listUser = new List<User>();
            listUser.Add(new User("0123456789","Nguyễn Văn Nam","abc@12345"));
            listUser.Add(new User("tuan@gmail.com", "Nguyễn Văn Tuấn", "abc@12345"));
            Application["users"] = listUser;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["User"] = new User();
            Session["user"] = null;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}