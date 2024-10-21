const spanDecrease = document.querySelectorAll('.cart-info-subtract');
const spanIncrease = document.querySelectorAll('.cart-info-plus');
const spanQuantity = document.querySelectorAll('.cart-info-number');

if (spanDecrease) {
    spanDecrease.forEach(btn => {
        btn.addEventListener('click', () => {
            var productID = btn.getAttribute('data-product-id');
            let quantitySpan = document.querySelector(`span[data-product-id='${productID}'][max]`);
            let CurrentValue = parseInt(quantitySpan.innerHTML);

            if (CurrentValue > 1) {
                CurrentValue--;
                quantitySpan.innerHTML = CurrentValue;
                window.location.href = `UpdateQuantityInCart.aspx?id=${productID}&quantity=${CurrentValue}`;
            }
        })
    })
}

if (spanIncrease) {
    spanIncrease.forEach(btn => {
        btn.addEventListener('click', () => {
            var productID = btn.getAttribute('data-product-id');
            let quantitySpan = document.querySelector(`span[data-product-id='${productID}'][max]`);

            let CurrentValue = parseInt(quantitySpan.innerHTML);
            let maxvalue = parseInt(quantitySpan.getAttribute('max'));

            if (CurrentValue + 1 <= maxvalue) {
                CurrentValue++;
                quantitySpan.innerHTML = CurrentValue;

                window.location.href = `UpdateQuantityInCart.aspx?id=${productID}&quantity=${CurrentValue}`;
            } else {
                console.log('Số lượng đã hết!');
            }
        })
    })
}