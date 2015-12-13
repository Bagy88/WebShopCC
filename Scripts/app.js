$(document).ready(function () {
    var ViewModel = function () {
        var self = this;
        self.carts = ko.observableArray();
        self.error = ko.observable();

        var cartsUri = '/api/carts/';

        function ajaxHelper(uri, method, data) {
            self.error(''); // Clear error message
            return $.ajax({
                type: method,
                url: uri,
                dataType: 'json',
                contentType: 'application/json',
                data: data ? JSON.stringify(data) : null
            }).fail(function (jqXHR, textStatus, errorThrown) {
                self.error(errorThrown);
            });
        }

        function getCart() {
            ajaxHelper(cartsUri, 'GET').done(function (data) {
                self.carts(data);
            });
        }

        // Fetch the initial data.
        getCart();
    };

    ko.applyBindings(new ViewModel());
});