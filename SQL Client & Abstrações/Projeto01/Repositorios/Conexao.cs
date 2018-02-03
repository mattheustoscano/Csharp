using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto01.Repositorios
{
    public class Conexao
    {

        //Atributos...
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlTransaction tr;


        protected void OpenConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString);
            con.Open();
        }

        protected void CloseConnection()
        {
            con.Close();
        }
        

        
    }
}
