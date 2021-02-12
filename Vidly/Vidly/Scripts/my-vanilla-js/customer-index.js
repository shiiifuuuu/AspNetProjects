﻿const customerTable = document.querySelector('#customer .table');

//  Adding DataTable functionality to my Customer Table
const dataTable = $(customerTable).DataTable();

document.addEventListener('DOMContentLoaded', ShowAllCustomer);

//Showing All Customer in DataTable
function ShowAllCustomer() {

    //Initially clearing table data
    dataTable.clear().draw();

    //Getting Customer Data From my API
    HttpApi.Get('/api/customers/').then(data => {
        let count = 0;
        data.forEach(customer => {
            dataTable.row.add([
                ++count,
                `<a href="/customer/edit/${customer.id}">${customer.name}</a>`,
                customer.membershipType.name,
                GetMonths(customer.membershipType.durationInMonths),
                `${customer.membershipType.signUpFee}$`,
                `${customer.membershipType.discountRate}%`,
                `<img src="../../Content/Img/btn-delete.svg" class="img-rounded js-delete" data-customer-id=${customer.id}>`
            ]).draw(false);
        });
    });
}

function GetMonths(id)
{
    switch (id) {
    case 0:
        return "Pay as you go";
    case 1:
        return `${id} Month`;
        default: return `${id} Months`;
    }
}

//Delete Customer Event
customerTable.addEventListener('click', e => {
//    console.log(e.target);

    if (e.target.classList.contains('js-delete')) {
        bootbox.confirm("Are your sure you want to delete this customer?",
            result => {
                if (result) {
                    let customerId = e.target.getAttribute('data-customer-id');
                    let url = `/api/customers/${customerId}`;

                    HttpApi.Delete(url).then(data => data).catch(err => err);

                    ShowAllCustomer();
                }
            });
    }
});