var ViewModel = function () {
    var self = this;
    self.users = ko.observableArray();
    self.error = ko.observable();


    var usersUri = '/api/User_Data/';
    var fingerprintsUri = '/api/Fingrprints'

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

    function getAllUsers() {
        ajaxHelper(usersUri, 'GET').done(function (data) {
            self.users(data);
        });
    }

    // Fetch the initial data.
    getAllUsers();

    self.newUser = {

    Id: ko.observable(),
    First_Name: ko.observable(),
    Last_Name: ko.observable(),
    Age: ko.observable(),
    Gender: ko.observable(),
    Fingerprint_Id: ko.observable()
    }


    self.addUser = function (formElement) {


        var user = {
            Id: self.newUser.Id(),
            First_Name: self.newUser.First_Name(),
            Last_Name: self.newUser.Last_Name(),
            Age: self.newUser.Age(),
            Gender: self.newUser.Gender(),
            Fingerprint_Id: self.newUser.Fingerprint_Id()
        
        };

        ajaxHelper(usersUri, 'POST', user).done(function (item) {
            self.users.push(item);
        });

    }

    //DelId: ko.observable();

    self.deleteUser = function (formElement) {

        ajaxHelper(usersUri + DelId, 'DELETE').done(function (data) {
            location.reload();
        });

    }

};

ko.applyBindings(new ViewModel());