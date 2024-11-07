using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cập nhật số lượng
            List<CartItem> carts = (List<CartItem>)Application[Global.LIST_CART];
            CartItem currCart = (Session[Global.YOUR_CART] as CartItem);
            if (!IsPostBack)
            {
                //số lượng sản phẩm trong giỏ hàng
                int currNum = 0;
                numberProduct.InnerHtml = "0";
                if (currCart.ListProduct != null && currCart.ListProduct.Count != 0)
                {
                    numberProduct.InnerHtml = $"{currCart.ListProduct.Count()}";
                }
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

            List<Product> listProduct = new List<Product>();
            listProduct = (List<Product>)Application[Global.LIST_PRODUCT];

            Product detailPro = new Product();

            int id = Convert.ToInt32(Request.QueryString["id"]);
            string detailProduct = "";
            foreach (Product pro in listProduct)
            {
                if (pro.iID == id)
                {
                    detailPro = pro;
                    detailProduct += $@"
                    <div class=""product-container"">
                        <div class=""col l-6 m-6 c-12"">
                            <div class=""product-gallery"">
                                <div class=""main-image"">
                                    <img src=""{detailPro.sImgProduct}"" alt=""Bathroom Full 2023"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col l-6 m-6 c-12"">
                            <div class=""product-details"">
                                <div class=""thumbnail-gallery"">
                                    <img src=""{detailPro.sImgDetail1}"" alt=""Thumbnail 1"" />
                                    <img src=""{detailPro.sImgDetail2}"" alt=""Thumbnail 2"" />
                                    <img src=""{detailPro.sImgDetail3}"" alt=""Thumbnail 3"" />
                                </div>
                                <h1>B013 Bathroom full 2023</h1>
                                <p class=""description"">{detailPro.sInfoProduct}</p>
                                <div class=""price"">
                                    <span>${detailPro.iPriceProduct}</span>
                                    <a href=""#"" class=""voucher-link"">Get voucher 20%?</a>
                                </div>
                                <div class=""quantity-selector"">
                                    <span class=""quantity-selector-active"">1</span>
                                    <span>2</span>
                                    <span>3</span>
                                </div>
                                <button class=""order-button"">ORDER NOW</button>
                                
                            </div>
                        </div>
                    </div>";
                    break;
                }
            }
            rowDetailPro.InnerHtml = detailProduct;
        }
        public void addProductCart(Object sender, EventArgs e)
        {
            Control control = (Control)sender;
            int maxQuantity = 0;
            int quantity = 1;
            int productId = Convert.ToInt32(Request.QueryString["id"]);

            Product product = getProductById(productId); // Lấy sản phẩm từ ID
            if (product != null)
            {
                maxQuantity = product.iStock;
                if (quantity > 0 && quantity <= maxQuantity)
                {
                    Dictionary<int, int> listPro = (Session[Global.YOUR_CART] as CartItem).ListProduct as Dictionary<int, int>;
                    if (listPro == null)
                    {
                        listPro = new Dictionary<int, int>();
                    }

                    if (listPro.ContainsKey(productId))
                    {
                        listPro[productId] += quantity;
                    }
                    else
                    {
                        listPro.Add(productId, quantity);
                    }

                    (Session[Global.YOUR_CART] as CartItem).ListProduct = listPro;

                    maxQuantity -= quantity;
                    product.iStock = maxQuantity;
                }
                // Cập nhật số lượng
                CartItem currCart = (Session[Global.YOUR_CART] as CartItem);
                numberProduct.InnerHtml = $"{currCart.ListProduct.Count()}";
            }
            else
            {
                Response.Write("<script type='text/javascript'>alert('Số lượng không hợp lệ!');</script>");
            }
        }
        private Product getProductById(int productId)
        {
            List<Product> products = (List<Product>)Application[Global.LIST_PRODUCT];
            Product proCart = new Product();

            foreach (Product pro in products)
            {
                if (pro.iID == productId)
                {
                    proCart = pro;
                    break;
                }
            }
            return proCart;
        }
    }
}