
$(document).ready(function () {


    $.ajax({
        type: "GET",
        url: "https://localhost:44311/api/report/getreports",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            debugger;
            $("#reportTable").DataTable({

                data: data,
                "columns": [
                    { data: "reportName", "autoWidth": true },
                    { data: "location", "autoWidth": true },
                    { data: "personCount", "autoWidth": true },
                    { data: "phoneCount", "autoWidth": true },
                    { data: "createdDate", "autoWidth": true },
                    { data: "status", "autoWidth": true },
                   
                    {
                        "render": function (data, type, row) {
                            return "<a class='btn btn-primary' onclick=DeleteReport('" + row.id + "')>Delete</a>";
                        }
                    }


                ]

            });
        }
    });



    $("#addnewreport").click(function () {
        var Location = $('#reportLocation').val();
        var ReportName = $('#reportName').val();

        $.ajax({
            type: "POST",
            url: "https://localhost:44311/api/report/addnewreport",
            datatype: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({
                'Location': Location, 'ReportName': ReportName }),
            success: function (data) {

                window.location.reload();
            }
        });
    });





});


function DeleteReport(id) {
    $.ajax({
        type: "DELETE",
        url: "https://localhost:44311/api/report/deletereport",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ 'ID': id }),
        success: function (data) {
            window.location.reload();
        }
    });
}
