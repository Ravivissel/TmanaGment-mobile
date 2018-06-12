let configuration = {
    host: "http://10.80.4.187"+":",
    port: 5000,
}

function loginCheck(request, successCB, errorCB) {
    var route = '/api/login';
    var url = configuration.host + configuration.port + route;
    // serialize the object to JSON string
    var dataString = JSON.stringify(request);

    $.ajax({ // ajax call starts
        url: url,       // server side web service method
        data: dataString,                          // the parameters sent to the server
        type: 'POST',                              // can be also GET
        dataType: 'json',                          // expecting JSON datatype from the server
        contentType: 'application/json; charset = utf-8', // sent to the server
        success: successCB,                // data.d id the Variable data contains the data we get from serverside
        error: errorCB
    }); // end of ajax call
}

function GetProjects(request, successCB, errorCB) {
    var route = '/api/openProjects';
    var url = configuration.host + configuration.port + route;
    // serialize the object to JSON string
    var dataString = JSON.stringify(request);

    $.ajax({ // ajax call starts
        url: url,       // server side web service method
        data: dataString,                          // the parameters sent to the server
        type: 'POST',                              // can be also GET
        dataType: 'json',                          // expecting JSON datatype from the server
        contentType: 'application/json; charset = utf-8', // sent to the server
        success: successCB,                // data.d id the Variable data contains the data we get from serverside
        error: errorCB
    }); // end of ajax call
}

function GetRequests(successCB, errorCB) {
    var route = '/api/Requests';
    var url = configuration.host + configuration.port + route;

    $.ajax({ // ajax call starts
        url: url,
        headers: { 'Accept': 'application/json' },
        async: true,
        success: successCB,                // data.d id the Variable data contains the data we get from serverside
        error: errorCB
    }); // end of ajax call
}

function getAllTasks(successCB, errorCB) {
    var route = '/api/ActualTasks';
    var url = configuration.host + configuration.port + route;

    $.ajax({ // ajax call starts
        url: url,       // server side web service method
        type: 'Get',                              // can be also GET
        dataType: 'json',                          // expecting JSON datatype from the server
        contentType: 'application/json; charset = utf-8', // sent to the server
        success: successCB,                // data.d id the Variable data contains the data we get from serverside
        error: errorCB
    }); // end of ajax call
}

function GetEmployees(successCB, errorCB) {
    var route = '/api/employees';
    var url = configuration.host + configuration.port + route;

    $.ajax({ // ajax call starts
        url: url,       // server side web service method
        type: 'Get',                              // can be also GET
        dataType: 'json',                          // expecting JSON datatype from the server
        contentType: 'application/json; charset = utf-8', // sent to the server
        success: successCB,                // data.d id the Variable data contains the data we get from serverside
        error: errorCB
    }); // end of ajax call
}
