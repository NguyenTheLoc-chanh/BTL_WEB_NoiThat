using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat
{
    public class LoadData
    {
        public static string loadDataCart(CartItem cart, List<Product> products)
        {
            int numOfProduct = 0;
            Dictionary<int, int> list = cart.ListProduct;
            string shoppingCartHtml = @"
                                        <div class='cap'>
                                            <h3 class='cap-heading'>Shopping Cart</h3>
                                        </div>
                                        <div class='content__title'>
                                            <ul class='content__title-list'>
                                                <li class='content__title-item-name'>Name & Option</li>
                                                <li class='content__title-item-price'>Price</li>
                                                <li class='content__title-item-remove'>Remove</li>
                                            </ul>
                                        </div>";
            if (cart.ListProduct != null && cart.ListProduct.Count != 0)
            {
                foreach (KeyValuePair<int, int> item in list)
                {
                    foreach (Product product in products)
                    {
                        if (product.iID == item.Key)
                        {
                            double totalPrice = Convert.ToDouble(product.iPriceProduct * item.Value);
                            shoppingCartHtml += $@"
                                    <div class=""content__cart-list"">
                                        <div class=""content__cart-item"">
                                            <img src=""{product.sImgProduct}"" alt="""" class=""content__cart-item-img""/>
                                            <div class=""content__cart-info"">
                                                <h3 class=""cart-info-heading"">{product.sNameProduct}</h3>
                                                <p>REF:B001</p>
                                                <div class=""cart-info-quantity"">
                                                    <span class=""cart-info-subtract"" data-product-id='{product.iID}'>-</span>
                                                    <span class=""cart-info-number""  data-product-id='{product.iID}' max='{product.iStock}'>{item.Value}</span>
                                                    <span class=""cart-info-plus"" data-product-id='{product.iID}'>+</span>
                                                </div>
                                            </div>
                                            <div class='content__cart-price-remove'>
                                                <h3 class='cart__price'>${totalPrice}</h3>
                                                <a href='DelProductInCart.aspx?id={product.iID}&quantity={item.Value}' class='cart__remove' data-product-id='{product.iID}'>
                                                    <i class='cart__remove-icon fa-solid fa-trash'></i>
                                                </a>
                                            </div>
                                        </div> </div>";
                        }
                    }
                }
                return shoppingCartHtml;
            }
            else
            {
                shoppingCartHtml += "<div><p>Bạn chưa có sản phầm nào!</p></div>";
                return shoppingCartHtml;
            }
        }
    }
}