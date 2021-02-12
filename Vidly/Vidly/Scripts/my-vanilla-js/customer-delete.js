//const customerTable = document.getElementById('customer');
const customerTable = document.querySelector('#customer .table');

//Adding Datatable functionality to my Customer Table
$(customerTable).DataTable();

customerTable.addEventListener('click', e => {

    if (e.target.classList.contains('js-delete')) {
        bootbox.confirm("Are your sure you want to delete this customer?",
            result => {
                if (result) {
                    let customerId = e.target.getAttribute('data-customer-id');
                    let url = `/Customer/Delete/${customerId}`;

                    remove(url).then(data => {
                        console.log(data);
                        if (data === 'success') {
                            e.target.parentElement.parentElement.remove();
                        }
                    }).catch(err => console.log(err));
                }
            });
    }
});

//Get Request
async function get(url) {
    let response = await fetch(url);
    let result = await response.json();
    return result;
}

//Delete Request
async function remove(url)
{
    let response = await fetch(url,
        {
            method: 'DELETE',
            headers: {
                'content-type': 'Application/json'
            }
        });

    let result = 'success';
    return result;
}

//Post Request
//async function post(url, data) {
//    let response = await fetch(url,
//        {
//            method: 'POST',
//            headers: {
//                'Content-type': 'Applictaion/json'
//            },
//            body: JSON.stringify(data)
//        });
//    let result = await response.json();
//    return result;
//}
