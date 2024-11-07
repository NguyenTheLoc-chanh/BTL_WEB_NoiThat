using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using BTL_WEB_NoiThat.Classes;

namespace BTL_WEB_NoiThat
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Số lượng sản phẩm trong giỏ
            List<CartItem> carts = (List<CartItem>) Application[Global.LIST_CART];
            int currNum = 0;
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

            //Load Sản phẩm
            if (!IsPostBack)
            {
                List<Product> listProduct = (List<Product>)Application[Global.LIST_PRODUCT];

                rowProduct.InnerHtml = LoadData.loadProduct(listProduct);
            }
        }
        protected void LinkButton_Click(object sender, EventArgs e)
        {
            LinkButton clickedButton = sender as LinkButton;
            string category = clickedButton.CommandArgument;

            DisplayProducts(category);
        }

        private void DisplayProducts(string category)
        {
            List<Product> listProduct = (List<Product>)Application[Global.LIST_PRODUCT];

            switch (category)
            {
                case "all":
                    rowProduct.InnerHtml = LoadData.loadProduct(listProduct);
                    break;
                case "bathroom":
                    rowProduct.InnerHtml = LoadData.loadProductFilter("Bathroom", listProduct);
                    break;
                case "bedroom":
                    rowProduct.InnerHtml = LoadData.loadProductFilter("Bedroom", listProduct);
                    break;
                case "livingroom":
                    rowProduct.InnerHtml = LoadData.loadProductFilter("Livingroom", listProduct);
                    break;
                case "workspace":
                    rowProduct.InnerHtml = LoadData.loadProductFilter("Workspace", listProduct);
                    break;
                case "diningroom":
                    rowProduct.InnerHtml = LoadData.loadProductFilter("Dining room", listProduct);
                    break;
                case "meetingroom":
                    rowProduct.InnerHtml = LoadData.loadProductFilter("Meetingroom", listProduct);
                    break;
                case "kitchen":
                    rowProduct.InnerHtml = LoadData.loadProductFilter("Kitchen", listProduct);
                    break;
            }
        }
    }

}