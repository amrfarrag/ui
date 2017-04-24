var app = angular.module("salaryapp", []);
app.controller("projectcontroller", function ($http,$scope) {
    $scope.projects = [];
    $scope.project = {
        ProjectID: 0,
        ProjectName: "",
        Employers:[]
    };
    $scope.search = "";
    $scope.load = function () {
        $http.get("/api/projectapi").then(function (response) {
            $scope.projects = response.data;
        });
    }
    $scope.load();
})
