handsOnApp.controller('gridController',
    ["$scope", "$window", "gridService",
    function gridController($scope, $window, gridService) {

        // Load all Employees

        $scope.getEmployees = function () {

            gridService.getEmployees().then(
                function (successResult) {

                    $scope.employees = successResult.data;
                },
                function (failureResult) {

                    console.log(failureResult);
                });
        };
    }]);
    
    
    