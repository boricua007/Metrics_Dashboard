myApp.controller('RegistrationController', ['$scope', function ($scope) {
    $scope.message = "Welcome, Please Log In";

    $scope.login = function () {
        $scope.message = "Welcome to Your Dashboard, " + " "  +$scope.user.email;
    }

    $scope.login = function () {
        $scope.message = "Welcome, " + " " + $scope.firstname.email;
    }
}]);

