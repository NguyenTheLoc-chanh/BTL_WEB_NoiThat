using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["user"] == null)
           {
                spanLogin.Style["display"] = "block"; // Ẩn nút Đăng nhập
                spanRegister.Style["display"] = "block"; // Ẩn nút Đăng ký
           }
           else
                {
                // Kiểm tra kiểu của đối tượng trong Session
                if (Session["User"] is User us)
                {
                    string userText = "<span class=\"header__navbar user name Logout\" id=\"idLogout\" onclick=\"logoutClick(); \" >Đăng xuất</span>" + us.sUserName.ToString().Trim();
                    userNameHomeLogin.InnerHtml = userText; // Lấy tên người dùng
                    spanLogin.Style["display"] = "none"; // Ẩn nút Đăng nhập
                    spanRegister.Style["display"] = "none"; // Ẩn nút Đăng ký
                }
                else
                {
                    // Xử lý nếu đối tượng không phải là User
                    // Ví dụ: xóa Session hoặc ghi log
                    Session.Remove("User");
                    Response.Redirect("LoginPage.aspx"); // Hoặc một hành động khác
                }
           }
        }
        /*protected void logoutClickServer(Object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            // Chuyển hướng về trang đăng nhập
            Response.Redirect("home.aspx");
        }*/
    }
}