using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int currNum = 0;
            List<CartItem> carts = (List<CartItem>)Application[Global.LIST_CART];
            CartItem currCart = (Session[Global.YOUR_CART] as CartItem);

            numberProduct.InnerHtml = "0";
            if (currCart.ListProduct != null && currCart.ListProduct.Count != 0)
            {
                numberProduct.InnerHtml = $"{currCart.ListProduct.Count()}";
            }

            // Giao diện khi đăng nhập và chưa đăng nhập
            if (Session[Global.USER_ID] == "" && Session[Global.USER_NAME] == "")
            {
                spanLogin.Style["display"] = "block"; // Ẩn nút Đăng nhập
                spanRegister.Style["display"] = "block"; // Ẩn nút Đăng ký
            }
            else
            {
                string userText = "<span class=\"header__navbar user name Logout\" id=\"idLogout\" onclick=\"logoutClick(); \" >Đăng xuất</span>" + Session[Global.USER_NAME].ToString();
                //userNameHomeLogin.InnerText = us.sUserName.ToString().Trim(); // Lấy tên người dùng
                userNameHomeLogin.InnerHtml = userText;
                spanLogin.Style["display"] = "none"; // Ẩn nút Đăng nhập
                spanRegister.Style["display"] = "none"; // Ẩn nút Đăng ký

                if (carts != null)
                {
                    (Session[Global.YOUR_CART] as CartItem).UserId = Session[Global.USER_ID].ToString();

                    foreach (CartItem cart in carts)
                    {
                        if (cart.UserId == Session[Global.USER_ID])
                        {
                            numberProduct.InnerHtml = $"{cart.ListProduct.Count()}";
                            Session[Global.YOUR_CART] = cart;
                            currCart = cart;

                            break;
                        }
                    }
                }
            }

            List<Product> listProduct = Application[Global.LIST_PRODUCT] as List<Product>;
            innerHtmlSpecial.InnerHtml = LoadData.loadSpecialProductHome(listProduct);

        }
    }
}