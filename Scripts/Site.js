function Success(message) {
    $.notify({
        // options
        message: message
    }, {
        // settings
        type: 'Success'
    });
}

function Info(message) {
    $.notify({
        // options
        message: message
    }, {
        // settings
        type: 'Info'
    });
}

function Warning(message) {
    $.notify({
        // options
        message: message
    }, {
        // settings
        type: 'Warning'
    });
}

function Danger(message) {
    $.notify({
        // options
        message: message
    }, {
        // settings
        type: 'Danger'
    });
}