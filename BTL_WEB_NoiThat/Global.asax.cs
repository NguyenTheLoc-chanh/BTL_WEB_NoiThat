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
        public const string LIST_COUPON = "LIST_COUPON";
        public const string LIST_ORDER = "LIST_ORDER";

        public const string LIST_ADMIN = "LIST_ADMIN";
        protected void Application_Start(object sender, EventArgs e)
        {
            Application[Global.LIST_USER] = new List<User>();

            List<User> listUser = new List<User>();
            // Sử dụng phần cmt khi cần
            //listUser.Add(new User("0123456789", "Nguyễn Thế Lộc", "abc@12345", "ABC12"));
            // listUser.Add(new User("tuan@gmail.com", "Nguyễn Văn Tuấn", "abc@12345", "AD123"));

            listUser.Add(new User("0123456789","Nguyễn Thế Lộc","abc@12345"));
            listUser.Add(new User("tuan@gmail.com", "Nguyễn Văn Tuấn", "abc@12345"));
            Application[Global.LIST_USER] = listUser;

            // Khởi tạo danh sách sản phẩm
            Application[Global.LIST_PRODUCT] = new List<Product>();

            List<Product> listProduct = new List<Product>();
            listProduct.Add(new Product(1, "B013 Bathroom full 2023", "./assets/img/product1.jpg", 674, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg",20));
            listProduct.Add(new Product(2, "B023 Bathroom full 2023", "./assets/img/product2.png", 700, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 20));
            listProduct.Add(new Product(3, "B001 Bathroom Luxury 2022", "./assets/img/product3.png", 654, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 10));
            listProduct.Add(new Product(4, "K056 Kitchen Option", "./assets/img/product4.png", 600, "Kitchen interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(5, "W013 Workspace Decoration Full", "./assets/img/product5.png", 942, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(6, "L091 Livingroom Full 2020", "./assets/img/product6.png", 125, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(7, "Dinning room Full", "./assets/img/product7.png", 146, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(8, "W013 Workspace Decoration Full", "./assets/img/product5.png", 174, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(9, "Special Wood Full", "./assets/img/special_product.png", 1000, "A wooden dining set comprises a table and chairs crafted from wood, adding a warm touch to living or working spaces. With diverse designs ranging from modern to classic, these sets combine the natural beauty and durability of wood, enhancing both aesthetics and functionality...", "./assets/img/special_product.png", "./assets/img/special_product.png", "./assets/img/special_product.png", 5));
            listProduct.Add(new Product(10, "Special Wood Full", "./assets/img/special_product.png", 999, "A wooden dining set comprises a table and chairs crafted from wood, adding a warm touch to living or working spaces. With diverse designs ranging from modern to classic, these sets combine the natural beauty and durability of wood, enhancing both aesthetics and functionality...", "./assets/img/special_product.png", "./assets/img/special_product.png", "./assets/img/special_product.png", 5));
            listProduct.Add(new Product(11, "Special Wood Full", "./assets/img/special_product.png", 999, "A wooden dining set comprises a table and chairs crafted from wood, adding a warm touch to living or working spaces. With diverse designs ranging from modern to classic, these sets combine the natural beauty and durability of wood, enhancing both aesthetics and functionality...", "./assets/img/special_product.png", "./assets/img/special_product.png", "./assets/img/special_product.png", 5));
            listProduct.Add(new Product(12, "Dinning room Full", "./assets/img/product7.png", 146, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(13, "Dinning room Full", "./assets/img/product7.png", 146, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(14, "Dinning room Full", "./assets/img/product7.png", 146, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(15, "W013 Workspace Decoration Full", "./assets/img/product5.png", 174, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(16, "W013 Workspace Decoration Full", "./assets/img/product5.png", 174, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(17, "W013 Workspace Decoration Full", "./assets/img/product5.png", 174, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(18, "W013 Workspace Decoration Full", "./assets/img/product5.png", 174, "Bathroom interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(19, "K056 Kitchen Option", "./assets/img/product4.png", 600, "Kitchen interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(20, "K056 Kitchen Option", "./assets/img/product4.png", 600, "Kitchen interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(21, "K056 Kitchen Option", "./assets/img/product4.png", 600, "Kitchen interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(22, "K056 Kitchen Option", "./assets/img/product4.png", 600, "Kitchen interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(23, "K056 Bedroom Option", "./assets/img/img1.png", 600, "Kitchen interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(24, "K056 Bedroom Option", "./assets/img/img2.png", 600, "Kitchen interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));
            listProduct.Add(new Product(25, "K056 Bedroom Option", "./assets/img/product6.png", 600, "Kitchen interiors seamlessly marry function, integrating chic vanities, efficient storage, and stylish fixtures. Whether boasting a modern, minimalistic vibe or exuding classic charm, the design prioritizes comfort and visual allure, catering to daily needs with flair.", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", "./assets/img/detail2.jpg", 30));

            Application[Global.LIST_PRODUCT] = listProduct;

            //Giỏ hàng
            Application[Global.LIST_CART] = new List<CartItem>
            {
                new CartItem("cart-1", new Dictionary<int, int> { { 1, 2 } }, "0123456789"),
            };

            Application[Global.LIST_COUPON] = new List<Coupon>
            {
                new Coupon("CN14EX", "Discount 50% for loyal customer !", 50, DateTime.Now.AddDays(30)),
                new Coupon("PK45AL", "Discount 10% for loyal customer !", 10, DateTime.Now.AddDays(10)),
                new Coupon("THDTN", "Discount 20% for loyal customer !", 20, DateTime.Now.AddDays(20)),
            };

            Application[Global.LIST_ORDER] = new List<Order>
            {
                new Order("order-item-1","0123456789", "cart-1","pending", "online", DateTime.Now, new checkoutInfo(
                    "Nguyễn Thế Lộc", "nguyenthienthan6@gmail.com", "0123456789","Số 87 Ngõ 337", "Hà Nội", "Hai Bà Trưng", "Vĩnh Tuy", "online"
                )),
            };

            // Admin list
            Application[Global.LIST_ADMIN] = new List<Admin> 
            {
                new Admin("admin","admin@12345"),
                new Admin("nguyentheloc","nguyentheloc@12345")
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