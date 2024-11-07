<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="BTL_WEB_NoiThat.adminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>ADMIN</title>
    <link rel="stylesheet" href="./assets/css/admin.css"/>
    <link rel="stylesheet" href="./assets/css/responsive.css"/>
    <script src="./assets/js/admin.js"></script>
</head>
<body>
    <div class="grid wide">
        <div class="sidebar">
            <a href="#" onclick="showContent('home')"><i class="fas fa-home"></i> Trang chủ</a>
            <a href="#" onclick="showContent('products')"><i class="fas fa-dog"></i> Quản lý sản phẩm</a>
            <a href="#" onclick="showContent('users')"><i class="fas fa-shopping-cart"></i> Quản lý người dùng</a>
            <a href="#" onclick="showContent('customers')"><i class="fas fa-users"></i> Quản lý admin</a>
            <a href="#" onclick="showContent('reports')"><i class="fas fa-chart-line"></i> Báo cáo</a>
            <a href="#" onclick="logout()"><i class="fas fa-sign-out-alt"></i> Đăng xuất</a>
        </div>
    
        <div class="main-content">
            <div class="header">
                <h1>Quản Lý Cửa Hàng Nội Thất</h1>
                <a href='home.aspx'>
                    <img class="logo" src="./assets/img/logoTN-01 1.png" alt="" width="50" height="50"/>
                </a>
            </div>
            <!-- Nội dung trang chủ -->
            <div id="home" class="content active">
                <h2>Trang chủ</h2>
                <p>Chào mừng bạn đến với trang quản lý cửa hàng nội thất.</p>
            </div>
            <!-- Nội dung quản lý sản phẩm -->
            <div id="products" class="content">
                <h2>Danh sách sản phẩm</h2>
                <button class="btnAddPro" onclick="openProductForm()">Thêm sản phẩm</button>
                <table>
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Tên sản phẩm</th>
                            <th>Giá</th>
                            <th>Stock</th>
                            <th>Miêu tả</th>
                            <th>Ảnh</th>
                            <th>Ảnh liên quan</th>
                            <td>Thao tác</td>
                        </tr>
                    </thead>
                    <tbody id="productTableBody" runat="server">
    
                    </tbody>
                </table>
            </div>
            <!-- Nội dung quản lý người dùng -->
            <div id="users" class="content">
                <h2>Quản lý người dùng</h2>
                <button class="btnAddPro" onclick="openForm()">Thêm người dùng</button>
                <table>
                    <thead>
                        <tr>
                            <th>Họ tên</th>
                            <th>UserName</th>
                            <th>Password</th>
                            <td>Thao tác</td>
                        </tr>
                    </thead>
                    <tbody id="userTableBody" runat="server">
    
                    </tbody>
                </table>
            </div>
    
            <!-- Nội dung quản lý tài khoản admin -->
            <div id="customers" class="content">
                <h2>Quản lý admin</h2>
                <p>Danh sách admin sẽ được hiển thị ở đây.</p>
            </div>
    
            <!-- Nội dung báo cáo -->
            <div id="reports" class="content">
                <h2>Báo cáo</h2>
                <p>Thông tin báo cáo sẽ được hiển thị ở đây.</p>
            </div>
        </div>
        <!-- Form thêm người dùng -->
        <div id="userForm" class="form-popup">
            <h2>Thêm người dùng</h2>
            <form action="adminPage.aspx" method="post">
                <label for="username">Họ tên</label>
                <input type="text" id="username" name="username" required />
                <asp:Label CssClass="error" ID="lbFullName" runat="server"></asp:Label>

                <label for="nameRegister">Tên đăng nhập</label>
                <input type="text" id="nameRegister" name="nameRegister" required />
                <asp:Label CssClass="error" ID="lbNameRes" runat="server"></asp:Label>

                <label for="password">Mật khẩu</label>
                <input type="password" id="password" name="password" required />
                <asp:Label CssClass="error" ID="lbPassWord" runat="server"></asp:Label>

                <!-- <label for="idConfirm">Mã xác nhận</label>
                <input type="password" id="idConfirm" name="Confirm" required />
                <asp:Label CssClass="error" ID="lbConfirm" runat="server"></asp:Label> -->
                <button type="submit" name="action" value="addUser" onclick="return validateInput();">Thêm người dùng</button>
                <button type="button" class="btn cancel" onclick="closeForm()">Hủy</button>
            </form>
        </div>
        
        <!-- Form sửa người dùng -->
        <div id="editUserForm" class="form-popup">
            <h2>Sửa người dùng</h2>
            <form action="adminPage.aspx" method="post">
                <input type="hidden" id="editUserId" name="userId" />
                <label for="editFullName">Họ tên</label>
                <input type="text" id="editFullName" name="fullName" required />
                <label for="editPassword">Mật khẩu</label>
                <input type="password" id="editPassword" name="password" required />
                <button type="submit" name="action" value="editUser">Cập nhật</button>
                <button type="button" class="btn cancel" onclick="closeEditUserForm()">Hủy</button>
            </form>
        </div>
    
        <!-- Form thêm sản phẩm -->
        <div id="productForm" class="form-popup">
            <h2>Thêm sản phẩm mới</h2>
            <form action="adminPage.aspx" method="post">
                <label for="productId">ID Sản phẩm</label>
                <input type="text" id="productId" name="productId" required />
                <label for="addProductName">Tên sản phẩm</label>
                <input type="text" id="addProductName" name="productName" required />
                <label for="addPrice">Giá</label>
                <input type="number" id="addPrice" name="price" required />
                <label for="addStock">Stock</label>
                <input type="number" id="addStock" name="stock" required />
                <label for="addDescription">Miêu tả</label>
                <textarea id="addDescription" name="description" required></textarea>
                <label for="addImageUrl">Ảnh chính</label>
                <input type="text" id="addImageUrl" name="imageUrl" />
                <label for="addListThumb">Ảnh kèm theo (cách nhau bằng dấu phẩy)</label>
                <input type="text" id="addListThumb" name="listThumb" placeholder="URL ảnh kèm theo" />
                <button type="submit" name="action" value="addProduct">Thêm sản phẩm</button>
                <button type="button" class="btn cancel" onclick="closeProductForm()">Hủy</button>
            </form>
        </div>
    
        <!-- Form sửa sản phẩm -->
        <div id="editProductForm" class="form-popup">
            <h2>Sửa sản phẩm</h2>
            <form action="adminPage.aspx" method="post">
                <input type="hidden" id="editProductId" name="productId" />
                <label for="addProductName">Tên sản phẩm</label>
                <input type="text" id="productName" name="productName" required />
                <label for="addPrice">Giá</label>
                <input type="number" id="proPrice" name="price" required />
                <label for="addStock">Stock</label>
                <input type="number" id="proStock" name="stock" required />
                <label for="addDescription">Miêu tả</label>
                <textarea id="proDescription" name="description" required></textarea>
                <label for="addImageUrl">Ảnh chính</label>
                <input type="text" id="proImageUrl" name="imageUrl" />
                <label for="addListThumb">Ảnh kèm theo (cách nhau bằng dấu phẩy)</label>
                <input type="text" id="proListThumb" name="listThumb" placeholder="URL ảnh kèm theo" />
                <button type="submit" name="action" value="editProduct">Cập nhật</button>
                <button type="button" class="btn cancel" onclick="closeEditProductForm()">Hủy</button>
            </form>
        </div>
    </div>
</body>
</html>
