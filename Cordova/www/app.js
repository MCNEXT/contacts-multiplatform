'use strict';

// Declare app level module which depends on views, and components
angular.module('myApp', [
  'ngRoute',
   'ngMaterial'
]).
config(['$routeProvider', '$compileProvider', function ($routeProvider, $compileProvider) {

    $compileProvider.imgSrcSanitizationWhitelist('img/');

    $routeProvider
        .when('/list', {
            templateUrl: 'views/list/list.html',
            controller: 'ListCtrl'
        })
        .when('/detail/:index', {
            templateUrl: 'views/detail/detail.html',
            controller: 'DetailCtrl'
        })
        .otherwise({
            redirectTo: '/list'
        });;
}]);