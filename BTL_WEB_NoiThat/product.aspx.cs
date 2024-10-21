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
            List<Product> listProduct = (List<Product>)Application[Global.LIST_PRODUCT];
            string product = "";

            for(int i = 0; i < listProduct.Count; i++)
            {
                Product prod = (Product)listProduct[i];
                product += $@"
                            <div class=""col l-4 m-4 c-12"">
                                <div class=""card"">
                                    <a href=""detail.aspx?id={prod.iID}"" class=""card__link"">
                                        <img src=""{prod.sImgProduct}"" alt=""Bathroom Design"" />
                                        <div class=""card-content"">
                                            <h2>{prod.sNameProduct}</h2>
                                            <div class=""options-rating"">
                                                <span class=""options"">3 options</span>
                                                <div class=""rating"">
                                                    <span>3.7</span>
                                                    <i class=""fas fa-star""></i>
                                                    <i class=""fas fa-star""></i>
                                                    <i class=""fas fa-star""></i>
                                                    <i class=""fas fa-star-half-alt""></i>
                                                    <i class=""far fa-star""></i>
                                                </div>
                                            </div>
                                            <div class=""price"">
                                                <span>${prod.iPriceProduct}</span>
                                            </div>
                                            <div class=""icons"">
                                                <a href='AddPageProductToCarrt.aspx?id={prod.iID}&quantity={1}' class='cart__add' data-product-id='{prod.iID}'>
                                                   <i class=""fas fa-shopping-cart""></i>
                                                </a>
                                                <i class=""fas fa-heart""></i>
                                            </div>
                                        </div>
                                    </a>
                                </div>
                            </div>";
            }

            rowProduct.InnerHtml = product;
        }
    }

}