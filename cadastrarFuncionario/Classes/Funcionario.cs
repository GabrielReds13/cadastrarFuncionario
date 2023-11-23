using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarFuncionario.Classes
{
    public class Funcionario
    {
        // - Atributos -
        public int Id { get; set; }

        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }

        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string EstadoCivil { get; set; }

        public string Telefone { get; set; }
        public string Email { get; set; }

        public string Funcao { get; set; }

        // - Metodo Construtor -
        public Funcionario
        (
            string nome,
            DateTime dataNasc,
            string sexo, 
            string cpf, 
            string rg, 
            string estadoCivil, 
            string telefone, 
            string email, 
            string funcao 
        ) 
        {
            Nome = nome;
            DataNasc = dataNasc;
            Sexo = sexo;
            Cpf = cpf;
            Rg = rg;
            EstadoCivil = estadoCivil;
            Telefone = telefone;
            Email = email;
            Funcao = funcao;
        }
    }
}