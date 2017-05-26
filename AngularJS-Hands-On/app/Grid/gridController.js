handsOnApp.controller('gridController',
    ["$scope", "$window", "gridService",
    function gridController($scope, $window, bookService) {

        $scope.book = {};                   // Creates a blank Book object used in Add Book operation

        // Load all books for Modify and Delete operations

        $scope.getBooks = function () {
            $scope.isProcessing = true;

            bookService.getBooks().then(
                function (successResult) {

                    $scope.books = successResult.data;

                    if ($scope.books.length > 0) {
                        $scope.selectedBook = $scope.books[0];
                    }

                    $scope.isProcessing = false;
                },
                function (failureResult) {

                    $scope.hasServerValidationErrors = true;
                    $scope.formErrors = failureResult.data;

                    $scope.isProcessing = false;
                });
        };

    }]);
    
    
    