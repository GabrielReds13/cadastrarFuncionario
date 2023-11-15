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
        private string Id { get; set; }

        private string Nome { get; set; }
        private DateTime DataNasc { get; set; }
        private string Sexo { get; set; }

        private string Cpf { get; set; }
        private string Rg { get; set; }
        private string EstadoCivil { get; set; }

        private string Telefone { get; set; }
        private string Email { get; set; }

        private string Funcao { get; set; }
    }
}
