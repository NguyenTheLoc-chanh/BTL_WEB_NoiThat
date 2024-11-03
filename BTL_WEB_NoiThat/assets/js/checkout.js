const districtsByCity = {
    hanoi: [
        { value: "dongda", name: "Đống Đa" },
        { value: "hoankiem", name: "Hoàn Kiếm" },
        { value: "haiBaTrung", name: "Hai Bà Trưng" }
    ],
    hcm: [
        { value: "1", name: "Quận 1" },
        { value: "3", name: "Quận 3" },
        { value: "7", name: "Quận 7" }
    ],
    bacgiang: [
        { value: "langgiang", name: "Lạng Giang" },
        { value: "yenthe", name: "Yên Thế" }
    ]
};

const wardByDistrict = {
    dongda: [
        { value: "trungtu", name: "Trung Tự" },
        { value: "khuongthuong", name: "Khương Thượng" },
        { value: "vanmieu", name: "Văn Miếu" }
    ],
    hoankiem: [
        { value: "hangma", name: "Hàng Mã" },
        { value: "hangdao", name: "Hàng Đào" },
        { value: "lythaito", name: "Lý Thái Tổ" },
        { value: "chuongduong", name: "Chương Dương" },
        { value: "hangbong", name: "Hàng Bông" }
    ],
    haiBaTrung: [
        { value: "minhkhai", name: "Minh Khai" },
        { value: "truongdinh", name: "Trương Định" },
        { value: "vinhtuy", name: "Vĩnh Tuy" },
        { value: "bachmai", name: "Bạch Mai" }
    ],
    1: [
        { value: "benthanh", name: "Bến Thành" },
        { value: "tandinh", name: "Tân Định" },
        { value: "caukho", name: "Cầu Kho" },
        { value: "nguyenthaibinh", name: "Nguyễn Thái Bình" }
    ],
    3: [
        { value: "1", name: "Phường 1" },
        { value: "2", name: "Phường 2" },
        { value: "3", name: "Phường 3" },
        { value: "4", name: "Phường 4" }
    ],
    7: [
        { value: "binhthuan", name: "Phường Bình Thuận" },
        { value: "phumy", name: "Phường Phú Mỹ" },
        { value: "phuthuan", name: "Phường Phú Thuận" },
        { value: "tanhung", name: "Phường Tân Hưng" }
    ],
    langgiang: [
        { value: "anha", name: "Xã An Hà" },
        { value: "duongduc", name: "Xã Dương Đức" },
        { value: "huonglac", name: "Xã Hương Lạc" },
        { value: "nghiahoa", name: "Xã Nghĩa Hòa" }
    ],
    yenthe: [
        { value: "anthuong", name: "Xã An Thượng" },
        { value: "donglac", name: "Xã Đồng Lạc" }
    ]
};

function updateDistricts() {
    const citySelect = document.getElementById("city");
    const districtSelect = document.getElementById("district");
    const selectedCity = citySelect.value;

    // Clear the district dropdown
    districtSelect.innerHTML = '<option value="">Quận / huyện</option>';

    // Populate the district dropdown based on the selected city
    if (districtsByCity[selectedCity]) {
        districtsByCity[selectedCity].forEach(district => {
            const option = document.createElement("option");
            option.value = district.value;
            option.textContent = district.name;
            districtSelect.appendChild(option);
        });
    }
}

function updateWard() {
    const wardSelect = document.getElementById("ward");
    const districtSelect = document.getElementById("district");
    const selectedDisctrict = districtSelect.value;

    // Clear the district dropdown
    wardSelect.innerHTML = ' <option value="""">Phường / xã</option>';

    // Populate the district dropdown based on the selected city
    if (wardByDistrict[selectedDisctrict]) {
        wardByDistrict[selectedDisctrict].forEach(district => {
            const option = document.createElement("option");
            option.value = district.value;
            option.textContent = district.name;
            wardSelect.appendChild(option);
        });
    }
}


const btnUsingCoupon = document.getElementById('use-coupon-btn');

if (btnUsingCoupon) {
    btnUsingCoupon.addEventListener('click', function () {
        const name = document.querySelector('input[name="name"]').value;
        const email = document.querySelector('input[name="email"]').value;
        const phone = document.querySelector('input[name="phone"]').value;
        const address = document.querySelector('input[name="address"]').value;
        const city = document.querySelector('select[name="city"]').value;
        const district = document.querySelector('select[name="district"]').value;
        const ward = document.querySelector('select[name="ward"]').value;
        const paymentMethod = document.querySelector('input[name="payment"]:checked').value;
        const couponCode = document.querySelector('input[name="couponCode"]').value; // Assuming you have an input for the coupon code

        const form = document.createElement('form');
        form.action = 'HandleUsingCoupon.aspx';
        form.method = 'POST';

        const inputs = [
            { name: 'name', value: name },
            { name: 'email', value: email },
            { name: 'phone', value: phone },
            { name: 'address', value: address },
            { name: 'city', value: city },
            { name: 'district', value: district },
            { name: 'ward', value: ward },
            { name: 'paymentMethod', value: paymentMethod },
            { name: 'couponCode', value: couponCode }
        ];


        inputs.forEach(input => {
            const hiddenInput = document.createElement('input');
            hiddenInput.type = 'hidden';
            hiddenInput.name = input.name;
            hiddenInput.value = input.value;
            form.appendChild(hiddenInput);
        });

        document.body.appendChild(form);
        form.submit();
    });
}
