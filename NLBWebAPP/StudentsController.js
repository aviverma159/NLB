var root = 'http://localhost:1713';
var app = angular.module("studentsApp", []);

app.controller("studentsCtrl", ["$scope", "$http", function ($scope, $http) {
    var url = root + "/api/NLBAPI"
    $http.get(url)
      .then(function (data) {
          $scope.students = JSON.parse(data.data);
      });
}]);
