using CadastrarFuncionario.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastrarFuncionario
{
    public partial class Form1 : Form
    {
        // Atributos
        public string[] allFuncionarios = Banco.Consultar();
        public string[] plchVazios = {" ", "", null};
        public string[] plch = {
            "Nome completo",
            "Data de nascimento",
            "Sexo",
            "CPF",
            "RG",
            "Estado civil",
            "Telefone",
            "Email",
            "Função",
        };

        // Metodos
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (
                txt_nome.Text           == plchVazios[0] || txt_nome.Text           == plchVazios[1] || txt_nome.Text           == plchVazios[2] || txt_nome.Text           == plch[0] ||
                txt_dataNascimento.Text == plchVazios[0] || txt_dataNascimento.Text == plchVazios[1] || txt_dataNascimento.Text == plchVazios[2] || txt_dataNascimento.Text == plch[1] ||
                txt_cpf.Text            == plchVazios[0] || txt_cpf.Text            == plchVazios[1] || txt_cpf.Text            == plchVazios[2] || txt_cpf.Text            == plch[2] ||                       
                txt_rg.Text             == plchVazios[0] || txt_rg.Text             == plchVazios[1] || txt_rg.Text             == plchVazios[2] || txt_rg.Text             == plch[3] ||                                      
                txt_telefone.Text       == plchVazios[0] || txt_telefone.Text       == plchVazios[1] || txt_telefone.Text       == plchVazios[2] || txt_telefone.Text       == plch[4] ||                                            
                txt_email.Text          == plchVazios[0] || txt_email.Text          == plchVazios[1] || txt_email.Text          == plchVazios[2] || txt_email.Text          == plch[5] ||                                       
                cb_sexo.Text            == plchVazios[0] || cb_sexo.Text            == plchVazios[1] || cb_sexo.Text            == plchVazios[2] || cb_sexo.Text            == plch[6] ||
                cb_estadoCivil.Text     == plchVazios[0] || cb_estadoCivil.Text     == plchVazios[1] || cb_estadoCivil.Text     == plchVazios[2] || cb_estadoCivil.Text     == plch[7] ||
                cb_funcao.Text          == plchVazios[0] || cb_funcao.Text          == plchVazios[1] || cb_funcao.Text          == plchVazios[2] || cb_funcao.Text          == plch[8]
            ) MessageBox.Show("Existem campos vazios ou não preenchidos corretamente!");
            else 
            {
                if(
                    Validar.Cpf(txt_cpf.Text) == true &&
                    Validar.DataNasc(txt_dataNascimento.Text) == true &&
                    Validar.Telefone(txt_telefone.Text) == true &&
                    Validar.Email(txt_email.Text) == true
                )
                {
                    // Realizar cadastro
                    Funcionario f = new Funcionario(
                        txt_nome.Text,
                        Convert.ToDateTime(txt_dataNascimento.Text).Date,
                        cb_sexo.Text,
                        txt_cpf.Text,
                        txt_rg.Text,
                        cb_estadoCivil.Text,
                        txt_telefone.Text,
                        txt_email.Text,
                        cb_funcao.Text
                    );
                    Banco.Inserir(f);

                    lb_funcionarios.Items.Clear();

                    allFuncionarios = Banco.Consultar();

                    lb_funcionarios.Items.AddRange(allFuncionarios);
                    lb_funcionarios.Refresh();
                }
            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
