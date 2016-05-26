'use strict';
app.controller('mangasController', ['$scope', 'mangasService', function ($scope, mangasService) {

    $scope.mangas = [];

    mangasService.getMangas().then(function (results) {
        console.log('RESULT');

        $scope.mangas = results.data;

    }, function (error) {
        //alert(error.data.message);
        Console.log('KEIN RESULT');
        console.log('RESULT');
    });

}]);