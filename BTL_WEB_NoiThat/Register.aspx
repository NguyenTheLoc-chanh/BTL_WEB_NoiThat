<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BTL_WEB_NoiThat.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Register</title>
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
                    <!--Register form-->
                    <div class="auth-form-register">
                        <div class="auth-form__container">
                            <div class="auth-form__header">
                                <h3 class="auth-form__heading">Đăng ký</h3>
                                <a href="LoginPage.aspx" class="auth-form__switch-btn">Đăng nhập</a>
                            </div>
                            <div class="auth-form__form">
                                <div class="auth-form__group">
                                        <input type="text" class="auth-form__input" id="emailOrPhone" runat="server" placeholder="Nhập Email & số điện thoại"/>
                                        <asp:Label CssClass="error" ID="lbCheckEmailOrP" runat="server"></asp:Label>
                                </div>
                                <div class="auth-form__group">
                                        <input type="text" class="auth-form__input" id="userName" runat="server" placeholder="Nhập tên người dùng"/>
                                        <asp:Label CssClass="error" ID="lbCheckUserName" runat="server"></asp:Label>
                                </div>
                                <div class="auth-form__group">
                                    <input type="password" class="auth-form__input" id="passWordRes" runat="server" placeholder="Mật khẩu"/>
                                    <asp:Label CssClass="error" ID="lbcheckpassWordRes" runat="server"></asp:Label>
                                </div>    
                                <div class="auth-form__group">
                                    <input type="password" class="auth-form__input" id="passWordResA" runat ="server" placeholder="Nhập lại mật khẩu"/>
                                    <asp:Label CssClass="error" ID="lcCheckPassA" runat="server"></asp:Label>
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
                                <button type="button" class="btn auth-form__controls-back btn--normal" onclick="goHome();">Trở lại</button>
                                <!--<button class="btn btn--primary">ĐĂNG KÝ</button>-->
                                <asp:Button ID="btnRegister" CssClass="btn btn--primary" Text="Đăng ký" OnClientClick="return validateInput();" OnClick="btnRegisterClick" runat="server"/>
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
            </div>
        </div>
    </div>
    </form>
    <script src="./assets/js/home.js"></script>
</body>
</html>
