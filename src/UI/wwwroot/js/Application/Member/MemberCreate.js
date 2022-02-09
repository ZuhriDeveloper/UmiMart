
function displayErrorMessage(message) {

    var str_array = message.split('.');

    for (var i = 0; i < str_array.length; i++) {
        str_array[i] = str_array[i].replace(/^\s*/, "").replace(/\s*$/, "");
        if (str_array[i] != "") {
            $('#rentMember-error-content ul').append('<li>' + str_array[i] + '</li>');
        }
    }
    $('#infoModal').modal('show');
}

function displayInfoMessage(message) {
    $('#rentMember-info-content').html(message);
    $('#infoModal').modal('show');
}

