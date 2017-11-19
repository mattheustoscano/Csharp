app.controller('CadastroController',


    function ($scope, $http) {



        $scope.cadastrar = function () {


            $scope.mensagem = "Enviando requisição...";

            $http.post("http://localhost:60659/api/funcionario/cadastro", $scope.Funcionario)


                .then(function (d) {

                    $scope.mensagem = d.data;
                    $scope.Funcionario = {};

                })

                .catch(function (d) {

                    $scope.mensagem = d.data;

                });

        };



    }


)