function test() {
    console.log('posting to graphQL');
    
    var data = { "query": "query { hero { id name } }"};

    var url = 'http://localhost/StarWars.Api/graphql';

    var f = function(data, status) {
        alert("Data: " + data + "\nStatus: " + status);
    };

    $.ajax({
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        'type': 'POST',
        'url': url,
        'data': JSON.stringify(data),
        'dataType': 'json',
        'success': f
    });

    return false;
}
