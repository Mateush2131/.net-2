document.getElementById('contactForm').addEventListener('submit', async function (e) {
    e.preventDefault();
    const form = e.target;
    const formData = new FormData(form);
    const result = document.getElementById('result');
    result.innerHTML = 'Отправка...';
    try {
        const response = await fetch('/Home/Submit', { method: 'POST', body: formData });
        const data = await response.json();
        if (data.success) {
            result.innerHTML = `<p style="color:green">${data.message}</p>`;
            form.reset();
        } else {
            result.innerHTML = `<p style="color:red">${data.errors.join('<br>')}</p>`;
        }
    } catch (err) {
        result.innerHTML = `<p style="color:red">Ошибка: ${err.message}</p>`;
    }
});
