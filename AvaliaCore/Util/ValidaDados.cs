using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADVCore.Service
{
    /// <summary>
    /// Classe com métodos básicos de validação.
    /// </summary>
    public class ValidaDados
    {
        /// <summary>
        /// Método verifica se na string repassada contém caracteres especiais
        /// </summary>
        /// <param name="dados">Dados a ser analisado</param>
        /// <returns>Bolean de resultado.</returns>
        public static bool ExistCaracterEspeciais(String dados)
        {
            return Regex.IsMatch(dados, (@"[!""#$%&'()*+,/:;?@[\\\]_`{|}~]"));
        }

        /// <summary>
        /// Método valida se o CPF repassado está correto.
        /// </summary>
        /// <param name="Cpf">Cpf a ser avaliado</param>
        /// <returns>Bolleando de confirmação</returns>
        public static bool ValidaCpf(String Cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            Cpf = Cpf.Trim();
            Cpf = Cpf.Replace(".", "").Replace("-", "");
            if (Cpf.Length != 11)
                return false;
            tempCpf = Cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return Cpf.EndsWith(digito);
        
        }
        /// <summary>
        /// Método vérifica se a string repassada contém somente números
        /// </summary>
        /// <param name="dado">String para analise</param>
        /// <returns></returns>
        public static bool SoNumeros(String dado)
        {
            return Regex.IsMatch(dado, @"\d$") &&
                   !Regex.IsMatch(dado, (@"[!""#$%&'()*+,:;?@[\\\]_`{|}~]"));
        }

        public static bool ContemNumeros(String dado)
        {
            return Regex.IsMatch(dado, @"[0-9]");
        }

        public static bool ValidaCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)

                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            }

            resto = (soma % 11);

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }
            resto = (soma % 11);
            if (resto < 2)
            {

                resto = 0;
            }else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}

