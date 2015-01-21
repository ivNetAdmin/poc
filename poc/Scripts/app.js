var pocApp = angular.module('Poc.App', ['ngResource']);
  

pocApp.factory('list', function ($resource) {
    return $resource('/api/data/:id', null,
    {
        'query': { method: 'GET', isArray: true },
    });
});

pocApp.controller('PocAppController', function ($scope, list) {

    init();

    function init() {

        list.query(
           function (data) {
               $scope.items = data;
           },
        function (error) {
            alert(error.data.Message + ' [' + error.data.MessageDetail + ']');
        });
    }

});