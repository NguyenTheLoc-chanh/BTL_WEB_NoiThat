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
    <link rel="stylesheet" href="./assets/font/fontawesome-free-6.4.0/css/all.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="product">
            <header class="header">
                <div class="grid wide">
                    <div class="header__navbar">
                        <div class="header__logo">
                            <a href="#"><img src="./assets/img/logoTN-01 1.png" alt="Logo" class="header__logo-img"/></a>
                        </div>
                        <div class="header__nav">
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
                            <div class="header__search">
                                <input type="text" name="search" id="search" placeholder="Nhập để tìm kiếm"/>
                                <a href="#" class="header__navbar-item-link header__search-link">
                                    <i class="header__search-btn-icon fas fa-search"></i>
                                </a>
                            </div>
                            <ul class="header__nav-list">
                                <li class="header__navbar-item">
                                    <a href="#" class="header__navbar-item-link">
                                        <i class="header__navbar-item-icon fa-solid fa-cart-shopping"></i>
                                    </a>
                                </li>
                                <li class="header__navbar-item header__navbar-user">
                                    <img src="./assets/img/logoTN-01 1.png" alt="" class="header__navbar-user-img"/>
                                    <span class="header__navbar-user-name">Nguyễn Thế Lộc</span>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </header>
            <h1>World of Interior</h1>
            <h3>Design make you smile</h3>
            <div class="option">
                <ul>
                    <li><a href="#">All</a></li>
                    <li><a href="#">Bathroom</a></li>
                    <li><a href="#">Bedroom</a></li>
                    <li><a href="#">Livingroom</a></li>
                    <li><a href="#">Workspace</a></li>
                    <li><a href="#">Dinning room</a></li>
                    <li><a href="#">Meeting room</a></li>
                    <li><a href="#">Kitchen</a></li>
                </ul>
            </div>
            <div class="filter">
                <input type="text" name="filter" placeholder="Add filter" value="" />
            </div>
            <div class="display_filter">
                <input type="text" name="lessthan1000" placeholder="Less than $1000" value="" disabled />
                <input type="text" name="red" placeholder="Red" value="" disabled />
            </div>
            <hr />
            <div class="list_product">
                <div class="grid wide">
                    <div class="row">
                        <div class="col c-4">
                            <div class="card">
                                <img src="./assets/product-img/product1.jpg" alt="Bathroom Design" />
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
                            </div>
                        </div>
                         <div class="col c-4">
                            <div class="card">
                                <img src="./assets/product-img/product1.jpg" alt="Bathroom Design" />
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
                            </div>
                        </div>
                         <div class="col c-4">
                            <div class="card">
                                <img src="./assets/product-img/product1.jpg" alt="Bathroom Design" />
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
                            </div>
                        </div>
                         <div class="col c-4">
                            <div class="card">
                                <img src="./assets/product-img/product1.jpg" alt="Bathroom Design" />
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
                            </div>
                        </div>
                         <div class="col c-4">
                            <div class="card">
                                <img src="./assets/product-img/product1.jpg" alt="Bathroom Design" />
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
                            </div>
                        </div>
                         <div class="col c-4">
                            <div class="card">
                                <img src="./assets/product-img/product1.jpg" alt="Bathroom Design" />
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
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
