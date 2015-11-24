angular.module('myApp').controller('ListCtrl', function ($scope, peopleService, $location) {
    $scope.people = peopleService.get_people();

    $scope.go = function(index) {
        $location.path('/detail/' + index);
    };
});