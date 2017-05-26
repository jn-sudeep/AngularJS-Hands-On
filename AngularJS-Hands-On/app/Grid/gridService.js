handsOnApp.factory('gridService',
    ["$http",
        function ($http) {

            // Loads all books

            var getBooks = function () {

                return $http.get("api/Common/GetBooks");
            };

            return {
                getBooks: getBooks
            };
        }]);