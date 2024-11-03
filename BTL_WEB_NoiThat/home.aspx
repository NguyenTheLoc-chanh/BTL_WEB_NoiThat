<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="BTL_WEB_NoiThat.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Home</title>
    <link rel="stylesheet" href="./assets/css/home.css"/>
    <link rel="stylesheet" href="./assets/css/base.css"/>
    <link rel="stylesheet" href="./assets/css/grid.css"/>
    <link rel="stylesheet" href="./assets/css/responsive.css"/>
    <link rel="stylesheet" href="./assets/css/login.css"/>
    <link rel="stylesheet" href="./assets/font/fontawesome-free-6.4.0/css/all.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="home">
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
                                <a href="DetailOrder.aspx" class="header__nav-item-link">Contact</a>
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
        <div class="home__container">
            <div class="grid wide">
                <div class="row">
                    <div class="col l-12 m-12 c-12">
                        <div class="banner">
                            <div class="banner__content">
                                <span class="banner__slogan">TN Interior Designing Dreams</span>
                                <span class="banner__slogan-text">Crafting Your Perfect Space</span>
                                <button class="btn__shopnow" onclick="ClickShopNow();">Shop now</button>
                            </div>
                            <img src="./assets/img/Rectangle.png" alt="Banner" class="banner__img"/>
                        </div>
                    </div>
                </div>
                <div class="row catergory">
                    <div class="row">
                        <div class="col l-12 m-12 c-12">
                            <h3 class="catergory_heading">Explore by Catergoty</h3>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col l-4 m-4 c-12">
                            <a href="#" class="catergory__search-link">
                                <i class="catergory__search-icon fas fa-search"></i>
                            </a>
                            <input type="text" name="catergory__search" id="catergory__search" placeholder="Search"/>
                            <ul class="catergory__list">
                                <li class="catergory__item">Bedroom</li>
                                <li class="catergory__item">Dinning Room</li>
                                <li class="catergory__item">Bathroom</li>
                                <li class="catergory__item">Livingroom</li>
                                <li class="catergory__item">Kitchen</li>
                                <li class="catergory__item">Workspace</li>
                                <li class="catergory__item">Meeting Room</li>
                                <li class="catergory__item">
                                    <button class="catergory__btn">View all Category</button>
                                    <i class="category__btn-icon fa-solid fa-arrow-right"></i>
                                </li>
                            </ul>
                        </div>
                        <div class="col l-8 m-8 c-12">
                            <div class="row">
                                <div class="catergory__illus col l-6 m-6 c-12">
                                    <img src="./assets/img/img1.png" alt="Nội thất" class="catergory__img"/>
                                </div>
                                <div class="catergory__illus col l-6 m-6 c-12">
                                    <img src="./assets/img/img2.png" alt="Nội thất" class="catergory__img"/>
                                </div>
                                <div class="catergory__illus col l-6 m-6 c-12">
                                    <img src="./assets/img/img3.png" alt="Nội thất" class="catergory__img"/>
                                </div>
                                <div class="catergory__illus col l-6 m-6 c-12">
                                    <img src="./assets/img/img4.png" alt="Nội thất" class="catergory__img"/>
                                </div>
                                <div class="catergory__illus col l-6 m-6 c-12">
                                    <img src="./assets/img/img5.png" alt="Nội thất" class="catergory__img"/>
                                </div>
                                <div class="catergory__illus col l-6 m-6 c-12">
                                    <img src="./assets/img/img6.png" alt="Nội thất" class="catergory__img"/>
                                </div>
                            </div>
                        </div>
                        <div class="catergory__btn-mobile col c-12">
                            <button class="catergory__btn">View all Category</button>
                            <i class="category__btn-mobile-icon fa-solid fa-arrow-right"></i>
                        </div>
                    </div>
                </div>
            </div>
            <div class="product__special">
                <div class="grid wide">
                    <div class="row">
                        <div class="col l-12 m-12 c-12">
                            <h3 class="product__special-heading">Special Product</h3>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col l-6 m-12 c-12">
                            <a href="#" class="product__special-item">
                                <div class="product__special-mobile">
                                    <img src="./assets/img/special_product.png" alt="product__special" class="product__special-img"/>
                                    <div class="product__special-mobile-group">
                                        <div class="product__special-info-mobile">
                                            <span class="product__special-info-name">Special Wood Full</span>
                                            <div class="product__special__rating">
                                                <span class="product__special__rating-number">3.7</span>
                                                <i class="product__special__star--gold fas fa-star"></i>
                                                <i class="product__special__star--gold fas fa-star"></i>
                                                <i class="product__special__star--gold fas fa-star"></i>
                                                <i class="product__special__star--gold fas fa-star"></i>
                                                <i class="fas fa-star"></i>
                                            </div>
                                            <span class="product__special-price">$123.23</span>
                                        </div>
                                        <div class="product__special-desc-mobile">
                                            <h3 class="product__special-desc-mobile">Description</h3>
                                            <p class="product__special-detail-mobile">A wooden dining set comprises a table and chairs crafted from wood, adding a warm touch to living or working spaces. With diverse designs ranging from modern to classic, these sets combine the natural beauty and durability of wood, enhancing both aesthetics and functionality..</p>
                                            <div class="product__special-seemore-mobile">
                                                See more
                                                <i class="product__special-seemore-icon-mobile fas fa-angle-down"></i>
                                            </div>
                                        </div>
                                    </div>
                                </div>  
                                <div class="product__special-info">
                                    <div class="product__special-info-pc">
                                        <span class="product__special-info-name">Special Wood Full</span>
                                        <div class="product__special__rating">
                                            <span class="product__special__rating-number">3.7</span>
                                            <i class="product__special__star--gold fas fa-star"></i>
                                            <i class="product__special__star--gold fas fa-star"></i>
                                            <i class="product__special__star--gold fas fa-star"></i>
                                            <i class="product__special__star--gold fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                        </div>
                                        <span class="product__special-price">$123.23</span>
                                    </div>
                                    <div class="product__special-addCart">
                                        <button class="btn__addcart">
                                            <i class="product__special-item-icon fa-solid fa-cart-shopping"></i>
                                            Add to cart
                                        </button>
                                    </div>
                                </div>
                            </a>
                        </div>
                        <div class="col l-6 m-6 c-12">
                            <div class="row">
                                <div class="col l-12 m-12 c-12">
                                    <h3 class="product__special-desc">Description</h3>
                                    <p class="product__special-detail">A wooden dining set comprises a table and chairs crafted from wood, adding a warm touch to living or working spaces. With diverse designs ranging from modern to classic, these sets combine the natural beauty and durability of wood, enhancing both aesthetics and functionality..</p>
                                    <div class="product__special-seemore">
                                        See more
                                        <i class="product__special-seemore-icon fas fa-angle-down"></i>
                                    </div>
                                </div>
                                <div class="col l-12 m-12 c-12">
                                    <div class="other__product">
                                        <div class="other__product-lable">
                                            <h3 class="other__product-heading">Other product</h3>
                                            <div class="other__product-next">
                                                <button class="btnNext">
                                                    <i class="fa-solid fa-arrow-left"></i>
                                                </button>
                                                <button class="btnNext">
                                                    <i class="fa-solid fa-arrow-right"></i>
                                                </button>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col l-6 m-6 c-12">
                                                <a href="#" class="other__product-relate ">
                                                    <img src="./assets/img/no1kitchen.png" alt="product__special" class="other__product-img"/>
                                                    <div>
                                                        <span class="product__other-info-name">Special Wood Full</span>
                                                        <div class="product__special__rating">
                                                            <span class="product__special__rating-number">5.0</span>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                        </div>
                                                        <span class="product__other-price">$123.23</span>
                                                    </div>
                                                </a>
                                            </div>
                                            <div class="col l-6 m-6 c-12">
                                                <a href="#" class="other__product-relate">
                                                    <img src="./assets/img/a12workspace.png" alt="product__special" class="other__product-img"/>
                                                    <div>
                                                        <span class="product__other-info-name">Special Wood Full</span>
                                                        <div class="product__special__rating">
                                                            <span class="product__special__rating-number">4.0</span>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                            <i class="product__special__star--gold fas fa-star"></i>
                                                            <i class="fas fa-star"></i>
                                                        </div>
                                                        <span class="product__other-price">$123.23</span>
                                                    </div>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="getBetter">
                <div class="grid wide">
                    <div class="row">
                        <div class="col l-12 m-12 c-12">
                            <div class="better__container">
                                <div class="better__container-img">
                                    <img src="./assets/img/better.png" alt="Ảnh" class="better-img"/>
                                    <img src="./assets/img/better1.png" alt="Ảnh" class="better-img"/>
                                </div>
                                <div class="better__container-link">
                                    <h3 class="better__link-heading">Get better <br/>for your home</h3>
                                    <a href="#" class="better__link-getnow">Get it now?</a>
                                    <img src="./assets/img/better__ghe.png" alt="Ảnh ghế" class="better__link-img"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="benefit">
                <div class="grid wide">
                    <div class="row">
                        <div class="col l-12 m-12 c-12">
                            <h3 class="benefit__heading">Benefit for you</h3>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col l-12 m-12 c-12">
                            <div class="benefit__container">
                                <div class="benefit-pay">
                                    <span class="benifit-pay-img">
                                        <img src="./assets/img/pay.png" alt="Pay" class="benifit-pay-icon"/>
                                    </span>
                                    <h4 class="benifit-pay-heading">Payment Method</h4>
                                    <p class="benifit-pay-p">Flexible payment option, to make easier</p>
                                </div>
                                <div class="benefit-policy">
                                    <span class="benefit-policy-img">
                                        <img src="./assets/img/polycy.png" alt="Policy" class="benefit-policy-icon"/>
                                    </span>
                                    <h4 class="benefit-policy-heading">Return Policy</h4>
                                    <p class="benefit-policy-p">You can return a product within 14 days</p>
                                </div>
                                <div class="benefit-support">
                                    <span class="benefit-support-img">
                                        <img src="./assets/img/support.png" alt="Policy" class="benefit-support-icon"/>
                                    </span>
                                    <h4 class="benefit-support-heading">Customer Support</h4>
                                    <p class="benefit-support-p">Our customer support  is 24/7</p>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <div class="SubNewProduct">
                <div class="grid wide">
                    <div class="row">
                        <div class="col l-12 m-12 c-12">
                            <div class="subnew">
                                <div>
                                    <img src="./assets/img/Subnewproduct.png" alt="New Product" class="subnew-img"/>
                                </div>
                                <div>
                                    <h3 class="subproduct-heading">Subscribe for new product</h3>
                                    <p class="subproduct-p">Receice hot deal and many offers</p>
                                    <div class="subnew-form">
                                        <input type="email" name="email" id="subEmail" placeholder="Enter your email*"/>
                                        <input type="text" name="phone" id="phone" placeholder="Enter your phone number*"/>
                                        <input type="text" name="address" id="adress" placeholder="Enter your address"/>
                                        <input type="submit" value="Subscribe" id="btnSubmit"/>
                                    </div>
                                </div>
                            </div>
                        </div>
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
      </div>
    </form>

</body>
</html>
