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

login.addEventListener("click", function (e) {
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

modalBody.addEventListener("click", function (e) {
    e.preventDefault();
    //e.target là phần tử mà người dùng đã nhấn vào. trả về true
    if (!formLogin.contains(e.target) && !formRegister.contains(e.target)) {
        modal.classList.remove("active");
    }
})

// Đăng nhập khi ấn vào form đăng ký
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

// Đăng nhập trên mobile
const loginMobile = document.querySelector(".header__login-mobile");

loginMobile.addEventListener("click", function (e) {
    e.preventDefault();
    modal.classList.add("active");
    if (formRegister.classList.contains("active")) {
        formRegister.classList.remove("active");
    }
    formLogin.classList.add("active");
})