
var app = angular.module('searchAppIndex', []);

app.controller('searchCtrl', function($scope, $http) {

	//a simple model to bind to and send to the server
	$scope.search = {
			into:{}
	};
	$scope.brandModels = [];
	$scope.brands = [];
	$scope.cities = [];
	$scope.versions = [];
	$scope.selectedBrands = [];
	$scope.fiyatenaz = "";
	$scope.fiyatencok = "";
	$scope.searchType = 1; // 1: brand new car 2: secondhandCar , 3: brandnew and secondhand 4:secondhand brand new
	$scope.search.orderby = 0;
	$scope.search.vitesler = 0;
	$scope.search.yakitlar = 0;
	$scope.search.kasaTipi = 0;
	
	$(document).ready(function() {});

	$scope.searchIndex = function() {

		if (angular.isUndefinedOrNull($scope.search.yakitlar)|| $scope.search.yakitlar == 0) {
			$scope.search.yakitlar = -1;
		}
		if (angular.isUndefinedOrNull($scope.search.vitesler)|| $scope.search.vitesler == 0) {
			$scope.search.vitesler = -1;
		}
		if (angular.isUndefinedOrNull($scope.search.kasaTipi) || $scope.search.kasaTipi == 0) {//new
			$scope.search.kasaTipi = -1;
		}
		if (angular.isUndefinedOrNull($scope.search.fiyatenaz)) {
			$scope.fiyatenaz = -1;
			$scope.search.fiyatenaz = "";
		} else {
			$scope.fiyatenaz = $scope.search.fiyatenaz.replace(/\./g,'');
		}
		if (angular.isUndefinedOrNull($scope.search.fiyatencok)) {
			$scope.fiyatencok = -1;
			$scope.search.fiyatencok = "";
		} else {
			$scope.fiyatencok = $scope.search.fiyatencok.replace(/\./g,'');;
		}
		if (angular.isUndefinedOrNull($scope.search.orderby)) {
			$scope.search.orderby = 0;
		}
		
		if (angular.isUndefinedOrNull($scope.search.silindirler)) {//new
			$scope.search.silindirler = -1;
		}
		
		$scope.searchUrl ="#";
		
		if($scope.searchType == 1 || $scope.searchType == 3 ){
			$scope.searchUrl = "/arama-sonucu/" + $scope.search.kasaTipi + "/"
			+ $scope.search.yakitlar + "/" + $scope.search.vitesler + "/"
			+ $scope.search.silindirler + "/" + $scope.fiyatenaz + "/"
			+ $scope.fiyatencok + "/" + $scope.search.orderby + "/"
			+ $scope.searchType + "/0/1";
			
		}else if($scope.searchType == 2 || $scope.searchType == 4 ){
			$scope.searchUrl = "/arama-sonucu/" + $scope.search.brands + "/"
			+ $scope.search.yakitlar + "/" + $scope.search.vitesler + "/"
			+ $scope.search.cities + "/" + $scope.fiyatenaz + "/"
			+ $scope.fiyatencok + "/" + $scope.search.orderby + "/"
			+ $scope.searchType + "/0/1";
		}

		location.href = $scope.searchUrl;
	};
 
	angular.isUndefinedOrNull = function(val) {
		return angular.isUndefined(val) || val === null || val == ""
	}

	$scope.searchTypeSet = function(type ) {		
		$scope.searchType = type;
		if(type == 1 || type == 2){
			$scope.search.into.version = false;
			$scope.search.into.secondhand = false;
		}
	};
 

});
