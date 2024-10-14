using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BTL_WEB_NoiThat.Classes;

namespace BTL_WEB_NoiThat
{
    public partial class product : System.Web.UI.Page
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
                    userNameHomeLogin.InnerText = us.sUserName.ToString().Trim(); // Lấy tên người dùng
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
    }
}