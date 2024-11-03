using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat
{
    public class LoadOrder
    {
        public static string loadOrderDetail(List<Order> userOrders, List<Product> listProduct, List<CartItem> listCart)
        {
            string htmlOrderDetail = "";
            if(userOrders == null)
            {
                return "<p>Your cart is empty !<p>";
            }
            foreach (Order order in userOrders)
            {
                string orderId = order.SId;
                string cartId = order.SCartId;
                string status = order.SStatus;
                string orderType = order.SOrderType;
                DateTime dTimeOrder = order.DTimeOrder;
                var ids = listCart.Select(item => item.Id);
                CartItem cart = listCart.Find(item => item.Id == cartId);
                
                Dictionary<int, int> listProInCart = cart.ListProduct;

                if(listProduct == null)
                {
                    continue;
                }

                string infoProductItem = "";
                int index = 1;
                foreach(KeyValuePair<int, int> productItem in listProInCart)
                {
                    int productId = productItem.Key;
                    int quantity = productItem.Value;

                    Product pro = listProduct.Find(item => item.iID == productId);
                    if(pro == null)
                    {
                        continue;
                    }
                    string productName = pro.sNameProduct;
                    string productImg = pro.sImgProduct;
                    int productPrice = pro.iPriceProduct;
                    double totalPrice = (double)productPrice * quantity;
                    infoProductItem += $@"
                        <tr class=""order-row"">
                            <td>{index++}</td>
                            <td>
                                <div class=""product"">
                                    <img src='{productImg}' alt=""Product"">
                                    <div class=""product-info"">
                                        <h3 class=""product-name"">{productName}</h3>
                                        <p>Số lượng: {quantity}</p>
                                    </div>
                                </div>
                            </td>
                            <td>{totalPrice.ToString("N0")}đ</td>
                        </tr>";
                }

                string orderHtml = $@"
                <section class=""order-item"">
                <div class=""order-head"">
                    <h2 class=""title"">Đơn hàng #{orderId}</h2>
                    <a href=''>Chi tiết</a>
                </div>
                <div>
                    <table>
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Sản phẩm</th>
                                <th>Giá</th>
                            </tr>
                        </thead>
                    <tbody>
                        {infoProductItem}
                    </tbody>
                </table>
                </div>
            </section>";

                htmlOrderDetail += orderHtml;
            }
            if (htmlOrderDetail == "")
            {
                return "<p style='font-size: 24px; text-align: center; font-weight: bold; margin-bottom: 100px;'>Your cart is empty !<p>";
            }
            return htmlOrderDetail;
        }
    }
}