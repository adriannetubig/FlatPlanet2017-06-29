(function () {
    'use strict';

    angular
    .module('App')
    .controller('CounterController', CounterController);

    CounterController.$inject = ['CounterService'];

    function CounterController(CounterService) {
        var vm = this;
        vm.NumberOfClicks = 0;

        vm.Create = Create;

        vm.Count = Count;
        vm.Initialise = Initialise;
		
        function Create() {
        	CounterService.Create()
                .then(function (response) {
                	Count();
                })
                .catch(function (data, status) {
                	console.log(data);

                });
        }

        function Count() {
        	CounterService.Count()
            .then(function (response) {
            	vm.NumberOfClicks = response.data;
            })
            .catch(function (data, status) {
            	console.log(data);

            });
        }

        function Initialise() {
        	Count();
        }

    }
})();