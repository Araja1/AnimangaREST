'use strict';
app.controller('ordersController', ['$scope', 'ordersService', function ($scope, ordersService) {

    $scope.orders = [];

    ordersService.getOrders().then(function (results) {
        console.log('RESULT');

        $scope.orders = results.data;

    }, function (error) {
        //alert(error.data.message);
        Console.log('KEIN RESULT');
        console.log('RESULT');
    });

}]);