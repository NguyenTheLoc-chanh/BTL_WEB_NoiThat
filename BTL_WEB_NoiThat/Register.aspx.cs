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

            // check Email;
            if (checkEmailandSdt(nameRegis))
            {
                List<User> arrUser = (List<User>)Application[Global.LIST_USER];

                User us = new User();
                us.sNameRegister = nameRegis;
                us.sUserName = suserName;
                us.sPassRegister = pass;

                arrUser.Add(us);
                Application[Global.LIST_USER] = arrUser;
                Session[Global.USER_ID] = us.sNameRegister;
                Session[Global.USER_NAME] = us.sUserName;

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
            List<User> arrNameRegistered = Application[Global.LIST_USER] as List<User>;
            if(arrNameRegistered == null)
            {
                arrNameRegistered = new List<User>();
                Application[Global.LIST_USER] = arrNameRegistered;
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