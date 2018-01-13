using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Projeto01.Entidades;

namespace Projeto01.Controles
{
    public class ProdutoControle
    {


        public static void GerarXML(Produto p)
        {

            // Cria arquivo...
            XmlWriter xml = XmlWriter.Create("c:\\temp\\Produto.xml");

            xml.WriteStartDocument();

            xml.WriteStartElement("Produto");


            xml.WriteElementString("idproduto", p.IdProduto.ToString());
            xml.WriteElementString("nome", p.Nome);
            xml.WriteElementString("preco", p.Preco.ToString());
            xml.WriteElementString("quantidade", p.Quantidade.ToString());


            xml.WriteEndElement();
            // Fecha arquivo...
            xml.Close();

        }


    }
}
