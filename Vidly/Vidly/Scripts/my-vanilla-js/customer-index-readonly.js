const customerTable = document.querySelector('#customer .table');

//  Adding DataTable functionality to my Customer Table
const dataTable = $(customerTable).DataTable();

//Document Load Event
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
                customer.name,
                customer.membershipType.name,
                GetMonths(customer.membershipType.durationInMonths),
                `${customer.membershipType.signUpFee}$`,
                `${customer.membershipType.discountRate}%`
            ]).draw();
        });
    });
}

function GetMonths(id) {
    switch (id) {
    case 0:
        return "Pay as you go";
    case 1:
        return `${id} Month`;
    default: return `${id} Months`;
    }
}