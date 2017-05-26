handsOnApp.controller("HomeController",
    ["$scope", "$location",
    function ($scope, $location) {

        $scope.showEditableGrid = function () {
            $location.path('/showEditableGrid');
        };
    }]);