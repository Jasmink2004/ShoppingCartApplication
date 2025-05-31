// For AJAX updates (optional)
document.querySelectorAll('.quantity-update').forEach(input => {
    input.addEventListener('change', async function () {
        const productId = this.dataset.productId;
        const response = await fetch(`/Cart/Update?productId=${productId}&quantity=${this.value}`);
        if (response.ok) location.reload();
    });
});
