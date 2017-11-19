app.controller('ConsultaController',

    function ($scope, $http) {

        $scope.consultartodos = function () {


            $http.get("http://localhost:60659/api/funcionario/consultartodos")


                .then(function(d){

                    $scope.lista = d.data;


                })

                .catch(function (e) {

                    $scope.mensagem = e.data; 

                })

        }


        $scope.obterporid = function (id) {

            $scope.Funcionario = {};

            $http.get("http://localhost:60659/api/funcionario/obterporid?id="+id)

                .then(function (d) {
                    $scope.Funcionario = d.data;

                })
                .catch(function (e) {
                    $scope.mensagem = e.data;
                })

        }

        $scope.obterpornome = function () {

            
            $http.get("http://localhost:60659/api/funcionario/consultartodospornome?nome=" + $scope.Nome)

                .then(function (d) {
                    $scope.lista = d.data;

                })
                .catch(function (e) {
                    $scope.mensagem = e.data;
                })

        }


        $scope.excluir = function (id) {

            $http.delete("http://localhost:60659/api/funcionario/excluir?id=" + id)

                .then(function (d) {


                    $scope.Funcionario = {};
                    $scope.consultartodos();
                    $scope.mensagem = d.data;

                })
                .catch(function (e) {
                    $scope.mensagem = e.data;
                })

        }

        $scope.atualizar = function () {

            $http.put("http://localhost:60659/api/funcionario/atualizar", $scope.Funcionario)

                .then(function (d) {

                    $scope.Funcionario = {};
                    $scope.consultartodos();
                    $scope.mensagem = d.data;
                    

                })
                .catch(function (e) {
                    $scope.mensagem = e.data;
                })

        }

    }

);