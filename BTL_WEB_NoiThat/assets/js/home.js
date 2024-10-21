document.addEventListener("DOMContentLoaded", function () {
    const menuMobile = document.querySelector('.menu__mobile');
    const mobileNav = document.querySelector('.header__nav-mobile .header__nav-list');

    menuMobile.addEventListener('click', function () {
        mobileNav.classList.toggle('active')
    })
})

// Login and Register
const modal = document.querySelector(".modal");
const modalBody = document.querySelector(".modal__body");
const formLogin = document.querySelector(".auth-form-login");
const formRegister = document.querySelector(".auth-form-register");
const login = document.querySelector(".header__navbar-user-name.login");
const register = document.querySelector(".header__navbar-user-name.register")

/*login.addEventListener("click", function (e) {
    e.preventDefault();
    modal.classList.add("active");
    if (formRegister.classList.contains("active")) {
        formRegister.classList.remove("active");
    }
    formLogin.classList.add("active");
})

register.addEventListener("click", function (e) {
    e.preventDefault();
    modal.classList.add("active");
    if (formLogin.classList.contains("active")) {
        formLogin.classList.remove("active");
    }
    formRegister.classList.add("active");
})
*/

/*modalBody.addEventListener("click", function (e) {
    e.preventDefault();
    //e.target là phần tử mà người dùng đã nhấn vào. trả về true
    if (!formLogin.contains(e.target) && !formRegister.contains(e.target)) {
        modal.classList.remove("active");
    }
})
*/
// Đăng nhập khi ấn vào form đăng ký

/*
const loginForm = document.querySelector(".auth-form__switch-btn");
const registerForm = document.querySelector(".auth-form__switch-btn.registerForm");

loginForm.addEventListener("click", function (e) {
    e.preventDefault();
    formRegister.classList.remove("active");
    formLogin.classList.add("active");
})

registerForm.addEventListener("click", function (e) {
    e.preventDefault();
    formLogin.classList.remove("active");
    formRegister.classList.add("active");
})
*/
// Đăng nhập trên mobile
/*
const loginMobile = document.querySelector(".header__login-mobile");

loginMobile.addEventListener("click", function (e) {
    e.preventDefault();
    modal.classList.add("active");
    if (formRegister.classList.contains("active")) {
        formRegister.classList.remove("active");
    }
    formLogin.classList.add("active");
})
*/
const btngoHome = document.querySelector(".auth-form__controls-back");
function goHome() {
    window.location.href = 'home.aspx';
}

// Xử lý kiểm tra dữ liệu nhập vào
function validateInput() {
    const emailOrPhone = document.getElementById("emailOrPhone").value;
    const userName = document.getElementById("userName").value;
    const password = document.getElementById("passWordRes").value;
    const confirmPassword = document.getElementById("passWordResA").value;
    const errorLabel = document.getElementById("lbCheckEmailOrP");
    const userNameErrorLabel = document.getElementById("lbCheckUserName");
    const passwordErrorLabel = document.getElementById("lbcheckpassWordRes");
    const confirmPasswordErrorLabel = document.getElementById("lcCheckPassA");


    // Reset thông báo lỗi
    if (errorLabel) errorLabel.innerText = "";
    if (userNameErrorLabel) userNameErrorLabel.innerText = "";
    if (passwordErrorLabel) passwordErrorLabel.innerText = "";
    if (confirmPasswordErrorLabel) confirmPasswordErrorLabel.innerText = "";

    // Kiểm tra dữ liệu nhập vào
    if (emailOrPhone.trim() === "") {
        errorLabel.innerText = "Vui lòng nhập email hoặc số điện thoại!";
        return false; // Ngăn chặn gửi form
    }
    else if (!/^[a-zA-Z][a-zA-Z0-9]*@[a-zA-Z]{1,5}\.[a-zA-Z]{2,}$/.test(emailOrPhone) &&
        !/^0\d{9}$/.test(emailOrPhone)) {
        errorLabel.innerText = "Email hoặc số điện thoại không hợp lệ!";
        return false; // Ngăn chặn gửi form
    }

    if (userName.trim() === "") {
        userNameErrorLabel.innerText = "Vui lòng nhập họ và tên!";
        return false; // Ngăn chặn gửi form
    } else if (!/^[\p{L}\s]+$/u.test(userName)) {
        userNameErrorLabel.innerText = "Họ và tên chỉ được phép chứa chữ cái!";
        return false; // Ngăn chặn gửi form
    }
    // Check Mật khẩu
    if (password.trim() === "") {
        passwordErrorLabel.innerText = "Vui lòng nhập mật khẩu!";
        return false; // Ngăn chặn gửi form
    } else if (password.length < 8) {
        passwordErrorLabel.innerText = "Mật khẩu phải có ít nhất 8 kí tự!!!";
        return false; // Ngăn chặn gửi form
    } else if (!/^[a-zA-Z]/.test(password)) {
        passwordErrorLabel.innerText = "Mật khẩu phải bắt đầu bằng một chữ cái!";
        return false; // Ngăn chặn gửi form
    } else if (!/[!@#$%^&*]/.test(password)) {
        passwordErrorLabel.innerText = "Mật khẩu phải có ít nhất 1 kí tự đặc biệt!";
        return false; // Ngăn chặn gửi form
    }

    if (password !== confirmPassword) {
        confirmPasswordErrorLabel.innerText = "Mật khẩu không khớp!";
        return false; // Ngăn chặn gửi form
    }

    return true; // Cho phép gửi form
}

// Xử lý kiểm tra dữ liệu nhập vào Login
function validateInputLogin() {

    const userName = document.getElementById("emailOrPhoneLogin").value;
    const password = document.getElementById("passLogin").value;
    const userNameErrorLabel = document.getElementById("lbCheckEmailOrPhoneLogin");
    const passwordErrorLabel = document.getElementById("lbCheckPassLogin");


    // Reset thông báo lỗi
    if (userNameErrorLabel) userNameErrorLabel.innerText = "";
    if (passwordErrorLabel) passwordErrorLabel.innerText = "";

    // Kiểm tra dữ liệu nhập vào
    if (userName.trim() === "") {
        userNameErrorLabel.innerText = "Vui lòng nhập email hoặc số điện thoại!";
        return false; // Ngăn chặn gửi form
    }

    // Check Mật khẩu
    if (password.trim() === "") {
        passwordErrorLabel.innerText = "Vui lòng nhập mật khẩu!";
        return false; // Ngăn chặn gửi form
    }

    return true; // Cho phép gửi form
}

// Đăng xuất
function logoutClick() {
    // Hiển thị hộp thoại xác nhận
    if (confirm("Bạn có muốn đăng xuất không?")) {
        // Ẩn thẻ userNameHomeLogin
        document.getElementById("userNameHomeLogin").style.display = "none";

        // Hiển thị thẻ login và register
        document.getElementById("spanLogin").style.display = "block";
        document.getElementById("spanRegister").style.display = "block";

        // Chuyển hướng đến trang home.aspx
        window.location.href = "LogoutPage.aspx";
    }
}