// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var routeURL = location.protocol + "//" + location.host;

// Header Function 
function sendDataUsingHeader() {
    $.ajax({
        url: routeURL + "/api/homeapi/getDataFromHeader",
        type: 'POST',
        headers: {

            Id: $('#studentid').val(),
            Name: $('#studentname').val(),
            Address: $('#studentaddress').val()

        },
        success: function (response) {
            console.log("response", response);
            $('#resultgetDataFromHeader').html(JSON.stringify(response));
        },
        error: function (xhr) {
            console.log("response", xhr);
        }
    });
}

// Query Function
function sendDataUsingQuery() {
    var object = {
        Id: $('#studentid').val(),
        Name: $('#studentname').val(),
        Address: $('#studentaddress').val()
    };
    console.log("Object is: ", object)
    $.ajax({
        url: routeURL + `/api/homeapi/getDataFromQuery?` + (new URLSearchParams(object).toString()) ,
        type: 'POST',

        success: function (response) {
            console.log("response", response);
            $('#resultgetDataQuery').html(JSON.stringify(response));
        },
        error: function (xhr) {
            console.log("response", xhr);
        }
    });
}


// Body Function
function sendDataUsingFromBody() {
    var object = {
        Id: $('#studentid').val(),
        Name: $('#studentname').val(),
        Address: $('#studentaddress').val()
    };

    $.ajax({
        url: routeURL + `/api/homeapi/getDataFromBody` ,
        type: 'POST',
        data: JSON.stringify(object),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',

        success: function (response) {
            console.log("response", response);
            $('#resultgetDataFromBody').html(JSON.stringify(response));
        },
        error: function (xhr) {
            console.log("response", xhr);
        }
    });
}

// Form Function
function sendDataUsingFromForm() {

    $.ajax({
        url: routeURL + `/api/homeapi/getDataFromForm`,
        type: 'POST',
        data: $('#formtosubmit').serialize(),

        success: function (response) {
            console.log("response", response);
            $('#resultgetDataFromForm').html(JSON.stringify(response));
        },
        error: function (xhr) {
            console.log("response", xhr);
        }
    });
}

// Route Function
function sendDataUsingFromRoute() {
    var object = {
        Id: $('#studentid').val(),
        Name: $('#studentname').val(),
        Address: $('#studentaddress').val()
    };
    $.ajax({
        url: routeURL + `/api/homeapi/getDataFromRoute/${object.Id}/${object.Name}/${object.Address}`,
        type: 'POST',

        success: function (response) {
            console.log("response", response);
            $('#resultgetDataRoute').html(JSON.stringify(response));
        },
        error: function (xhr) {
            console.log("response", xhr);
        }
    });
}