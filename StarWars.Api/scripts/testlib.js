var TestLib = function () {

    this.url = 'http://localhost/StarWars.Api/';
    this.data;
}

TestLib.prototype = {

    fixDate : function(date) {


        var parts = date.split(' ');

        if (parts.length > 0) {
            var date = parts[0];
            var time = parts[1];

            var dateParts = date.split('/');

            var day = dateParts[0];
            var month = dateParts[1];
            var year = dateParts[2];

            //'2017-05-05T00:00:00'

            date = year + '-' + month + '-' + day + 'T' + time;
        }

        return date;
    },

    loadUrl : function() {

     //   this.url = 'http://' + window.location.hostname + '/CAPI/';
   //     $("#serviceAddress").val(this.url);
    },

    writeLine: function (label, text) {

        var existingText = $("#result").val();
        var oldheight = $("#result").height();

        var rowHeight = 22;

        if (text.length > 200) rowHeight = 44;
        if (text.length > 300) rowHeight = 66;

        var newText = existingText + '\n' + label + ' ' + text;

        $("#result").height(oldheight + rowHeight);
        $("#result").val(newText);
    },
    
    reset :function() {
        $("#result").height(50);
        $("#result").val('');
        $("#prettyResult").html('');
        $("#prettyResult").height(50);
    },
    
    getUrl: function () {                      
        return this.url;
    },
    setUrl: function (url) {
        this.url = url;
    },
    getData: function () {

        var data;

        var rawData = $("#serviceData").text();

        if (rawData !== '') {
            data = JSON.parse(rawData);
        }

        return data;
    },


    success: function(xhr, textStatus) {
        hljs.initHighlightingOnLoad();
      
        var stringify = JSON.stringify(xhr, undefined, 2);
        var prettify = hljs.highlightAuto(stringify).value;
        prettify = hljs.fixMarkup(prettify);

        this.writeLine('STATUS: ', textStatus);
      
        $("#prettyResult").html(prettify);
    },

    error: function(jqXHR, exception) {
        this.writeLine('STATUS: ', exception);
        this.writeLine('jqXHR', parseError(jqXHR, exception));
    },

    ajaxget: function (url, data) {

        var that = this;

        $.ajaxSetup({ cache: false });

        $.ajax({
            url: url,
            dataType: "json",

            type: "GET",
            success: $.proxy(that.success, that),
            error: $.proxy(that.error, that),

            timeout: 3000000 // sets timeout to 3 seconds
        });


    },

    ajaxpost: function (url, data) {

        var that = this;

        //$.ajaxSetup({ cache: false });

        //$.ajax({
        //    url: url,
        //    dataType: "json",

        //    type: "GET",
        //    success: $.proxy(that.success, that),
        //    error: $.proxy(that.error, that),

        //    timeout: 3000000 // sets timeout to 3 seconds
        //});

     //   var data = { "query": "query { hero { id name } }" };

      //  var url = 'http://localhost/StarWars.Api/graphql';

     //   var f = function (data, status) {
     //       alert("Data: " + data + "\nStatus: " + status);
      //  };

        $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            'type': 'POST',
            'url': url,
            'data': JSON.stringify(data),
            'dataType': 'json',
            'success': $.proxy(that.success, that)
        });
    }


};

 

function arraytocsvstring(array) {

    var idx = 0;
    var retStr = '';

    while (idx < array.length) {
        retStr += array[idx];

        if (idx !== (array.length - 1)) {
            retStr += ',';
        }

        idx++;
    }

    return retStr;
}


function success(xhr, textStatus) {
    hljs.initHighlightingOnLoad();



    // set prettytext
    //var data = JSON.parse(xhr);
    var stringify = JSON.stringify(xhr, undefined, 2);
    var prettify = hljs.highlightAuto(stringify).value;
    prettify = hljs.fixMarkup(prettify);

    writeLine('STATUS: ', textStatus);
    //	writeLine('RESPONSE: ', prettify);
    $("#prettyResult").html(prettify);
}

function error(jqXHR, exception) {
    writeLine('STATUS: ', exception);
    writeLine('jqXHR', parseError(jqXHR, exception));
}

function getUrl() {
    //return "http://www.gendb.net/';
    return "http://wtreportsrv01/CAPI/";
}

function getByPost() {

    var username = 'hello';
    var password = 'george';

    var p = {
        loginInfo: { username: username, password: password }
    };

    $.ajax({
        url: getUrl() + "test/",
        dataType: "json",

        type: "POST",
        data: { username: username, password: password },



        complete: function (xhr, textStatus) {
            //     // set status
            $("#status").html(textStatus);

            //    // set plaintext
            $("#result").val(xhr.responseText);

            // set prettytext
            var data = JSON.parse(xhr.responseText);
            var stringify = JSON.stringify(data, undefined, 2);
            var prettify = hljs.highlightAuto(stringify).value;
            prettify = hljs.fixMarkup(prettify);
            $("#prettyResult").html(prettify);
        }
    });
};



function parseError(jqXHR, exception) {
    var msg = '';
    if (jqXHR.status === 0) {
        msg = 'Not connect.\n Verify Network.';
    } else if (jqXHR.status == 404) {
        msg = 'Requested page not found. [404]';
    } else if (jqXHR.status == 500) {
        msg = 'Internal Server Error [500].';
    } else if (exception === 'parsererror') {
        msg = 'Requested JSON parse failed.';
    } else if (exception === 'timeout') {
        msg = 'Time out error.';
    } else if (exception === 'abort') {
        msg = 'Ajax request aborted.';
    } else {
        msg = 'Uncaught Error.\n' + jqXHR.responseText;
    }

    return msg;
}

function resetStyling() {
    $("#result").val('');
    $("#result").height(20);
}

