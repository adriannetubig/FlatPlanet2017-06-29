(function () {
    'use strict';

    angular
        .module('App')
        .factory('CounterService', CounterService);

    CounterService.$inject = ['$http'];

    function CounterService($http) {
        return {
            Create: Create,
            Count: Count
        }

        function Create() {
            return $http({
                method: 'POST',
                url: '../Home/Create',
            });
        }

        function Count() {
            return $http({
                method: 'POST',
                url: '../Home/Count'
            });
        }
    }
})();