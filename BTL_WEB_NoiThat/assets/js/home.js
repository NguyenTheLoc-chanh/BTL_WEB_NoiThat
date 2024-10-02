document.addEventListener("DOMContentLoaded", function () {
    const menuMobile = document.querySelector('.menu__mobile');
    const mobileNav = document.querySelector('.header__nav-mobile .header__nav-list');

    menuMobile.addEventListener('click', function () {
        mobileNav.classList.toggle('active')
    })
})