var myApp = angular.module('dashboardApp', ['ngRoute']);

myApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.
        when('/login', {
            templateUrl: 'views/login.html',
            controller: 'RegistrationController'
        }).
        when('/register', {
            templateUrl: 'views/register.html',
            controller: 'RegistrationController'
        }).
        when('/client', {
            templateUrl: 'views/client.html',
            controller: 'ClientController'
        }).
        when('/success', {
            templateUrl: 'views/success.html',
            controller: 'SuccessController'
        }).
        otherwise({
            redirectTo: '/login'
        });
}]);