//const customerTable = document.getElementById('customer');
const customerTable = document.querySelector('#customer .table');

//Adding DataTable functionality to my Customer Table
$(customerTable).DataTable();

customerTable.addEventListener('click', e => {

    if (e.target.classList.contains('js-delete')) {
        bootbox.confirm("Are your sure you want to delete this customer?",
            result => {
                if (result) {
                    let customerId = e.target.getAttribute('data-customer-id');
                    let url = `/Customer/Delete/${customerId}`;

                    HttpApi.Delete(url).then(data => {
                        if (data === "" || !data.message.includes('error')) {
                            e.target.parentElement.parentElement.remove();
                        }
                    }).catch(err => err);
                }
            });
    }
});