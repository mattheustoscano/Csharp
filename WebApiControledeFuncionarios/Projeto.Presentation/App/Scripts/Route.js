app.config(

    function ($routeProvider) {

        $routeProvider

            .when('/funcionario/cadastro', {

                templateUrl: '/App/Views/Funcionario/Cadastro.html',
                controller: 'CadastroController'

            })

            .when('/funcionario/consulta',{

                templateUrl: '/App/Views/Funcionario/Consulta.html',
                controller: 'ConsultaController'

            });

    }

);

//função para fazer funcionar as rotas..
app.config(function ($locationProvider) {

    $locationProvider.hashPrefix('');

});