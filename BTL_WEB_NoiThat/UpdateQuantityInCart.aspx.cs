using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_NoiThat
{
    public partial class UpdateQuantityInCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(Request.QueryString["id"]);
            int productQuantity = Convert.ToInt32(Request.QueryString["quantity"]);

            int maxQuantity = 0;
            Product product = getProductById(productID);
            if (product != null)
            {
                maxQuantity = product.iStock;
                if (productQuantity > 0 && productQuantity <= maxQuantity)
                {
                    Dictionary<int, int> listProductCart = (Session[Global.YOUR_CART] as CartItem).ListProduct as Dictionary<int, int>;
                    if (listProductCart == null)
                    {
                        listProductCart = new Dictionary<int, int>();
                    }

                    if (listProductCart.ContainsKey(productID))
                    {
                        listProductCart[productID] = productQuantity;
                    }
                    else
                    {
                        listProductCart.Add(productID, productQuantity);
                    }
                    (Session[Global.YOUR_CART] as CartItem).ListProduct = listProductCart;

                    maxQuantity -= productQuantity;
                    product.iStock = maxQuantity;
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('Số lượng không hợp lệ!');</script>");
                }
                Response.Redirect("shoppingcart.aspx");
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