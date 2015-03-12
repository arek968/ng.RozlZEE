/*
angular.module('miastoList', [])
    .controller('miastoListCtrl', function ($scope, $http) {
    alert(1);
    $http.get('api/Miasto/GetMiasto').success(function (data) {
        
        $scope.miasta = data;
        alert(data);
    });
        
});

*/

angular.module('miastoList', [])
    .controller('miastoListCtrl', ['$scope', '$http', function ($scope, $http) {
        alert(1);
        $scope.getList = function () {
            alert(2);
            $http.get('/api/Miasto/GetMiasto')
                .success(function (data, status, headers, config) {
                    alert(data);
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