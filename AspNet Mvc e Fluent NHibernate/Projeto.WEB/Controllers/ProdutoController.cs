using Projeto.DAL.Repositories;
using Projeto.Entidades;
using Projeto.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.WEB.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Produto
        public ActionResult Consulta()
        {
            return View();
        }

        public JsonResult CadastrarProduto(ProdutoCadastroViewModel model)
        {
            try
            {
                //Classe que contém minhas operações de crud...
                ProdutoRepository rep = new ProdutoRepository();

                Produto p = new Produto();

                p.Nome = model.Nome;
                p.Preco = model.Preco;
                p.Quantidade = model.Quantidade;

                rep.Insert(p);

                return Json("Produto cadastrado com sucesso.");

            }
            catch (Exception e)
            {

                return Json("Erro ao cadastrar produto: " + e.Message);
            }
        }

        public JsonResult ListarProdutos()
        {
            try
            {
                ProdutoRepository rep = new ProdutoRepository();

                List<ProdutoConsultaViewModel> lista =
                      new List<ProdutoConsultaViewModel>();

                foreach(Produto p in rep.FindAll())
                {
                    ProdutoConsultaViewModel model =
                        new ProdutoConsultaViewModel();

                    model.IdProduto = p.IdProduto;
                    model.Nome = p.Nome;
                    model.Preco = p.Preco;
                    model.Quantidade = p.Quantidade;
                    model.ValorTotal = (p.Quantidade * p.Preco);

                    lista.Add(model);
                }
                                   // Parâmetro necessário para métodos GET.
                return Json(lista, JsonRequestBehavior.AllowGet);

            }
            catch (Exception e)
            {

                return Json("Erro ao consultar produtos: " + e.Message, JsonRequestBehavior.AllowGet);
            }
        }


        public JsonResult ListarProdutosPorNome(ProdutoConsultaPorNomeViewModel modelo)
        {
            try
            {
                ProdutoRepository rep = new ProdutoRepository();

                List<ProdutoConsultaViewModel> lista =
                      new List<ProdutoConsultaViewModel>();

                foreach (Produto p in rep.FindByNome(modelo.Nome))
                {
                    ProdutoConsultaViewModel model =
                        new ProdutoConsultaViewModel();

                    model.IdProduto = p.IdProduto;
                    model.Nome = p.Nome;
                    model.Preco = p.Preco;
                    model.Quantidade = p.Quantidade;
                    model.ValorTotal = (p.Quantidade * p.Preco);

                    lista.Add(model);
                }
                // Parâmetro necessário para métodos GET.
                return Json(lista, JsonRequestBehavior.AllowGet);

            }
            catch (Exception e)
            {

                return Json("Erro ao consultar produtos: " + e.Message, JsonRequestBehavior.AllowGet);
            }
        }

    }
}