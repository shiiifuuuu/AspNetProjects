HttpRest.Get('/api/category').then(res => {
    console.log(res);
});
const code = document.getElementById('Category_Code');
const name = document.getElementById('Category_Name');
const submitForm = document.getElementById('save-form');
const categoryResponse = document.querySelector('#new-category-response');

submitForm.addEventListener('submit', e => {
    e.preventDefault();
    let data = {
        Code: code.value,
        Name: name.value
    }
    HttpRest.Post('/api/category/', data).then(res => {
        if (res.Id !== 0) {
            console.log(res);
            categoryResponse.innerHTML = `<p class="success">${res.Name} added</p>`;
            submitForm.reset();
        }
    });
});