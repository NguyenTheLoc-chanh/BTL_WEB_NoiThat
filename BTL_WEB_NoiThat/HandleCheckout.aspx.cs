using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class HandleCheckout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Form["name"];
            string phone = Request.Form["phone"];
            string email = Request.Form["email"];
            string address = Request.Form["address"];
            string city = Request.Form["city"];
            string district = Request.Form["district"];
            string ward = Request.Form["ward"];
            string paymentMethod = Request.Form["payment"];

            
            Session["CheckoutInfo"] = new checkoutInfo(name, email, phone, address, city, district, ward, paymentMethod);
            
            // Khi user hoàn tất đơn hàng thì kiểm tra xem user đã đăng nhập hay chưa nếu chưa thì cần yêu cầu user Login
            bool checkUserLogin = false;
            List<User> users = Application[Global.LIST_USER] as List<User>;
            foreach(User user in users)
            {
                if(user.sNameRegister == Session[Global.USER_ID].ToString())
                {
                    checkUserLogin = true;
                    break;
                }
            }
            if (checkUserLogin && Session[Global.USER_ID] !=null && Session[Global.USER_ID].ToString() != "")
            {
                CartItem currentCart = Session[Global.YOUR_CART] as CartItem;
                List<CartItem> carts = (List<CartItem>)Application[Global.LIST_CART];

                bool checkCartExist = false;
                foreach (CartItem cart in carts)
                {
                    if (cart.Id == currentCart.Id)
                    {
                        checkCartExist = true;
                        break;
                    }
                }
                if (checkCartExist)
                {
                    currentCart.Id = "cart-" + (carts.Count + 1);
                }
                currentCart.WasOrder = true;
                carts.Add(currentCart);

                // Thêmm đơn hàng vào danh sách đơn hàng;
                List<Order> orders = Application[Global.LIST_ORDER] as List<Order>;
                Order order = new Order("order-item-" + (orders.Count + 1), Session[Global.USER_ID].ToString(), currentCart.Id, "pending", paymentMethod, DateTime.Now, Session["CheckoutInfo"] as checkoutInfo);

                orders.Add(order);
                Application[Global.LIST_ORDER] = orders;

                // Reset Giỏ hàng
                Session.Remove(Global.YOUR_CART);
                Session[Global.YOUR_CART] = new CartItem("cart-" + ((Application[Global.LIST_CART] as List<CartItem>).Count + 1));

                Response.Redirect("DetailOrder.aspx");
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
            Response.Redirect("checkout.aspx");
        }
    }
}