'use strict';
app.factory('mangasService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var mangasServiceFactory = {};

    var _getMangas = function () {

        return $http.get(serviceBase + 'api/mangas').then(function (results) {
            return results;
        });
    };

    mangasServiceFactory.getMangas = _getMangas;

    return mangasServiceFactory;

}]);