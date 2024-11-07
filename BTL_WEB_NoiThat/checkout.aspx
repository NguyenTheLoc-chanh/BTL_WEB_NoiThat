<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="BTL_WEB_NoiThat.checkout" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Checkout</title>
    <link rel="stylesheet" href="./assets/css/home.css"/>
    <link rel="stylesheet" href="./assets/css/base.css"/>
    <link rel="stylesheet" href="./assets/css/grid.css"/>
    <link rel="stylesheet" href="./assets/css/responsive.css"/>
    <link rel="stylesheet" href="./assets/css/login.css"/>
    <link rel="stylesheet" href="./assets/css/checkout.css"/>
    <link rel="stylesheet" href="./assets/font/fontawesome-free-6.4.0/css/all.css"/>
</head>
<body>
    <div class="checkout">
        <header class="header">
            <div class="grid wide">
                <div class="header__navbar">
                    <div class="header__logo">
                        <a href="home.aspx"><img src="./assets/img/logoTN-01 1.png" alt="Logo" class="header__logo-img"/></a>
                    </div>
                    <a class="header__login-mobile" href="LoginPage.aspx">Đăng nhập</a>
                    <div class="header__nav header__nav-mobile">
                        <ul class="header__nav-list">
                            <li class="header__nav-item">
                                <a href="home.aspx" class="header__nav-item-link">Home</a>
                            </li>
                            <li class="header__nav-item">
                                <a href="product.aspx" class="header__nav-item-link">Product</a>
                            </li>
                            <li class="header__nav-item">
                                <a href="#" class="header__nav-item-link">About</a>
                            </li>
                            <li class="header__nav-item">
                                <a href="#" class="header__nav-item-link">Contact</a>
                            </li>
                        </ul>
                    </div>
                    <div class="header__nav">
                        <!-- <div class="header__search">
                            <input type="text" name="search" id="search" placeholder="Nhập để tìm kiếm">
                            <a href="#" class="header__navbar-item-link header__search-link">
                                <i class="header__search-btn-icon fas fa-search"></i>
                            </a>
                        </div> -->
                        <ul class="header__nav-list">
                            <li class="header__navbar-item header__navbar-cart">
                                <a href="shoppingcart.aspx" class="header__navbar-item-link">
                                    <i class="header__navbar-item-icon fa-solid fa-cart-shopping"></i>
                                    <span class="header__cart-notice" runat="server" id="numberProduct">0</span>
                                </a>
                            </li>
                            <li class="header__navbar-item header__navbar-user">
                                <img src="./assets/img/logoTN-01 1.png" alt="" class="header__navbar-user-img"/>
                                <span class="header__navbar-user-name" id="userNameHomeLogin" runat="server"></span>
                                <span runat="server" id="spanLogin">
                                    <a href="LoginPage.aspx" class="header__navbar-user-name login">Login</a>
                                </span>
                                <span runat="server" id="spanRegister">
                                      <a href="Register.aspx" class="header__navbar-user-name register">Register</a>
                                </span>
                            </li>
                        </ul>
                        <img src="./assets/img/menu.png" alt="Menu" class="menu__mobile"/>
                    </div>
                </div>
            </div>
        </header>
        <div class="checkout__container">
            <div class="grid wide">
                <div class="row">
                    <div class="col l-6 m-6 c-12 checkout-left">
                        <h3>Thông tin giao hàng</h3>
                           <div runat="server" id="list_info_checkout">
                            <!--<form action="HandleCheckout.aspx" method="post" class="checkout-form">
                                <div class="form-group">
                                    <input class="form-input" type="text" name="name" placeholder="Họ và tên" required/>
                                    <input class="form-input" type="email" id="txtEmail" name="email" placeholder="Email" runat="server"/>
                                    <input class="form-input" type="text" id="txtPhone" name="phone" placeholder="Số điện thoại" required runat="server"/>
                                    <input class="form-input" type="text" id="txtAddress" name="address" placeholder="Địa chỉ" required runat="server"/>
                                </div>
                                <div class="form-group-address">
                                    <select name="city">
                                        <option value="">Tỉnh / thành</option>
                                        <option value="Hà Nội">Hà Nội</option>
                                    </select>
                                    <select name="district">
                                        <option value="">Quận / huyện</option>
                                        <option value="Hoàn Kiếm">Hoàn Kiếm</option>
                                    </select>
                                    <select name="ward">
                                        <option value="">Phường / xã</option>
                                        <option value="Tràng Tiền">Tràng Tiền</option>
                                    </select>
                                </div>
                            
                                <h4>Phương thức vận chuyển</h4>
                                <div class="shipping-method">
                                    <p>Vui lòng chọn tỉnh / thành để có danh sách phương thức vận chuyển.</p>
                                </div>
                            
                                <h4>Phương thức thanh toán</h4>
                                <div class="payment-method">
                                    <div class="inner-payment">
                                        <label for="cod">Thanh toán khi giao hàng (COD)</label>
                                        <input type="radio" id="cod" name="payment" value="cod" checked/>
                                    </div>
                                    <div class="inner-payment">
                                        <label for="bank">Chuyển khoản qua ngân hàng</label>
                                        <input type="radio" id="bank" name="payment" value="bank"/>
                                    </div>
                                </div>
                            
                                <button type="submit" class="complete-order">Hoàn tất đơn hàng</button>
                            </form> -->
                           </div>
                    </div>
                    <div class="col l-6 m-6 c-12 checkout-right" runat="server" id="list_product_checkout">
                            <!--<h3>Thông tin sản phẩm mua</h3>
                            <div class="cart-items">
                                <div class="cart-item">
                                    <div class="infor-product-item" style="display: flex;">
                                        <img src="./assets/img/better.png" alt="{product.Name}"/>
                                        <div>
                                            <p style="font-size: 16px;">{product.Name}</p>
                                            <p style="font-size: 14px; font-weight: 600;">Số lượng: {item.Value}</p>
                                        </div>
                                    </div>
                                    <span>{newPrice.ToString("N0")}đ</span>
                                </div>
                            </div>

                            <div class="cart-summary">
                                <div class="btn-discount">
                                    <input type="text" placeholder="Mã giảm giá" name="couponCode"/>
                                    <button id="use-coupon-btn">Sử dụng</button>
                                </div>
                                <div class="summary-detail">
                                    <p>Tạm tính: <span>{totalPrice.ToString("N0")}đ</span></p>
                                    HTML cho mã giảm giá sẽ được chèn ở đây
                                    <p>Mã giảm giá giảm: 
                                        <span>{cart.Coupon.Discount}% - {(totalPrice - finalPrice).ToString("N0")} đ</span>
                                    </p>
                                    <p>Phí vận chuyển: <span>30,000đ</span></p>
                                    <div class="inner-price">
                                        <p><strong>Tổng cộng:</strong></p>
                                        <p><strong>{(finalPrice + 30000).ToString("N0")}đ</strong></p>
                                    </div>
                                </div>
                            </div> -->
                    </div>
                </div>
            </div>
        </div>
         <footer class="footer">
            <div class="grid wide">
                <div class="row">
                    <div class="col l-3 m-3 c-12">
                        <h3 class="footer__heading">About Us</h3>
                        <ul class="footer__list">
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Visit our Store</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">About Us</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Our Blog</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Craftmanship</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Apply For a Job</a>
                            </li>
                        </ul>
                    </div>
                    <div class="col l-3 m-3 c-12">
                        <h3 class="footer__heading">Shopping</h3>
                        <ul class="footer__list">
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Online Payment</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Gift Cards</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Return Policy</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Furniture Asembling</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Shipping Methods</a>
                            </li>
                        </ul>
                    </div>
                    <div class="col l-3 m-3 c-12">
                        <h3 class="footer__heading">Latest News</h3>
                        <ul class="footer__list">
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">The Essentials Design Tip</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Function WTW Shelves</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">9 Unique Ways to Display on TV</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Minimal Design</a>
                            </li>
                            <li class="footer-item">
                                <a href="#" class="footer-item__link">Make a Huge Impact</a>
                            </li>
                        </ul>
                    </div>
                    <div class="col l-3 m-3 c-12">
                        <h3 class="footer__heading">Subscribe</h3>
                        <p class="footer-item__p">Signup for our newsletter to get the latest new collections and product launches.</p>
                    </div>
                </div>
                <div class="row">
                    <div class="col l-12 m-12 c-12">
                        <div class="footer__social">
                            <p class="footer__info">© Copyright 2023 - TN Interior Design </p>
                            <ul class="footer__list-social">
                                <li class="footer-item-social">
                                    <a href="#" class="footer-item__link">
                                        <i class="footer-item__icon fab fa-facebook"></i>
                                        Facebook
                                    </a>
                                </li>
                                <li class="footer-item-social">
                                    <a href="#" class="footer-item__link">
                                        <i class="footer-item__icon fab fa-instagram"></i>
                                        Instagram
                                    </a>
                                </li>
                                <li class="footer-item-social">
                                    <a href="#" class="footer-item__link">
                                        <i class="footer-item__icon fab fa-linkedin"></i>
                                        Linkedn
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <script src="./assets/js/home.js"></script>
        <script src="./assets/js/checkout.js"></script>
    </div>
</body>
</html>
