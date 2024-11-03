using BTL_WEB_NoiThat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat
{
    public class LoadData
    {
        public static string loadSpecialProductHome(List<Product> listProduct)
        {
            string speacialProduct = "";
            List<Product> specialProducts = new List<Product>();

            for (int i = 0; i < listProduct.Count; i++)
            {
                Product proSpecial = listProduct[i];
                if (proSpecial.sNameProduct.Contains("Special"))
                {
                    specialProducts.Add(proSpecial);

                }
            }
            for(int i = 0; i < specialProducts.Count; i++)
            {
                Product pro1 = specialProducts[0];
                Product pro2 = specialProducts[1];
                Product pro3 = specialProducts[2];
                speacialProduct += $@"
<div class=""col l-6 m-12 c-12"">
    <a href=""#"" class=""product__special-item"">
        <div class=""product__special-mobile"">
            <img src=""{pro1.sImgProduct}"" alt=""product__special"" class=""product__special-img""/>
            <div class=""product__special-mobile-group"">
                <div class=""product__special-info-mobile"">
                    <span class=""product__special-info-name"">{pro1.sNameProduct}</span>
                    <div class=""product__special__rating"">
                        <span class=""product__special__rating-number"">3.7</span>
                        <i class=""product__special__star--gold fas fa-star""></i>
                        <i class=""product__special__star--gold fas fa-star""></i>
                        <i class=""product__special__star--gold fas fa-star""></i>
                        <i class=""product__special__star--gold fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                    </div>
                    <span class=""product__special-price"">${pro1.iPriceProduct}</span>
                </div>
                <div class=""product__special-desc-mobile"">
                    <h3 class=""product__special-desc-mobile"">Description</h3>
                    <p class=""product__special-detail-mobile"">{pro1.sInfoProduct}</p>
                    <div class=""product__special-seemore-mobile"">
                        See more
                        <i class=""product__special-seemore-icon-mobile fas fa-angle-down""></i>
                    </div>
                </div>
            </div>
        </div>  
        <div class=""product__special-info"">
            <div class=""product__special-info-pc"">
                <span class=""product__special-info-name"">{pro1.sNameProduct}</span>
                <div class=""product__special__rating"">
                    <span class=""product__special__rating-number"">3.7</span>
                    <i class=""product__special__star--gold fas fa-star""></i>
                    <i class=""product__special__star--gold fas fa-star""></i>
                    <i class=""product__special__star--gold fas fa-star""></i>
                    <i class=""product__special__star--gold fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                </div>
                <span class=""product__special-price"">${pro1.iPriceProduct}</span>
            </div>
            <div class=""product__special-addCart"">
                <button class=""btn__addcart"">
                    <i class=""product__special-item-icon fa-solid fa-cart-shopping""></i>
                    Add to cart
                </button>
            </div>
        </div>
    </a>
</div>
<div class=""col l-6 m-6 c-12"">
    <div class=""row"">
        <div class=""col l-12 m-12 c-12"">
            <h3 class=""product__special-desc"">Description</h3>
            <p class=""product__special-detail"">{pro1.sInfoProduct}</p>
            <div class=""product__special-seemore"">
                See more
                <i class=""product__special-seemore-icon fas fa-angle-down""></i>
            </div>
        </div>
        <div class=""col l-12 m-12 c-12"">
            <div class=""other__product"">
                <div class=""other__product-lable"">
                    <h3 class=""other__product-heading"">Other product</h3>
                    <div class=""other__product-next"">
                        <button class=""btnNext"">
                            <i class=""fa-solid fa-arrow-left""></i>
                        </button>
                        <button class=""btnNext"">
                            <i class=""fa-solid fa-arrow-right""></i>
                        </button>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col l-6 m-6 c-12"">
                        <a href=""#"" class=""other__product-relate"">
                            <img src=""{pro2.sImgProduct}"" alt=""product__special"" class=""other__product-img""/>
                            <div>
                                <span class=""product__other-info-name"">{pro2.sNameProduct}</span>
                                <div class=""product__special__rating"">
                                    <span class=""product__special__rating-number"">5.0</span>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                </div>
                                <span class=""product__other-price"">${pro2.iPriceProduct}</span>
                            </div>
                        </a>
                    </div>
                    <div class=""col l-6 m-6 c-12"">
                        <a href=""#"" class=""other__product-relate"">
                            <img src=""{pro3.sImgProduct}"" alt=""product__special"" class=""other__product-img""/>
                            <div>
                                <span class=""product__other-info-name"">{pro3.sNameProduct}</span>
                                <div class=""product__special__rating"">
                                    <span class=""product__special__rating-number"">4.0</span>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                    <i class=""product__special__star--gold fas fa-star""></i>
                                    <i class=""fas fa-star""></i>
                                </div>
                                <span class=""product__other-price"">${pro3.iPriceProduct}</span>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>";
            }
            return speacialProduct;
        }
        public static string loadProduct(List<Product> listProduct)
        {
            string productHtml = "";
            for (int i = 0; i < listProduct.Count; i++)
            {
                Product prod = (Product)listProduct[i];
                productHtml += $@"
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
            return productHtml;
        }
        public static string loadProductFilter(string filter ,List<Product> listProduct)
        {
            string innerHtml = "";
            for(int i = 0; i < listProduct.Count; i++)
            {
                Product pro = listProduct[i];
                if (pro.sNameProduct.Contains(filter))
                {
                    innerHtml += $@"
                            <div class=""col l-4 m-4 c-12"">
                                <div class=""card"">
                                    <a href=""detail.aspx?id={pro.iID}"" class=""card__link"">
                                        <img src=""{pro.sImgProduct}"" alt=""Bathroom Design"" />
                                        <div class=""card-content"">
                                            <h2>{pro.sNameProduct}</h2>
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
                                                <span>${pro.iPriceProduct}</span>
                                            </div>
                                            <div class=""icons"">
                                                <a href='AddPageProductToCarrt.aspx?id={pro.iID}&quantity={1}' class='cart__add' data-product-id='{pro.iID}'>
                                                   <i class=""fas fa-shopping-cart""></i>
                                                </a>
                                                <i class=""fas fa-heart""></i>
                                            </div>
                                        </div>
                                    </a>
                                </div>
                            </div>";
                }
            }
            if(innerHtml == "")
            {
                innerHtml += "Chưa có sản phẩm nào!";
            }
            return innerHtml;
        }
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
        public static string loadInfoCheckOut(CartItem cartItem, checkoutInfo checkoutInfo, checkoutInfo checkoutInfoCart)
        {
            string htmlInfoCheckout = "";
            if(checkoutInfo == null)
            {
                checkoutInfo = new checkoutInfo();
            }
            string paymentCheck = checkoutInfo.SPaymentMethod == "cod" ? "checked" : "";
            if(paymentCheck == "")
            {

            }
            htmlInfoCheckout += $@"
                <form action=""HandleCheckout.aspx"" method=""post"" class=""checkout-form"">
                    <div class=""form-group"">
                        <input class=""form-input"" type=""text"" name=""name"" placeholder=""Họ và tên"" required value=""{checkoutInfo.SName}""/>
                        <input class=""form-input"" type=""email"" id=""txtEmail"" name=""email"" placeholder=""Email"" runat=""server"" value=""{checkoutInfo.SEmail}""/>
                        <input class=""form-input"" type=""text"" id=""txtPhone"" name=""phone"" placeholder=""Số điện thoại"" required runat=""server"" value=""{checkoutInfo.SPhone}""/>
                        <input class=""form-input"" type=""text"" id=""txtAddress"" name=""address"" placeholder=""Địa chỉ"" required runat=""server"" value=""{checkoutInfo.SAddress}""/>
                    </div>
    
                    <div class=""form-group-address"">
                        <select name=""city"" id=""city"" onchange=""updateDistricts()"" >
                            <option value="""">Tỉnh / thành</option>
                            <option value=""hanoi"">Hà Nội</option>
                            <option value=""hcm"">Hồ Chí Minh</option>
                            <option value=""bacgiang"">Bắc Giang</option>
                            <!-- Thêm các tỉnh/thành khác tại đây -->
                        </select>
                        <select name=""district"" id=""district""  onchange=""updateWard()"">
                             <option value="""">Quận / huyện</option>
                            <option value={checkoutInfo.SDistrict}>{checkoutInfo.SDistrict}</option>
                        </select>
                        <select name=""ward"" id=""ward"">
                            <option value="""">Phường / xã</option>
                            <option value={checkoutInfo.SWard}>{checkoutInfo.SWard}</option>
                        </select>
                    </div>
    
                    <h4>Phương thức vận chuyển</h4>
                    <div class=""shipping-method"">
                        <p>Vui lòng chọn tỉnh / thành để có danh sách phương thức vận chuyển.</p>
                    </div>
    
                    <h4>Phương thức thanh toán</h4>
                    <div class=""payment-method"">
                        <div class=""inner-payment"">
                            <label for=""cod"">Thanh toán khi giao hàng (COD)</label>
                            <input type=""radio"" id=""cod"" name=""payment"" value=""cod"" checked/>
                        </div>
                        <div class=""inner-payment"">
                            <label for=""bank"">Chuyển khoản qua ngân hàng</label>
                            <input type=""radio"" id=""bank"" name=""payment"" value=""bank""/>
                        </div>
                    </div>
    
                    <button type=""submit"" class=""complete-order"">Hoàn tất đơn hàng</button>
                </form>";
            return htmlInfoCheckout;
        }

        public static string loadInfoProductCheckout(CartItem cartItem, List<Product> listProduct)
        {
            string htmlInfoProduct = "";
            double totalPrice = 0;
            double finalProduct= 0;
            Dictionary<int, int> listCart = cartItem.ListProduct;
            foreach(KeyValuePair<int, int> item in listCart)
            {
                foreach(Product pro in listProduct)
                {
                    if(pro.iID == item.Key)
                    {
                        totalPrice = pro.iPriceProduct * item.Value;
                        htmlInfoProduct += $@"<div class=""cart - item"">
                        <div class=""infor-product-item"" style=""display: flex;"">
                            <img src=""{pro.sImgProduct}"" alt=""{pro.sNameProduct}""/>
                            <div>
                                <p style=""font-size: 16px;"">{pro.sNameProduct}</p>
                                <p style=""font-size: 14px; font-weight: 600;"">Số lượng: {item.Value}</p>
                            </div>
                        </div>
                        <span>{totalPrice.ToString("N0")}$</span>
                     </div>";
                    }
                }
                finalProduct += totalPrice;
            };
            string htmlCoupon = "";
            double newPriceDiscount = finalProduct;
            if (cartItem.Coupon != null && cartItem.Coupon.IDiscount > 0)
            {
                newPriceDiscount = finalProduct * (1 - (double)cartItem.Coupon.IDiscount / 100);
                double priceDiscount = finalProduct - newPriceDiscount;
                htmlCoupon = $@"<p>Mã giảm giá giảm: <span>{cartItem.Coupon.IDiscount}% ( {(priceDiscount).ToString("N0")}$)</span></p>";
            }

            string htmlCheckout = $@"
            <h3>Thông tin sản phẩm mua</h3>
            <div class=""cart-items"">
                {htmlInfoProduct}
            </div>
            <div class=""cart-summary"">
                <div class=""btn-discount"">
                    <input id=""coupon__Price"" type=""text"" placeholder=""Mã giảm giá"" name=""couponCode"" runat=""server""/>
                    <button type=""submit"" id=""use-coupon-btn"">Sử dụng</button>
                </div>
                <div class=""summary-detail"">
                    <p>Tạm tính: <span>{totalPrice.ToString("N0")}$</span></p>
                        {htmlCoupon}
                    <p>Phí vận chuyển: <span>2$</span></p>
                    <div id=""finalProduct1"" class=""inner-price"" runat=""server"">
                        <p><strong>Tổng cộng: {(newPriceDiscount + 2).ToString("N0")}$</strong></p>
                    </div>
                </div>
            </div>";

            return htmlCheckout;
        }
    }
}