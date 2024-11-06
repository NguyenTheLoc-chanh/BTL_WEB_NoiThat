<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="BTL_WEB_NoiThat.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="./assets/css/product.css"/>
    <link rel="stylesheet" href="./assets/css/base.css"/>
    <link rel="stylesheet" href="./assets/css/grid.css"/>
    <link rel="stylesheet" href="./assets/css/responsive.css"/>
    <link rel="stylesheet" href="./assets/css/login.css"/>
    <link rel="stylesheet" href="./assets/font/fontawesome-free-6.4.0/css/all.css"/>
</head>
<body>
    <form id="form1" runat="server">
       <div class="product">
             <header class="header">
            <div class="grid wide">
                <div class="header__navbar">
                    <div class="header__logo">
                        <a href="home.aspx"><img src="./assets/img/logoTN-01 1.png" alt="Logo" class="header__logo-img"/></a>
                    </div>
                    <span class="header__login-mobile">Đăng nhập</span>
                    <div class="header__nav header__nav-mobile">
                        <ul class="header__nav-list">
                            <li class="header__nav-item">
                                <a href="home.aspx" class="header__nav-item-link">Home</a>
                            </li>
                            <li class="header__nav-item">
                                <a href="#" class="header__nav-item-link">Product</a>
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
                                    <span id="numberProduct" class="header__cart-notice" runat="server">0</span>
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
           <div class="product__container">
               <div class="grid wide">
                   <div class="row">
                       <div class="col l-12 m-12 c-12">
                           <h1 class="procduct__title">World of Interior</h1>
                           <h3 class="procduct__title-color">Design make you smile</h3>
                       </div>
                   </div>
                   <div class="row">
                        <div class="option mobile-category col c-12">
                             <ul class="option-list mobile-category__list">
                                 <li class="option-item mobile-category__item"><asp:LinkButton ID="LinkAll"  CssClass="option-item-link mobile-category__link" runat="server" OnClick="LinkButton_Click" CommandArgument="all">All</asp:LinkButton></li>
                                 <li class="option-item mobile-category__item"><asp:LinkButton ID="LinkBathroom"  CssClass="option-item-link mobile-category__link" runat="server" OnClick="LinkButton_Click" CommandArgument="bathroom">Bathroom</asp:LinkButton></li>
                                 <li class="option-item mobile-category__item"><asp:LinkButton ID="LinkBedroom"  CssClass="option-item-link mobile-category__link" runat="server" OnClick="LinkButton_Click" CommandArgument="bedroom">Bedroom</asp:LinkButton></li>
                                 <li class="option-item mobile-category__item"><asp:LinkButton ID="LinkLivingroom"  CssClass="option-item-link mobile-category__link" runat="server" OnClick="LinkButton_Click" CommandArgument="livingroom">Livingroom</asp:LinkButton></li>
                                 <li class="option-item mobile-category__item"><asp:LinkButton ID="LinkWorkspace"  CssClass="option-item-link mobile-category__link" runat="server" OnClick="LinkButton_Click" CommandArgument="workspace">Workspace</asp:LinkButton></li>
                                 <li class="option-item mobile-category__item"><asp:LinkButton ID="LinkDiningroom"  CssClass="option-item-link mobile-category__link" runat="server" OnClick="LinkButton_Click" CommandArgument="diningroom">Dining room</asp:LinkButton></li>
                                 <li class="option-item mobile-category__item"><asp:LinkButton ID="LinkMeetingroom" CssClass="option-item-link mobile-category__link" runat="server" OnClick="LinkButton_Click" CommandArgument="meetingroom">Meeting room</asp:LinkButton></li>
                                 <li class="option-item mobile-category__item"><asp:LinkButton ID="LinkKitchen" class="mobile-category__link" CssClass="option-item-link mobile-category__link" runat="server" OnClick="LinkButton_Click" CommandArgument="kitchen">Kitchen</asp:LinkButton></li>
                             </ul>
                            <div class="filter">
                                 <input class="filter__search" type="text" name="filter" placeholder="Add filter" value="" />
                            </div>
                      </div>
                    </div>
                   <div class="row">
                        <div class="display_filter col l-12 m-12 c-12">
                            <input class="filter__select" type="text" name="lessthan1000" placeholder="Less than $1000" value="" disabled />
                            <input class="filter__select" type="text" name="red" placeholder="Red" value="" disabled />
                        </div>
                   </div>
               </div>
            <hr />
            <div class="list_product">
                <div class="grid wide">
                    <div class="row" id="rowProduct" runat="server">
                        <!-- <div class="col l-4 m-4 c-12">
                            <div class="card">
                                <a href="detail.aspx" class="card__link">
                                    <img src="./assets/img/product1.jpg" alt="Bathroom Design" />
                                <div class="card-content">
                                    <h2>B013 Bathroom full 2023</h2>
                                    <div class="options-rating">
                                        <span class="options">3 options</span>
                                        <div class="rating">
                                            <span>3.7</span>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star-half-alt"></i>
                                            <i class="far fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="price">
                                        <span>$674</span>
                                    </div>
                                    <div class="icons">
                                        <i class="fas fa-shopping-cart"></i>
                                        <i class="fas fa-heart"></i>
                                    </div>
                                </div>
                                </a>
                            </div>
                        </div>
                         <div class="col l-4 m-4 c-12">
                            <div class="card">
                                <a href="detail.aspx" class="card__link">
                                    <img src="./assets/img/product2.png" alt="Bathroom Design"/>
                                <div class="card-content">
                                    <h2>B013 Bathroom full 2023</h2>
                                    <div class="options-rating">
                                        <span class="options">3 options</span>
                                        <div class="rating">
                                            <span>3.7</span>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star-half-alt"></i>
                                            <i class="far fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="price">
                                        <span>$674</span>
                                    </div>
                                    <div class="icons">
                                        <i class="fas fa-shopping-cart"></i>
                                        <i class="fas fa-heart"></i>
                                    </div>
                                </div>
                                </a>
                            </div>
                        </div>
                         <div class="col l-4 m-4 c-12">
                            <div class="card">
                                <a href="detail.aspx" class="card__link">
                                    <img src="./assets/img/product3.png" alt="Bathroom Design" />
                                <div class="card-content">
                                    <h2>B013 Bathroom full 2023</h2>
                                    <div class="options-rating">
                                        <span class="options">3 options</span>
                                        <div class="rating">
                                            <span>3.7</span>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star-half-alt"></i>
                                            <i class="far fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="price">
                                        <span>$674</span>
                                    </div>
                                    <div class="icons">
                                        <i class="fas fa-shopping-cart"></i>
                                        <i class="fas fa-heart"></i>
                                    </div>
                                </div>
                                </a>
                            </div>
                        </div>
                         <div class="col l-4 m-4 c-12">
                            <div class="card">
                                <a href="detail.aspx" class="card__link">
                                    <img src="./assets/img/product4.png" alt="Bathroom Design" />
                                <div class="card-content">
                                    <h2>B013 Bathroom full 2023</h2>
                                    <div class="options-rating">
                                        <span class="options">3 options</span>
                                        <div class="rating">
                                            <span>3.7</span>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star-half-alt"></i>
                                            <i class="far fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="price">
                                        <span>$674</span>
                                    </div>
                                    <div class="icons">
                                        <i class="fas fa-shopping-cart"></i>
                                        <i class="fas fa-heart"></i>
                                    </div>
                                </div>
                                </a>
                            </div>
                        </div>
                         <div class="col l-4 m-4 c-12">
                            <div class="card">
                                <a href="detail.aspx" class="card__link">
                                    <img src="./assets/img/product5.png" alt="Bathroom Design" />
                                <div class="card-content">
                                    <h2>B013 Bathroom full 2023</h2>
                                    <div class="options-rating">
                                        <span class="options">3 options</span>
                                        <div class="rating">
                                            <span>3.7</span>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star-half-alt"></i>
                                            <i class="far fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="price">
                                        <span>$674</span>
                                    </div>
                                    <div class="icons">
                                        <i class="fas fa-shopping-cart"></i>
                                        <i class="fas fa-heart"></i>
                                    </div>
                                </div>
                                </a>
                            </div>
                        </div>
                         <div class="col l-4 m-4 c-12">
                            <div class="card">
                                <a href="detail.aspx" class="card__link">
                                    <img src="./assets/img/product6.png" alt="Bathroom Design" />
                                <div class="card-content">
                                    <h2>B013 Bathroom full 2023</h2>
                                    <div class="options-rating">
                                        <span class="options">3 options</span>
                                        <div class="rating">
                                            <span>3.7</span>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star"></i>
                                            <i class="fas fa-star-half-alt"></i>
                                            <i class="far fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="price">
                                        <span>$674</span>
                                    </div>
                                    <div class="icons">
                                        <i class="fas fa-shopping-cart"></i>
                                        <i class="fas fa-heart"></i>
                                    </div>
                                </div>
                                </a>
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
        </div>
    </form>
</body>
</html>
