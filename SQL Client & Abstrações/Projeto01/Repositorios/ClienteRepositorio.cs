using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Contratos;
using System.Data.SqlClient;

namespace Projeto01.Repositorios
{
    public class ClienteRepositorio : Conexao, IClienteRepositorio
    {

        public List<Cliente> FindAll()
        {

            OpenConnection();


            string query = "select * from ClienteEndereco";

            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            //declarando uma lista de clientes...
            List<Cliente> Lista = new List<Cliente>();

            while (dr.Read())
            {

                Cliente c = new Cliente();
                c.Endereco = new Endereco();


                c.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                c.Nome = Convert.ToString(dr["Nome"]);
                c.Email = Convert.ToString(dr["Email"]);
                c.Endereco.IdEndereco = Convert.ToInt32(dr["IdEndereco"]);
                c.Endereco.Logradouro = Convert.ToString(dr["Logradouro"]);
                c.Endereco.Estado = Convert.ToString(dr["Estado"]);
                c.Endereco.Cidade = Convert.ToString(dr["Cidade"]);
                c.Endereco.Bairro = Convert.ToString(dr["Bairro"]);
                c.Endereco.Cep = Convert.ToString(dr["Cep"]);


                Lista.Add(c);

            }


            CloseConnection();
            return Lista;
        }

        public void Insert(Cliente c)
        {
            //Abrir Conexão com o Banco de Dados...
            OpenConnection();
            
            // Abrir uma transação com o banco de dados...
            tr = con.BeginTransaction();

            try
            {
                // Gravando um cliente...

                string query = "Insert into Cliente (Nome,Email) values (@Nome,@Email) select scope_IDENTITY()";


                cmd = new SqlCommand(query, con, tr);


                cmd.Parameters.AddWithValue("@Nome", c.Nome);
                cmd.Parameters.AddWithValue("@Email", c.Email);


                // atribuo o endereço do cliente inserido...
                c.IdCliente = Convert.ToInt32(cmd.ExecuteScalar());


               // verificar se o cliente tem endereço...

                if (c.Endereco != null)
                {

                    string queryEndereco = "insert into Endereco (Logradouro, Bairro, Cidade, Estado, Cep, IdCliente) " +
                                            "values (@Logradouro, @Bairro, @Cidade, @Estado, @Cep, @IdCliente)";

                    cmd = new SqlCommand(queryEndereco, con, tr);


                    cmd.Parameters.AddWithValue("@Logradouro", c.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@Bairro", c.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", c.Endereco.Cidade);
                    cmd.Parameters.AddWithValue("@Estado", c.Endereco.Estado);
                    cmd.Parameters.AddWithValue("@Cep", c.Endereco.Cep);
                    cmd.Parameters.AddWithValue("@IdCliente", c.IdCliente);

                    cmd.ExecuteNonQuery();

                }


                // Finalizar a transação...
                tr.Commit();

            }
            catch (Exception e)
            {
                // Volto a os registros em caso de erro...
                tr.Rollback();

            }
            finally
            {
                // Fechar Conexão com o Banco de Dados...
                CloseConnection();
            }

        }



    }
}
