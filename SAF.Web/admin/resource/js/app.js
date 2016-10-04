(function (angular) {
  'use strict';
  function config($stateProvider, $urlRouterProvider) {
    //$httpProvider.defaults.withCredentials = true;
    //$ocLazyLoadProvider.config({
    //  // Set to true if you want to see what and when is dynamically loaded
    //  debug: false,
    //  cssFilesInsertBefore: 'loadBefore'
    //});

    $stateProvider
        .state('index', {
          abstract: true,
          url: "/index",
          templateUrl: "hub/views/common/content.html"
        })
        .state('index.main', {
          url: "/main",
          templateUrl: "hub/views/main.html",
          data: { pageTitle: 'Example view' }
        })
        .state('login', {
          url: "/login",
          templateUrl: "../hub/views/login.html",
          data: { pageTitle: 'Login', specialClass: 'gray-bg' }
        })
        .state('locksreen', {
          url: "/locksreen",
          templateUrl: "../hub/views/locksreen.html",
          data: { pageTitle: 'Lock Sreen', specialClass: 'gray-bg' }
        })
        .state('pagenotfound', {
          url: "/pagenotfound",
          templateUrl: "../hub/views/404.html",
          data: { pageTitle: 'Page not found', specialClass: 'gray-bg' }
        })
        .state('internalerror', {
          url: "/internalservererror",
          templateUrl: "../hub/views/500.html",
          data: { pageTitle: 'Internal Server Error', specialClass: 'gray-bg' }
        })

  }
  angular.module('saf', [
      'ui.router',                    // Routing
      //'oc.lazyLoad',                 // ocLazyLoad
      'ui.bootstrap',                // Ui Bootstrap
      //'pascalprecht.translate',     // Angular Translate
      'LocalStorageModule'          // angular-local-storage

  ])
      .config(config)
      .run(function ($rootScope, $state, $http, $templateCache) {
        $rootScope.$state = $state;
        ///������棬��ֹangular����ģ��
        $rootScope.$on('$routeChangeStart', function (event, next, current) {
          if (typeof (current) !== 'undefined') {
            $templateCache.remove(current.templateUrl);
          }
        });
      });
  //.constant('appContext',appContext)

})(window.angular);


