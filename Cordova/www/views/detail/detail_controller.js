angular.module('myApp').controller('DetailCtrl', function ($scope, peopleService, $routeParams, $window) {
    $scope.index = $routeParams.index;
    $scope.person = peopleService.get($scope.index);

    $scope.back = function() {
        $window.history.back();
    };
});