using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class LogoutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Chỉ loại bỏ session có tên Global.CUSTOMER_NAME
            Session.Remove(Global.USER_ID);
            Session.Remove(Global.USER_NAME);
            Session[Global.YOUR_CART] = new CartItem("cart-" + (Application[Global.LIST_CART] as List<CartItem>));

            // Hoặc có thể đặt session về null
            Response.Redirect("LoginPage.aspx");
        }
    }
}