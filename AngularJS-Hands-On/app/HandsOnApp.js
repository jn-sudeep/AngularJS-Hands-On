var handsOnApp = angular.module('handsOnApp', ["ngRoute"]);

handsOnApp.config(
    ["$routeProvider",
    function ($routeProvider) {
    $routeProvider
        .when("/home", {
            templateUrl: "app/Home.html",
            controller: "HomeController"
        })
        
        .when("/showEditableGrid", {
            templateUrl: "app/Grid/grid.html",
            controller: "gridController"
        })
        
        .otherwise({
            redirectTo: "/home"
        });
}]);
