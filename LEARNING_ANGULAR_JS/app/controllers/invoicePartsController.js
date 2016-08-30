angular.module('mainApplication')
	.controller('invoicePartsController', function ($scope, invocePartsFactory) {

		$scope.fullName = '';

		$scope.btnSubmit = function () {

			var varInvoicePart = {};

			invocePartsFactory.insert(varInvoicePart)
				.success(function (response) {

				})
				.error(function (response) {

				});



		};

	});
