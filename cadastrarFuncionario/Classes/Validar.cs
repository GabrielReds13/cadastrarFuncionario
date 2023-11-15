using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastrarFuncionario.Properties;

namespace CadastrarFuncionario
{
    public static class Validar
    {
        // - Metodos -
        public static bool Cpf(string cpf)
        {
            try
            {
                // Variaveis
                int num1 = 0, num2 = 0;

                // Formatar cpf
                cpf = cpf.Replace(".", "").Replace(",", "").Replace("-", "");
                char[] cpfChar = cpf.ToCharArray();

                // Validar tamanho
                if (cpfChar.Length != 11)
                {
                    MessageBox.Show($"CPF inválido.");
                    return false;
                }
                else
                {
                    // Calcular numeros
                    for (int i = 0, j = 10; i < (cpfChar.Length - 2); i++, j--) num1 += (Convert.ToInt32(cpfChar[i].ToString()) * j);
                    num1 = num1 % 11;

                    // Verificar num1
                    if (num1 >= 2) num1 = 11 - num1;
                    else if (num1 == 0) { }
                    else
                    {
                        MessageBox.Show($"CPF inválido.");
                        return false;
                    }

                    // Validar num1
                    if (num1 == Convert.ToInt32(cpfChar[9].ToString()))
                    {
                        // Calcular numeros
                        for (int i = 0, j = 11; i < (cpfChar.Length - 1); i++, j--) num2 += (Convert.ToInt32(cpfChar[i].ToString()) * j);
                        num2 = num2 % 11;

                        // Verificar num1
                        if (num2 >= 2) num2 = 11 - num2;
                        else if (num2 == 0) { }
                        else
                        {
                            MessageBox.Show($"CPF inválido.");
                            return false;
                        }

                        // Validar num2
                        if (num2 == Convert.ToInt32(cpfChar[10].ToString())) return true;
                        else
                        {
                            MessageBox.Show($"CPF inválido.");
                            return false;
                        }
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar CPF.");
                return false;
            }
        }

        public static bool Telefone(string telefone)
        {
            try
            {
                // Formatar telefone
                telefone = telefone.Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace(" ", "");
                char[] telChar = telefone.ToCharArray();

                // Verificar
                if (telChar.Length == 11) return true;
                else
                {
                    MessageBox.Show($"Telefone inválido.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar telefone.");
                return false;
            }
        }

        public static bool DataNasc(string dataNasc)
        {
            try
            {
                // Formatar
                DateTime dataAtual = DateTime.Today, ConvDataNasc = Convert.ToDateTime(dataNasc);

                // Calcular
                int calcDataAtual = (dataAtual.Year * 100 + dataAtual.Month) * 100 + dataAtual.Day,
                calcDataNasc = (ConvDataNasc.Year * 100 + ConvDataNasc.Month) * 100 + ConvDataNasc.Day,
                calcIdade = (calcDataAtual - calcDataNasc) / 10000;

                // Validar
                if (Convert.ToByte(calcIdade) >= 18) return true;
                else
                {
                    MessageBox.Show($"Você não é maior de idade!\nData de nascimento inválida.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar data de nascimento.");
                return false;
            }
        }

        public static bool Email(string email)
        {
            try
            {
                // Formatar
                bool validarEmail = Regex.IsMatch(email, @"^[a-zA-Z0-9.]+@[a-z]+\.[a-z]+$");

                // Validar
                if (validarEmail != false) return true;
                else
                {
                    MessageBox.Show("Email inválido.");
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao validar email.");
                return false;
            }
        }
    }
}
