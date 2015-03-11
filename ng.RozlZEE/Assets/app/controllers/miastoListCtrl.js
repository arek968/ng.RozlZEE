angular.module('miastoList', [])
    .controller('miastoListCtrl', ['$scope', '$http', function ($scope, $http) {

        $scope.getList = function () {
            $http.get('/api/MiastoController/get')
                .success(function (data, status, headers, config) {
                    $scope.miasta = data;
                });
        }
        /*
        $scope.postItem = function () {
            item =
                {
                    task: $scope.newTaskText
                };

            if ($scope.newTaskText != '') {
                $http.post('/api/WS_Todo/PostTodoItem', item)
                    .success(function (data, status, headers, config) {
                        $scope.newTaskText = '';
                        $scope.getList();
                    });
            }
        }

        $scope.complete = function (index) {
            $http.post('/api/WS_Todo/CompleteTodoItem/' + $scope.todoList[index].id)
                .success(function (data, status, headers, config) {
                    $scope.getList();
                });
        }

        $scope.delete = function (index) {
            $http.post('/api/WS_Todo/DeleteTodoItem/' + $scope.todoList[index].id)
                .success(function (data, status, headers, config) {
                    $scope.getList();
                });
        }
        */
        //Get the current user's list when the page loads.
        $scope.getList();
    }]);