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
        public const string LIST_USER = "LIST_INFO_CUSTOMER";
        public const string LIST_PRODUCT = "LIST_PRODUCT";
        public const string LIST_CART = "LIST_CART";
        public const string USER_NAME = "USER_NAME";
        public const string YOUR_CART = "YOUR_CART";
        public const string USER_ID = "USER_ID";
        protected void Application_Start(object sender, EventArgs e)
        {
            Application[Global.LIST_USER] = new List<User>();

            List<User> listUser = new List<User>();
            listUser.Add(new User("0123456789","Nguyễn Văn Nam","abc@12345"));
            listUser.Add(new User("tuan@gmail.com", "Nguyễn Văn Tuấn", "abc@12345"));
            Application[Global.LIST_USER] = listUser;

            // Khởi tạo danh sách sản phẩm
            Application[Global.LIST_PRODUCT] = new List<Product>();

            List<Product> listProduct = new List<Product>();
            listProduct.Add(new Product(1, "B013 Bathroom full 2023", "./assets/img/product1.jpg", 674, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg",20));
            listProduct.Add(new Product(2, "B013 Bathroom full 2023", "./assets/img/product2.png", 700,"","","","",20));
            listProduct.Add(new Product(3, "B013 Bathroom full 2023", "./assets/img/product3.png", 654,"","","","",10));
            listProduct.Add(new Product(4, "B013 Bathroom full 2023", "./assets/img/product4.png", 600,"", "", "", "",30));
            listProduct.Add(new Product(5, "B013 Bathroom full 2023", "./assets/img/product5.png", 942,"", "", "", "",30));
            listProduct.Add(new Product(6, "B013 Bathroom full 2023", "./assets/img/product6.png", 125,"", "", "", "",30));
            listProduct.Add(new Product(7, "B013 Bathroom full 2023", "./assets/img/product7.png", 146,"", "", "", "",30));
            listProduct.Add(new Product(8, "B013 Bathroom full 2023", "./assets/img/product5.png", 174,"", "", "", "",30));
            Application[Global.LIST_PRODUCT] = listProduct;

            //Giỏ hàng
            Application[Global.LIST_CART] = new List<CartItem>
            {
                new CartItem("cart-1", new Dictionary<int, int> { { 1, 2 } }, "0123456789"),
            };
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session[Global.YOUR_CART] = new CartItem("cart-" + (Application[Global.LIST_CART] as List<CartItem>).Count());
            Session[Global.USER_NAME] = "";
            Session[Global.USER_ID] = "";
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