<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="BTL_WEB_NoiThat.detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Details</title>
    <link rel="stylesheet" href="./assets/css/detail.css" />
    <link rel="stylesheet" href="./assets/css/base.css"/>
    <link rel="stylesheet" href="./assets/font/fontawesome-free-6.4.0/css/all.css"/>
    <link rel="stylesheet" href="./assets/css/grid.css"/>
    <link rel="stylesheet" href="./assets/css/login.css"/>
    <link rel="stylesheet" href="./assets/css/responsive.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <header class="header">
      <div class="grid wide">
          <div class="header__navbar">
              <div class="header__logo">
                  <a href="#"><img src="./assets/img/logoTN-01 1.png" alt="Logo" class="header__logo-img"/></a>
              </div>
              <span class="header__login-mobile">Đăng nhập</span>
              <div class="header__nav header__nav-mobile">
                  <ul class="header__nav-list">
                      <li class="header__nav-item">
                          <a href="#" class="header__nav-item-link">Home</a>
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
                          <a href="#" class="header__navbar-item-link">
                              <i class="header__navbar-item-icon fa-solid fa-cart-shopping"></i>
                              <span class="header__cart-notice">3</span>
                          </a>
                      </li>
                      <li class="header__navbar-item header__navbar-user">
                          <img src="./assets/img/logoTN-01 1.png" alt="" class="header__navbar-user-img"/>
                          <span class="header__navbar-user-name active-login">Nguyễn Thế Lộc</span>
                          <span class="header__navbar-user-name login">Đăng nhập</span>
                          <span class="header__navbar-user-name register">Đăng ký</span>
                      </li>
                  </ul>
                  <img src="./assets/img/menu.png" alt="Menu" class="menu__mobile"/>
              </div>
          </div>
      </div>
  </header>
  <div class="details">
      <div class="grid wide">
        <div class="row">
          <div class="col l-12 m-12 c-12">
            <p class="breadcrumb">Product details / Product / Bathroom / 2023</p>
          </div>
        </div>
      <div class="row">
        <div class="product-container">
          <div class="col l-6 m-6 c-12">
            <div class="product-gallery">
              <div class="main-image">
                <img src="./assets/img/detail1.jpg" alt="Bathroom Full 2023" />
              </div>
            </div>
          </div>
          <div class="col l-6 m-6 c-12">
            <div class="product-details">
              <div class="thumbnail-gallery">
                <img src="./assets/img/detail2.jpg" alt="Thumbnail 1" />
                <img src="./assets/img/detail2.jpg" alt="Thumbnail 2" />
                <img src="./assets/img/detail2.jpg" alt="Thumbnail 3" />
              </div>
              <h1>B013 Bathroom full 2023</h1>
              <p class="description">
                Bathroom interiors seamlessly marry function, integrating chic
                vanities, efficient storage, and stylish fixtures. Whether boasting
                a modern, minimalistic vibe or exuding classic charm, the design
                prioritizes comfort and visual allure, catering to daily needs with
                flair.
              </p>
              <div class="price">
                <span>$674 </span>
                <a href="#" class="voucher-link">Get voucher 20%?</a>
              </div>
    
              <div class="quantity-selector">
                <span class="quantity-selector-active">1</span>
                <span>2</span>
                <span>3</span>
              </div>
    
              <button class="order-button">ORDER NOW</button>
              <button class="cart-button">Add to cart</button>
            </div>
          </div>
          
        </div>
      </div>
      <div class="row">
        <div class="col l-12 m-12 c-12">
          <a href="#" class="back-link">Back to Product</a>
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
<div class="modal">
  <div class="modal__overlay">

  </div>
  <div class="modal__body">
          <!--Register form-->
          <div class="auth-form-register">
              <div class="auth-form__container">
                  <div class="auth-form__header">
                      <h3 class="auth-form__heading">Đăng ký</h3>
                      <span class="auth-form__switch-btn">Đăng nhập</span>
            
                  </div>
                  <div class="auth-form__form">
                      <div class="auth-form__group">
                              <input type="text" class="auth-form__input" placeholder="Nhập Email & số điện thoại"/>
                      </div>
                      <div class="auth-form__group">
                          <input type="password" class="auth-form__input" placeholder="Mật khẩu"/>
                      </div>    
                      <div class="auth-form__group">
                          <input type="password" class="auth-form__input" placeholder="Nhập lại mật khẩu"/>
                      </div> 
                  </div>

                  <div class="auth-form__aside">
                      <p class="auth-form__polivy-text">
                          Bằng việc đăng kí, bạn đã đồng ý với TN về
                          <a href="#" class="auth-form__text-link">Điều khoản dịch vụ </a>&
                          <a href="#" class="auth-form__text-link">Chính sách bảo mật</a>
                      </p>
                  </div>
                  <div class="auth-form__controls">
                      <button class="btn auth-form__controls-back btn--normal">Trở lại</button>
                      <button class="btn btn--primary">ĐĂNG KÝ</button>
                  </div>
              </div>
              <div class="auth-form__socials">
                  <a href="#" class="auth-form__socials--facebook btn btn--size-s btn--with-icon">
                      <i class="auth-form__socials-icon fab fa-facebook-square"></i>
                      <span class="auth-form__socials-title">
                          Kết nối với Facebook
                      </span>
                  </a>
                  <a href="#" class="auth-form__socials--google btn btn--size-s btn--with-icon">
                      <i class="auth-form__socials-icon fab fa-google"></i>
                      <span class="auth-form__socials-title">
                          Kết nối với Google
                      </span>
                  </a>
              </div>
          </div>

          <!--Login form-->
          <div class="auth-form-login">
              <div class="auth-form__container">
                  <div class="auth-form__header">
                      <h3 class="auth-form__heading">Đăng nhập</h3>
                      <span class="auth-form__switch-btn registerForm">Đăng kí</span>
            
                  </div>
                  <div class="auth-form__form">
                      <div class="auth-form__group">
                              <input type="text" class="auth-form__input" placeholder="Nhập Email"/>
                      </div>
                      <div class="auth-form__group">
                          <input type="password" class="auth-form__input" placeholder="Mật khẩu"/>
                      </div>    
                  </div>

                  <div class="auth-form__aside">
                      <div class="auth-form__help">
                          <a href="#" class="auth-form__help-link auth-form__help-forgot">Quên mật khẩu</a>
                          <span class="auth-form__help-separate"></span>
                          <a href="#" class="auth-form__help-link">Cần trợ giúp?</a>
                      </div>
                  </div>

                  <div class="auth-form__controls">
                      <button class="btn auth-form__controls-back">Trở lại</button>
                      <button class="btn">ĐĂNG NHẬP</button>
                  </div>
              </div>
              <div class="auth-form__socials">
                  <a href="#" class="auth-form__socials--facebook btn">
                      <i class="auth-form__socials-icon fab fa-facebook-square"></i>
                      <span class="auth-form__socials-title">
                          Kết nối với Facebook
                      </span>
                  </a>
                  <a href="#" class="auth-form__socials--google btn">
                      <i class="auth-form__socials-icon fab fa-google"></i>
                      <span class="auth-form__socials-title">
                          Kết nối với Google
                      </span>
                  </a>
              </div>
          </div>
  </div>
</div>
<script src="./assets/js/home.js"></script>
    </form>
</body>
</html>
