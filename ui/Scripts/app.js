var app = angular.module("salaryapp", [], function ($locationProvider) {
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});

app.controller("projectcontroller", function ($http, $scope, $location) {
    $scope.projects = [];
    $scope.project = {
        ProjectID: 0,
        ProjectName: "",
        Employers: []
    };
    $scope.employer={};
    $scope.employers=[];
    $scope.loademployers = function () {
        $http.get("/api/employerapi").then(function (response) {
            $scope.employers = response.data;

        });
    }
    
    $scope.load = function () {
        $http.get("/api/projectapi").then(function (response) {
            $scope.projects = response.data;
        });
    }
    $scope.load();
    var path = $location.path();
    var id = path.split("/")[3];


    if (typeof id != 'undefined') {
        $http.get("/api/projectapi/" + id).then(function (response) {
            $scope.project = response.data;
            $scope.loademployers();
        });
    }

});
