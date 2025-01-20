using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedores
{
    static class ConexaoBanco
    {
        // criadas variaveis provadas passando a info do mbanco de dados
        private const string servidor = "localhost";
        private const string bancoDados = "postgres";
        private const string usuario = "postgres";
        private const string senha = "root";

        // declarando info do banco de dados para fazer a conexão com o banco de dados
        static public string bancoServidor = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";

    }
}
