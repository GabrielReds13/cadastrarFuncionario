using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarFuncionario.Classes
{
    public class Funcionario
    {
        // Atributos
        public string Id { get; set; }

        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }

        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string EstadoCivil { get; set; }

        public string Telefone { get; set; }
        public string Email { get; set; }

        public string Funcao { get; set; }
    }
}