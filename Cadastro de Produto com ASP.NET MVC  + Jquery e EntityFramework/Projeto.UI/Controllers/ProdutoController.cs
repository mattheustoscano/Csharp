using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.UI.Models;
using Projeto.Entidades;
using Projeto.DAL.Repositories;

namespace Projeto.UI.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CadastrarProduto(ProdutoCadastroViewModel Model)
        {
            try
            {

                Produto p = new Produto();

                p.Nome = Model.Nome;
                p.Preco = Model.Preco;
                p.Quantidade = Model.Quantidade;

                ProdutoRepository rep = new ProdutoRepository();

                rep.Insert(p);


                return Json("Produto Cadastrado com sucesso");
                    

            }
            catch (Exception e)
            {

                return Json(e.Message);
            }


        }

    }
}