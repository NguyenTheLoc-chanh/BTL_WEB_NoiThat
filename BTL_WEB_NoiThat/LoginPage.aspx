<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="BTL_WEB_NoiThat.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Login</title>
    <link rel="stylesheet" href="./assets/css/home.css"/>
    <link rel="stylesheet" href="./assets/css/base.css"/>
    <link rel="stylesheet" href="./assets/css/login.css"/>
    <link rel="stylesheet" href="./assets/font/fontawesome-free-6.4.0/css/all.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="home">
         <div class="modal">
            <div class="modal__overlay">
    
            </div>
            <div class="modal__body">
                   <div class="auth-form-login">
                    <div class="auth-form__container">
                        <div class="auth-form__header">
                            <h3 class="auth-form__heading">Đăng nhập</h3>
                            <a href="Register.aspx" class="auth-form__switch-btn registerForm">Đăng kí</a>
                  
                        </div>
                        <div class="auth-form__form">
                            <div class="auth-form__group">
                                    <input type="text" class="auth-form__input" id="emailOrPhoneLogin" runat="server" placeholder="Nhập Email hoặc số điện thoại"/>
                                    <asp:Label CssClass="error" ID="lbCheckEmailOrPhoneLogin" runat="server"></asp:Label>
                            </div>
                            <div class="auth-form__group">
                                <input type="password" class="auth-form__input" id="passLogin" runat="server" placeholder="Mật khẩu"/>
                                <asp:Label CssClass="error" ID="lbCheckPassLogin" runat="server"></asp:Label>
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
                            
                            <button type="button" class="btn auth-form__controls-back" onclick="goHome();">Trở lại</button>
                            <!--<button class="btn">ĐĂNG NHẬP</button> -->
                            <asp:Button ID="btnLogin" CssClass="btn btn--primary" Text="Đăng nhập" OnClientClick="return validateInputLogin();" runat="server" OnClick="btnLoginClick"/>
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
    </div>
    </form>
    <script src="./assets/js/home.js"></script>
</body>
</html>
