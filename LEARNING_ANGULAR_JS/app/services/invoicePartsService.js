angular.module('mainApplication')
	.factory('invocePartsFactory', ['$http', function ($http) {

		var dataFactory = {};
		var urlBase = '/alc/invoicepart';

		dataFactory.getAll = function () {

			return ($http.get(urlBase + '/getAll'));

		};

		dataFactory.getById = function (id) {

			return ($http.get(urlBase + '/getById/' + id));

		};

		dataFactory.insert = function (entity) {

			return ($http.post(urlBase + '/insert', entity));

		};

		dataFactory.update = function (entity) {

			return ($http.post(urlBase + '/update', entity));

		};

		dataFactory.deleteById = function (id) {

			return ($http.post(urlBase + '/deleteById/' + id));

		};

		return (dataFactory);
	}]);
