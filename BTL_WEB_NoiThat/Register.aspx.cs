using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegisterClick(object seder, EventArgs e)
        {
            string nameRegis = emailOrPhone.Value.Trim();
            string suserName = userName.Value.Trim();
            string pass = passWordRes.Value.Trim();
            string passAgain = passWordResA.Value.Trim();

            // check Email;
            if (checkEmailandSdt(nameRegis))
            {
                List<User> arrUser = (List<User>)Application["users"];

                User us = new User();
                us.sNameRegister = nameRegis;
                us.sUserName = suserName;
                us.sPassRegister = pass;

                arrUser.Add(us);
                Application["users"] = arrUser;
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                lbCheckEmailOrP.Text = "Email hoặc số điện thoại đã tồn tại!";
            }
        }
        private bool checkEmailandSdt(string nameRegister)
        {
            bool check = true;
            List<User> arrNameRegistered = Application["users"] as List<User>;
            if(arrNameRegistered == null)
            {
                arrNameRegistered = new List<User>();
                Application["users"] = arrNameRegistered;
            }
            foreach (User us in arrNameRegistered)
            {
                if (us.sNameRegister.ToString().CompareTo(nameRegister) == 0)
                {
                    check = false;
                }
            }
            return check;
        }
    }
}