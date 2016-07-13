 var  modules = modules || [];
(function () {
    'use strict';
    modules.push('Position');

    angular.module('Position',['ngRoute'])
    .controller('Position_list', ['$scope', '$http', function($scope, $http){

        $http.get('/Api/Position/')
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Position_details', ['$scope', '$http', '$routeParams', function($scope, $http, $routeParams){

        $http.get('/Api/Position/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Position_create', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){

        $scope.data = {};
        
        $scope.save = function(){
            $http.post('/Api/Position/', $scope.data)
            .then(function(response){ $location.path("Position"); });
        }

    }])
    .controller('Position_edit', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){

        $http.get('/Api/Position/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

        
        $scope.save = function(){
            $http.put('/Api/Position/' + $routeParams.id, $scope.data)
            .then(function(response){ $location.path("Position"); });
        }

    }])
    .controller('Position_delete', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){

        $http.get('/Api/Position/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});
        $scope.save = function(){
            $http.delete('/Api/Position/' + $routeParams.id, $scope.data)
            .then(function(response){ $location.path("Position"); });
        }

    }])

    .config(['$routeProvider', function ($routeProvider) {
            $routeProvider
            .when('/Position', {
                title: 'Position - List',
                templateUrl: '/Static/Position_List',
                controller: 'Position_list'
            })
            .when('/Position/Create', {
                title: 'Position - Create',
                templateUrl: '/Static/Position_Edit',
                controller: 'Position_create'
            })
            .when('/Position/Edit/:id', {
                title: 'Position - Edit',
                templateUrl: '/Static/Position_Edit',
                controller: 'Position_edit'
            })
            .when('/Position/Delete/:id', {
                title: 'Position - Delete',
                templateUrl: '/Static/Position_Delete',
                controller: 'Position_delete'
            })
            .when('/Position/:id', {
                title: 'Position - Details',
                templateUrl: '/Static/Position_Details',
                controller: 'Position_details'
            })
    }])
;

})();
