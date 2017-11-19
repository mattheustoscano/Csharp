using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.DAL.Entities;
using Projeto.DAL.Repositories;
using Projeto.Services.Models;

namespace Projeto.Services.Controllers
{

    [RoutePrefix("api/funcionario")]
    public class FuncionarioController : ApiController
    {

        [HttpPost]
        [Route("cadastro")]
        public HttpResponseMessage Cadastrar(FuncionarioCadastroModel model)
        {

            try
            {



                if (ModelState.IsValid)
                {


                    Funcionario f = new Funcionario()
                    {


                        Nome = model.Nome,
                        Salario = model.Salario,
                        DataAdmissao = model.DataAdmissao


                    };




                    FuncionarioRepository rep = new FuncionarioRepository();

                    rep.Insert(f);



                    return Request.CreateResponse(HttpStatusCode.OK, "Funcionário cadastrado com sucesso.");

                }
                else
                {

                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);

                }






            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
                    
            }

        }


        [HttpGet]
        [Route("obterporid")]
        public HttpResponseMessage ConsultarPorId(int id)
        {


            try
            {

                FuncionarioRepository rep = new FuncionarioRepository();

                Funcionario f = rep.FindById(id);



                FuncionarioConsultaModel model = new FuncionarioConsultaModel()
                {

                    IdFuncionario = f.IdFuncionario,
                    Nome = f.Nome,
                    Salario = f.Salario,
                    DataAdmissao = f.DataAdmissao

                };


                return Request.CreateResponse(HttpStatusCode.OK, model);


            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }


        }



        [HttpGet]
        [Route("consultartodos")]
        public HttpResponseMessage ConsultarTodos()
        {

            try
            {

                List<FuncionarioConsultaModel> Lista = new List<FuncionarioConsultaModel>();



                FuncionarioRepository rep = new FuncionarioRepository();

                foreach(Funcionario f in rep.FindAll())
                {

                    FuncionarioConsultaModel model = new FuncionarioConsultaModel();

                    model.IdFuncionario = f.IdFuncionario;
                    model.Nome = f.Nome;
                    model.DataAdmissao = f.DataAdmissao;
                    model.Salario = f.Salario;


                    Lista.Add(model);

                }

                return Request.CreateResponse(HttpStatusCode.OK, Lista);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }

        }



        [HttpGet]
        [Route("consultartodospornome")]
        public HttpResponseMessage ConsultarTodosPorNome(string nome)
        {

            try
            {

                List<FuncionarioConsultaModel> Lista = new List<FuncionarioConsultaModel>();



                FuncionarioRepository rep = new FuncionarioRepository();

                foreach (Funcionario f in rep.FindByName(nome))
                {

                    FuncionarioConsultaModel model = new FuncionarioConsultaModel();

                    model.IdFuncionario = f.IdFuncionario;
                    model.Nome = f.Nome;
                    model.DataAdmissao = f.DataAdmissao;
                    model.Salario = f.Salario;


                    Lista.Add(model);

                }

                return Request.CreateResponse(HttpStatusCode.OK, Lista);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }

        }


        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Atualizar(FuncionarioEdicaoModel model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    Funcionario f = new Funcionario();


                    f.IdFuncionario = model.IdFuncionario;
                    f.Nome = model.Nome;
                    f.Salario = model.Salario;
                    f.DataAdmissao = model.DataAdmissao;


                    FuncionarioRepository rep = new FuncionarioRepository();

                    rep.Update(f);


                    return Request.CreateResponse(HttpStatusCode.OK, "Funcionário atualizado com sucesso.");


                }
                else
                {


                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);

                }



            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);

            }




        }


        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage excluir(int id)
        {


            try
            {



                FuncionarioRepository rep = new FuncionarioRepository();


                Funcionario f = rep.FindById(id);

                rep.Delete(f);

                return Request.CreateResponse (HttpStatusCode.OK, "Funcionário excluído com sucesso.");


            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);

            }


        }


    }
}
