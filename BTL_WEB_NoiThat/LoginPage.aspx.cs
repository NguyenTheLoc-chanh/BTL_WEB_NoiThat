using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class LoginPage : System.Web.UI.Page
    {
        string userNameHome;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLoginClick(object seder, EventArgs e)
        {
            string sUserNameLogin = emailOrPhoneLogin.Value.Trim();
            string passWordLogin = passLogin.Value.Trim();

            List<User> arrUsers = (List<User>)Application[Global.LIST_USER];
            bool checkUserName = false;
            bool checkUser = false;

            if(arrUsers == null)
            {
                lbCheckPassLogin.Text = "Không có dữ liệu";
            }

            foreach (User us in arrUsers)
            {
                if (us.sNameRegister == sUserNameLogin && us.sPassRegister == passWordLogin)
                {
                    checkUser = true;
                    userNameHome = us.sUserName;
                    Session[Global.USER_NAME] = us.sUserName;
                    Session[Global.USER_ID] = us.sNameRegister;
                    break;
                }
                else if (us.sNameRegister == sUserNameLogin)
                {
                    checkUserName = true;
                }
            }
            if (checkUser == true)
            { 
                Response.Redirect("home.aspx");
            }
            else
            {
                if (checkUserName == true)
                {
                    lbCheckPassLogin.Text = "Sai mật khẩu vui lòng nhập lại!";
                }
                else
                {
                    lbCheckPassLogin.Text = "Tài khoản không tồn tài!";
                }
            }


        }
    }
}