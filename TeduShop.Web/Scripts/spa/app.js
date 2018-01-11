var myApp = angular.module('myModule', []);

myApp.controller("myController", myController);
myApp.directive("myDirective", myDirective);
myApp.service("validatorService", validatorService);
myController.$inject = ['$scope','validatorService'];

function myController($scope, validatorService) {
    //$scope.message = "This is message from Controller";
    $scope.message = validatorService.checkNumberFun(9);
}

function validatorService($window) {
    return {
        checkNumberFun: checkNumber
    }
    function checkNumber(number) {
        if (number % 2 == 0) {
            return 'this is even';
        }
        else {
            return 'this is odd';
        }
    }
}

function myDirective() {
    return {
        templateUrl: "/Scripts/spa/myDirective.html"
    }
}
//myApp.controller("myController", function ($scope) {
//    $scope.message = "This is message from Controller";
//});
