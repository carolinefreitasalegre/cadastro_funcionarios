using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Fornecedores
{
    // Aqui estarão os atriibutos e métodos do CRUD
    // classe do cadastro dos funcionarios
    internal class cadastroFuncionarios
    {
        private int id;
        private string name;
        private string email;
        private string cpf;
        private string endereco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        // método para cadastar funcionarios
        public bool cadastrarFuncionarios()
        {
            try
            {
                // variavel de conexão do banco
                var MySqlConnection = new NpgsqlConnection(ConexaoBanco.bancoServidor);
                MySqlConnection.Open();

                // código do banco
                string insert = $" insert into fornecedores (nome,email,cpf,endereco) values ('{Nome}', '{Email}', '{Cpf}', '{Endereco}')";

                NpgsqlCommand commandoSql = new NpgsqlCommand(insert, MySqlConnection);

                commandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no banco de dados -  método cadastrar funcionários: " + ex.Message);
                return false;
            }
        }

        public NpgsqlDataReader localizarFuncionario()
        {
            try
            {
                var MySqlConnection = new NpgsqlConnection(ConexaoBanco.bancoServidor);
                MySqlConnection.Open();

                // codigo do banco
                string select = $"select id, nome, email, cpf, endereco from fornecedores where cpf = '{Cpf}' ";

                NpgsqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = select;

                NpgsqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro no banco de dasdos - método localizarFuncionário: " + err.Message);
                return null;
            }
        }

        public bool atualizarFuncionario()
        {
            try
            {
                var MySqlConnection = new NpgsqlConnection(ConexaoBanco.bancoServidor);
                MySqlConnection.Open();


                string update = $"update fornecedores set email = '{email}', endereco = '{Endereco}' where id = '{id}';";
                NpgsqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();   
                return true;

            }
            catch (Exception err)
            {

                MessageBox.Show("Erro no banco de dados - método atualizarFuncionario: " + err.Message);
                return false;
            }
        }

        public bool deletarFuncionario()
        {
            try
            {
                var MySqlConnection = new NpgsqlConnection(ConexaoBanco.bancoServidor);
                MySqlConnection.Open();


                string delete = $"delete from fornecedores where id = '{Id}';";
                NpgsqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro no banco de dados - método deletarFuncionario: " + err.Message);

                throw;
            }
        }
    }
}
