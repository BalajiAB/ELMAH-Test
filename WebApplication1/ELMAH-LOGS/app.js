(function () {
    alert("app.js");
    var app = angular.module("myapp", ['ngRoute']);
    app.config(function ($routeProvider) {
        $routeProvider.
            when("/ShowLogs", {
                controller: "LogsController",
                templateUrl: "/ELMAH-LOGS/views/logs.html"
            });
    });
}());