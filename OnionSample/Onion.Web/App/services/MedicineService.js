/// <reference path="C:\dev\OnionSample\OnionSample\Onion.Web\scripts/angular.js" />

app.service("MedicineService", function ($http) {
    this.getAll = function (apiRoute) {
        return $http.get(apiRoute);
    }
    this.getMedicineById = function(apiRoute, id) {
        var url = apiRoute + id;
        return $http.get(url);
    }
    this.post = function (apiRoute, model) {
        var request = $http({
            method: "post",
            url: apiRoute,
            data: model
        });
        return request;
    }
    this.delete = function(apiRoute) {
        return $http.delete(apiRoute);
    }

    this.getAllCompany = function (apiRoute) {
        return $http.get(apiRoute);
    }
});