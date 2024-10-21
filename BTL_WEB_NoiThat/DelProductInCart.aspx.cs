using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class DelProductInCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int idProductDel = Convert.ToInt32(Request.QueryString["id"]);
                int quantity = int.Parse(Request.QueryString["quantity"]);
                CartItem carts = Session[Global.YOUR_CART] as CartItem;
                Dictionary<int, int> listProduct = carts.ListProduct as Dictionary<int, int>;
                listProduct.Remove(idProductDel);
                // Cập nhật cart
                carts.ListProduct = listProduct;
                // Update Session[YOUR_CART]
                Session[Global.YOUR_CART] = carts;

                List<Product> products = Application[Global.LIST_PRODUCT] as List<Product>;
                foreach (Product product in products)
                {
                    if (product.iID == idProductDel)
                    {
                        product.iStock += quantity;
                        break;
                    }
                }
                Application[Global.LIST_PRODUCT] = products;
            }
            catch
            {
                Response.Write("Error");
            }
            Response.Redirect("shoppingcart.aspx");
        }
    }
}