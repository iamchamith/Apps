var app = angular.module("myApp", ["ngRoute"]);
var basePath = "../../Api/Views/templates";
app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            controller: 'shop',
            templateUrl: basePath + "/shop.html",
            resolve: {
                init: function () {
                    return function ($route) {
                    }
                }
            }
        })
        .when("/auth", {
            controller: 'auth',
            templateUrl: basePath + "/auth.html",
            resolve: {
                init: function () {
                    return function ($route) {
                    }
                }
            }
        })
        .when("/cart", {
            controller: 'cart',
            templateUrl: basePath + "/cart.html",
            resolve: {
                init: function () {
                    return function ($route) {
                    }
                }
            }
        }).when("/history", {
            controller: 'history',
            templateUrl: basePath + "/history.html",
            resolve: {
                init: function () {
                    return function ($route) {
                    }
                }
            }
        }).when("/items", {
            controller: 'items',
            templateUrl: basePath + "/items.html",
            resolve: {
                init: function () {
                    return function ($route) {
                    }
                }
            }
        }).otherwise({ rederectTo: '/' });
}).controller('shop', ['$scope', '$route', 'init',
    function ($scope, $route, init) {
        init($route);
    }]).controller('auth', ['$scope', '$route', 'init',
        function ($scope, $route, init) {
            init($route);
        }]).controller('cart', ['$scope', '$route', 'init',
            function ($scope, $route, init) {
                init($route);
            }]).controller('history', ['$scope', '$route', 'init',
                function ($scope, $route, init) {
                    init($route);
                }]).controller('items', ['$scope', '$route', 'init',
                    function ($scope, $route, init) {
                        init($route);
                    }]);
