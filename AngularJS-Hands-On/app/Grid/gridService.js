handsOnApp.factory('gridService',
    ["$http",
        function ($http) {

            // Loads all Employees

            var getEmployees = function () {

                return $http.get("api/Common/GetEmployees");
            };

            return {
                getEmployees: getEmployees
            };
        }]);