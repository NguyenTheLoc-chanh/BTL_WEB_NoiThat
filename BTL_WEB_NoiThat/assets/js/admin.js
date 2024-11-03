// Hàm hiển thị giao diện quản lý tương ứng
function showContent(contentId) {
    // Ẩn tất cả các giao diện đang hiển thị
    var contents = document.getElementsByClassName("content");
    for (var i = 0; i < contents.length; i++) {
        contents[i].classList.remove("active");
    }

    // Hiển thị lên giao diện được chọn
    document.getElementById(contentId).classList.add("active");

    // Cập nhật URL để giữ tab hiện tại
    window.history.pushState(null, null, 'adminPage.aspx?currentTab=${contentId}')
}

// Gọi hàm này khi trang được tải
window.onload = function () {
    const urlParams = new URLSearchParams(window.location.search);
    const currentTab = urlParams.get('currentTab'); // Đặt mặc định là 'products'
    showContent(currentTab);
};

// Mở form Product
function openProductForm() {
    document.getElementById("productForm").style.display = "block";
}
function closeProductForm() {
    document.getElementById("productForm").style.display = "none";
}

// Edit Product
function editProduct(idPro, namePro, pricePro, stockPro, infoPro, imgPro, imgDetail1, imgDetail2, imgDetail3) {
    document.getElementById("editProductId").value = idPro;
    document.getElementById("productName").value = namePro;
    document.getElementById("proPrice").value = pricePro;
    document.getElementById("proStock").value = stockPro;
    document.getElementById("proDescription").value = infoPro;
    document.getElementById("proImageUrl").value = imgPro;
    document.getElementById("proListThumb").value = imgDetail1 + "," + imgDetail2 + "," + imgDetail3;
    document.getElementById("editProductForm").style.display = "block";
}
function closeEditProductForm() {
    document.getElementById("editProductForm").style.display = "none";
}

// Delete Product 
function deleteProduct(idProduct) {
    if (confirm("Bạn có chắc chắn muốn xóa sản phẩm này?")) {
        window.location.href = `adminPage.aspx?deleteId=${idProduct}`;
    }
}
// Mở form Add User
function openForm() {
    document.getElementById("userForm").style.display = "block";
}
function closeForm() {
    document.getElementById("userForm").style.display = "none";
}
function editUser(userId,fullName, password) {
    document.getElementById("editUserId").value = userId;
    document.getElementById("editFullName").value = fullName;
    document.getElementById("editPassword").value = password;
    document.getElementById("editUserForm").style.display = "block";
}

function closeEditUserForm() {
    document.getElementById("editUserForm").style.display = "none";
}

function deleteUser(userId) {
    if (confirm("Bạn có chắc chắn muốn xóa người dùng này?")) {
        window.location.href = `adminPage.aspx?deleteId_User=${userId}`;
    }
}
// Logut
function logout() {
    // Thực hiện điều hướng tới trang đăng xuất
    if (confirm("Bạn có chắc muốn đăng xuất?")) {
        window.location.href = "loginPage.aspx";
    }
}

// Xử lý kiểm tra dữ liệu nhập vào
function validateInput() {
    const emailOrPhone = document.getElementById("nameRegister").value;
    const userName = document.getElementById("username").value;
    const password = document.getElementById("password").value;

    const errorLabel = document.getElementById("lbNameRes");
    const userNameErrorLabel = document.getElementById("lbFullName");
    const passwordErrorLabel = document.getElementById("lbPassWord");


    // Reset thông báo lỗi
    if (errorLabel) errorLabel.innerText = "";
    if (userNameErrorLabel) userNameErrorLabel.innerText = "";
    if (passwordErrorLabel) passwordErrorLabel.innerText = "";

    // Kiểm tra full Name
    if (userName.trim() === "") {
        userNameErrorLabel.innerText = "Vui lòng nhập họ và tên!";
        return false; // Ngăn chặn gửi form
    } else if (!/^[\p{L}\s]+$/u.test(userName)) {
        userNameErrorLabel.innerText = "Họ và tên chỉ được phép chứa chữ cái!";
        return false; // Ngăn chặn gửi form
    }

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

    return true; // Cho phép gửi form
}