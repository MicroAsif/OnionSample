/// <reference path="C:\dev\OnionSample\OnionSample\Onion.Web\scripts/angular.js" />

app.service("CompanyService", function ($http) {
    this.getAll = function (apiRoute) {
        return $http.get(apiRoute);
    }
});