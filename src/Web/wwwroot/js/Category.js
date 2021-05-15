﻿$(document).ready(function () {
    $("#datatableCategories").DataTable({
        serverSide: true,
        responsive: true,
        ajax: {
            url: "/Categories/Datatables",
            type: "POST",
            datatype: "json"
        },
        columns: [
            {
                title: "Name",
                autoWidth: true,
                data: "name"
            },
            {
                title: "Total Entrances",
                autoWidth: true,
                data: data => FormatValueAsMoney(data.total)
            },
            {
                title: "Created At",
                autoWidth: true,
                data: data => FormatValueAsDate(data.createdAt)
            },
            {
                orderable: false,
                data: data => {
                    if (data.userId !== "00000000-0000-0000-0000-000000000000") {
                        return `<a href='Categories/Edit/${data.id}' class='btn btn-primary btn-sm'>Edit</a>`
                    }
                    return ''
                }
            },
        ]
    })
})
