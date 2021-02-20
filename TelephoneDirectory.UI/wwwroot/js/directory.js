$(document).ready(function () {

    $.ajax({
        type: "GET",
        url: "https://localhost:44311/api/userservice/userservice/getalluserscontacts",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            $("#personTable").DataTable({

                data: data,
                "columns": [
                    { data: "name", "autoWidth": true },
                    { data: "surname", "autoWidth": true },
                    { data: "companyName", "autoWidth": true },

                    {
                        "render": function (data, type, row) {
                            return "<a class='btn btn-primary' onclick=GetContact('" + row.userID + "')   data-toggle='modal' data-target='#showContactModal'>Contact Info</a>";
                        }
                    }
                    ,
                    {
                        "render": function (data, type, row) {
                            return "<a class='btn btn-primary' onclick=AddPerson('" + row.userID + "')  data-toggle='modal' data-target='#addContactModal'>Add Contact Info</a>";
                        }
                    }
                    ,

                    {
                        "render": function (data, type, row) {
                            return "<a  class='btn btn-danger' onclick=DeletePerson('" + row.userID + "')>Delete Person</a > ";
                        }
                    }

                ]

            });
        }
    });


    $("#AddContactBtn").click(function () {
        var PhoneNumber = $("#phoneNumber").val();
        var Email = $("#email").val();
        var Address = $("#address").val();
        var UserID = document.getElementById("personId").innerHTML;

        $.ajax({
            type: "POST",
            url: "https://localhost:44311/api/userservice/userservice/addcontact",
            dataType: "JSON",
            contentType: "application/json; charset-utf-8",
            data: JSON.stringify({ 'PhoneNumber': PhoneNumber, 'Email': Email, 'Address': Address, 'UserID': UserID }),
            success: function (data) {
                window.location.reload();
            }
        });

    });


    $("#AddUserBtn").click(function () {
        var Name = $("#name").val();
        var Surname = $("#surname").val();
        var CompanyName = $("#companyName").val();

        $.ajax({
            type: "POST",
            url: "https://localhost:44311/api/userservice/userservice/adduser",
            dataType: "JSON",
            contentType: "application/json; charset-utf-8",
            data: JSON.stringify({ 'Name': Name, 'Surname': Surname, 'CompanyName': CompanyName }),
            success: function (data) {

                window.location.reload();

            }
        });
    });




    $("#closeBtn").click(function () {
        window.location.reload();
    });



});



function AddPerson(id) {
    document.getElementById('personId').innerHTML = id;

}

function GetContact(userId) {
    $.ajax({
        type: "POST",
        url: "https://localhost:44311/api/userservice/userservice/getcontact",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ 'UserID': userId }),
        success: function (data) {

            if (data != null) {
                $("#contactTable").DataTable({

                    data: data,

                    "columns": [
                        { data: "phoneNumber", "autoWidth": true },
                        { data: "email", "autoWidth": true },
                        { data: "address", "autoWidth": true }
                        ,
                        {
                            "render": function (data, type, row) {
                                return "<a  class='btn btn-danger' onclick=DeleteContact('" + row.id + "')>Delete</a > ";
                            }
                        }


                    ]

                });
            }

        }
    });

}

function DeletePerson(userId) {
    $.ajax({
        type: "POST",
        url: "https://localhost:44311/api/userservice/userservice/deleteuser",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ 'UserID': userId }),
        success: function (data) {
            window.location.reload();
        }
    });
}

function DeleteContact(id) {
    var ID = Number(id);

    $.ajax({
        type: "POST",
        url: "https://localhost:44311/api/userservice/userservice/deletecontact",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ 'ID': ID }),
        success: function (data) {
            window.location.reload();
        }
    });

}

