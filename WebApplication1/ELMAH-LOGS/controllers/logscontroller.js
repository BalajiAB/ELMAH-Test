(function () {
    var logscontroller = function ($scope, $location,$http) {
        alert("logscontroller");
        $scope.mylogs = [];
        $http({
            url: 'Home/GetLogs',
            method: "GET"
        }).success(function (data, status) {
            $scope.mylogs = data;
        }).error(function (data, status) {
            alert(data);
        });
    }
    angular.module("myapp").controller("LogsController", logscontroller);
}());