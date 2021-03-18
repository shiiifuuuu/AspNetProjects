const categoryTable = document.querySelector('#category-list .table');
let dataTable = $(categoryTable).DataTable();

const url = '/api/category/get';
HttpRest.Get(url).then(data => {
    dataTable.clear().draw();
    let count = 0;
    data.forEach(category => {
        console.log(category);
        dataTable.row.add([
            ++count,
            category.Code,
            category.Name,
            'Delete'
        ]).draw();
    });
});

//<thead>
//    <tr>
    //    <th>S#No</th>
    //    <th>Code</th>
    //    <th>Category</th>
    //    <th>Remove</th>
//    </tr>
//</thead>