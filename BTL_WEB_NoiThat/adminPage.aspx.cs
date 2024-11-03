using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class adminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowProductList(sender,e);
                ShowUserList(sender,e);
            }
            // Kiểm tra có yêu cầu xóa người dùng không
            string idUserDelete = Request.QueryString["deleteId_User"];
            if (!String.IsNullOrEmpty(idUserDelete))
            {
                DeleteUser(idUserDelete);
                ShowUserList(sender, e);

                Response.Redirect("adminPage.aspx?currentTab=users");
            }

            // Kiểm tra có yêu cầu xóa Sản phẩm không
            string idProductDelete = Request.QueryString["deleteId"];
            if (!String.IsNullOrEmpty(idProductDelete))
            {
                int id = Convert.ToInt32(idProductDelete);
                DeleteProduct(id);
                ShowProductList(sender, e);

                Response.Redirect("adminPage.aspx?currentTab=products");
            }
            // Xử lý thêm người dùng
            string actionUser = Request.Form["action"];
            if(actionUser == "addUser")
            {
                AddUser(sender, e);
                ShowUserList(sender,e);
                Response.Redirect("adminPage.aspx?currentTab=users");
            }else if(actionUser == "editUser")
            {
                EditUser();
                ShowUserList(sender, e);
                Response.Redirect("adminPage.aspx?currentTab=users");
            }

            // Xử lý thêm sản phẩm
            string actionProduct = Request.Form["action"];
            if(actionProduct == "addProduct")
            {
                AddProduct(sender, e);
                ShowProductList(sender, e);
                Response.Redirect("adminPage.aspx?currentTab=products");
            }
            else if(actionProduct == "editProduct")
            {
                EditProduct(sender, e);
                ShowProductList(sender,e);
                Response.Redirect("adminPage.aspx?currentTab=products");
            }
        }
        private void ShowProductList(Object sender, EventArgs e)
        {
            // Lấy ra danh sách sản phẩm từ Application
            List<Product> listProduct = Application[Global.LIST_PRODUCT] as List<Product>;

            string productHtml = "";
            if(listProduct != null && listProduct.Count > 0)
            {
                foreach(Product pro in listProduct)
                {
                    productHtml += "<tr>";
                    productHtml += $"<td>{pro.iID}</td>";
                    productHtml += $"<td>{pro.sNameProduct}</td>";
                    productHtml += $"<td>{pro.iPriceProduct.ToString("N0")} $</td>";
                    productHtml += $"<td>{pro.iStock}</td>";
                    productHtml += $"<td>{pro.sInfoProduct}</td>";
                    productHtml += $"<td><img src='{pro.sImgProduct}' alt='{pro.sNameProduct}' width='50' height='50' /></td>";
                    productHtml += "<td>";
                    productHtml += $"<img src='{pro.sImgDetail1}' alt='product image' width='50' height='50' />";
                    productHtml += $"<img src='{pro.sImgDetail2}' alt='product image' width='50' height='50' />";
                    productHtml += $"<img src='{pro.sImgDetail3}' alt='product image' width='50' height='50' />";
                    productHtml += "</td>";
                    productHtml += "<td>";
                    productHtml += $"<button class='btn' onclick=\"editProduct('{pro.iID}', '{pro.sNameProduct}', '{pro.iPriceProduct}', '{pro.iStock}', '{pro.sInfoProduct}', '{pro.sImgProduct}','{pro.sImgDetail1}', '{pro.sImgDetail2}','{pro.sImgDetail3}')\">Sửa</button>";
                    productHtml += $"<button class='btn' onclick=\"deleteProduct('{pro.iID}')\">Xóa</button>";
                    productHtml += "</td>";
                    productHtml += "</tr>";
                }
            }
            else
            {
                productHtml = "<tr><td colspan='12'>Không có sản phẩm nào</td></tr>";
            }
            // Đưa HTML vào trong table body trên giao diện
            productTableBody.InnerHtml = productHtml;
        }

        private void AddProduct(Object sender, EventArgs e)
        {
            int idProduct = Convert.ToInt32(Request.Form["productId"]);
            string nameProduct = Request.Form["productName"];
            int priceProduct = Convert.ToInt32(Request.Form["price"]);
            int stockProduct = Convert.ToInt32(Request.Form["stock"]);
            string descProduct = Request.Form["description"];
            string imgProduct = Request.Form["imageUrl"];
            string listDetailImg = Request.Form["listThumb"];
            string[] part = listDetailImg.Split(new[] { "," }, StringSplitOptions.None);
            string imgDetail1 = part[0];
            string imgDetail2 = part[1];
            string imgDetail3 = part[2];

            List<Product> listProduct = Application[Global.LIST_PRODUCT] as List<Product> ?? new List<Product>();

            Product pro = new Product(idProduct, nameProduct, imgProduct, priceProduct, descProduct, imgDetail1, imgDetail2, imgDetail3, stockProduct);
            if(listProduct != null)
            {
                listProduct.Add(pro);
                Application[Global.LIST_PRODUCT] = listProduct;
            }
        }

        private void EditProduct(Object sender, EventArgs e)
        {
            int idPro = Convert.ToInt32(Request.Form["productId"]);
            string namePro = Request.Form["productName"];
            string imgPro = Request.Form["imageUrl"];
            int pricePro = Convert.ToInt32(Request.Form["price"]);
            int stockPro = Convert.ToInt32(Request.Form["stock"]);
            string desPro = Request.Form["description"];
            string listDetailImg = Request.Form["listThumb"];
            string[] part = listDetailImg.Split(new[] { "," }, StringSplitOptions.None);
            string imgDetail1 = part[0];
            string imgDetail2 = part[1];
            string imgDetail3 = part[2];

            List<Product> listProduct = Application[Global.LIST_PRODUCT] as List<Product>;
            if(listProduct != null)
            {
                var product = listProduct.FirstOrDefault(pro => pro.iID == idPro);
                if(product != null)
                {
                    product.sNameProduct = namePro;
                    product.sImgProduct = imgPro;
                    product.iPriceProduct = pricePro;
                    product.iStock = stockPro;
                    product.sInfoProduct = desPro;
                    product.sImgDetail1 = imgDetail1;
                    product.sImgDetail2 = imgDetail2;
                    product.sImgDetail3 = imgDetail3;

                    Application[Global.LIST_PRODUCT] = listProduct;
                }
            }
        }

        private void DeleteProduct(int id)
        {
            List<Product> listProduct = Application[Global.LIST_PRODUCT] as List<Product>;

            if(listProduct != null)
            {
                var productDelete = listProduct.FirstOrDefault(pro => pro.iID == id);

                if(productDelete != null)
                {
                    listProduct.Remove(productDelete);

                    Application[Global.LIST_PRODUCT] = listProduct;
                }
            }
        }
        private void ShowUserList(Object sender, EventArgs e)
        {
            // Lấy ra danh sách sản phẩm từ Application
            List<User> listUser = Application[Global.LIST_USER] as List<User>;

            string userHtml = "";
            if (listUser != null && listUser.Count > 0)
            {
                foreach (User us in listUser)
                {
                    userHtml += "<tr>";
                    userHtml += $"<td>{us.sUserName}</td>";
                    userHtml += $"<td>{us.sNameRegister}</td>";
                    userHtml += $"<td>{us.sPassRegister}</td>";
                    userHtml += "<td>";
                    userHtml += $"<button class='btn' onclick=\"editUser('{us.sNameRegister}', '{us.sUserName}', '{us.sPassRegister}')\">Sửa</button>";
                    userHtml += $"<button class='btn' onclick=\"deleteUser('{us.sNameRegister}')\">Xóa</button>";
                    userHtml += "</td>";
                    userHtml += "</tr>";
                }
            }
            else
            {
                userHtml = "<tr><td colspan='6'>Không có người dùng nào</td></tr>";
            }
            // Đưa HTML vào trong table body trên giao diện
            userTableBody.InnerHtml = userHtml;
        }

        private void AddUser(Object sender, EventArgs e)
        {
            string fullName = Request.Form["username"];
            string nameRegister = Request.Form["nameRegister"];
            string password = Request.Form["password"];

            User user = new User(nameRegister, fullName, password);

            List<User> listUser = Application[Global.LIST_USER] as List<User>;
            if(user != null)
            {
                listUser.Add(user);
                Application[Global.LIST_USER] = listUser;
            }
        }

        private void EditUser()
        {
            // Lấy thông tin từ form
            string fullName = Request.Form["fullName"];
            string nameRegister = Request.Form["userId"];
            string password = Request.Form["password"];

            // Sửa thông tin người dùng
            List<User> users = Application[Global.LIST_USER] as List<User>;
            if (users != null)
            {
                var user = users.FirstOrDefault(u => u.sNameRegister == nameRegister);
                if (user != null)
                {
                    user.sUserName = fullName;
                    user.sNameRegister = nameRegister;
                    user.sPassRegister = password;
                    Application[Global.LIST_USER] = users; // Cập nhật danh sách người dùng
                }
            }
        }

        private void DeleteUser(string idUser)
        {
            List<User> users = Application[Global.LIST_USER] as List<User>;
            if(users != null)
            {
                var userDelete = users.FirstOrDefault(us => us.sNameRegister == idUser);
                if(userDelete != null)
                {
                    users.Remove(userDelete);

                    Application[Global.LIST_USER] = users;
                }
            }
        }
    }
}