using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADVCore.Service;
using System.Globalization;

namespace Scheque.Uteis
{
    public class Util
    {

        /// <summary>
        /// Metodo para converter a data do padrão normal para data por extenso
        /// </summary>
        /// <param name="data">DateTime contendo data para ser convertida</param>
        /// <returns>String contendo data por extenso</returns>
        public static String ConverteData(DateTime data)
        {
            CultureInfo culture = new CultureInfo("pt-br");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            int dia = data.Day;
            int ano = data.Year;
            String mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
            String diaString = "";

            switch (dia)
            {
                case 1:
                    diaString = "Primeiro";
                    break;

                case 2:
                    diaString = "Dois";
                    break;

                case 3:
                    diaString = "Três";
                    break;

                case 4:
                    diaString = "Quatro";
                    break;

                case 5:
                    diaString = "Cinco";
                    break;

                case 6:
                    diaString = "Seis";
                    break;

                case 7:
                    diaString = "Sete";
                    break;

                case 8:
                    diaString = "Oito";
                    break;

                case 9:
                    diaString = "Nove";
                    break;

                case 10:
                    diaString = "Dez";
                    break;

                case 11:
                    diaString = "Onze";
                    break;

                case 12:
                    diaString = "Doze";
                    break;

                case 13:
                    diaString = "Treze";
                    break;

                case 14:
                    diaString = "Quatorze";
                    break;

                case 15:
                    diaString = "Quinze";
                    break;

                case 16:
                    diaString = "Dezesseis";
                    break;

                case 17:
                    diaString = "Dezessete";
                    break;

                case 18:
                    diaString = "Dezoito";
                    break;

                case 19:
                    diaString = "Dezenove";
                    break;

                case 20:
                    diaString = "Vinte";
                    break;

                case 21:
                    diaString = "Vinte e um";
                    break;

                case 22:
                    diaString = "Vinte e dois";
                    break;

                case 23:
                    diaString = "Vinte e três";
                    break;

                case 24:
                    diaString = "Vinte e quatro";
                    break;

                case 25:
                    diaString = "Vinte e cinco";
                    break;

                case 26:
                    diaString = "Vinte e seis";
                    break;

                case 27:
                    diaString = "Vinte e sete";
                    break;

                case 28:
                    diaString = "Vinte e oito";
                    break;

                case 29:
                    diaString = "Vinte e nove";
                    break;

                case 30:
                    diaString = "Trinta";
                    break;

                case 31:
                    diaString = "Trinta e um";
                    break;
            }

            return String.Format("{0} de {1} de {2}.", diaString, mes, ano);
        }

        /// <summary>
        /// Método define o dia da semana
        /// </summary>
        /// <param name="data">Data a ser analisada</param>
        /// <returns>Retorna o dia da semana </returns>
        public static String DiaDaSemana(DateTime data)
        {
            switch (data.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    return "Sexta-Feira";
                case DayOfWeek.Monday:
                    return "Segunda-Feira";
                case DayOfWeek.Saturday:
                    return "Sábado";
                case DayOfWeek.Sunday:
                    return "Domingo";
                case DayOfWeek.Thursday:
                    return "Quinta-Feira";
                case DayOfWeek.Tuesday:
                    return "Terça-Feira";
                default:
                    return "Quarta-Feira";
            }
        }

        /// <summary>
        /// Aplica a mascara de CPF para texto de 11 carcacteres e CNPJ para texto 14 caracteres
        /// </summary>
        /// <param name="texto">Texto aplicar a mascara</param>
        /// <returns>Texto com a mascara</returns>
        public static String AplicaMascara(String texto)
        {

            if (texto.Length == 11)
            {
                return texto.Substring(0, 3) + "." + texto.Substring(3, 3) +
                       "." + texto.Substring(6, 3) + "-" + texto.Substring(9, 2);
            }
            else if (texto.Length == 14)
            {
                return texto.Substring(0, 2) + "." + texto.Substring(2, 3) + "." +
                       texto.Substring(5, 3) + "/" + texto.Substring(8, 4) + "-" +
                       texto.Substring(12, 2);
            }
            else
            {
                throw new Exception("Dados do documento estão errados.");
            }

            return texto;
        }

        /// <summary>
        /// Método preenche os dados restantes com o caracter repassado
        /// </summary>
        /// <param name="texto">Texto a ser preenchido</param>
        /// <param name="tamanho">Tamanho da mascara</param>
        /// <param name="preencher">Com que caractere deve ser preenchido</param>
        /// <returns></returns>
        public static string PreencheMascara(string texto, int tamanho, char preencher)
        {
            if (texto.Length < tamanho)
            {
                int tTamanho = texto.Length;
                for (int i = 0; i < tamanho - tTamanho; i++)
                {
                    texto = preencher + texto;
                }
            }

            return texto;

        }
        /// <summary>
        /// Transforma o valor por extenso o que foi repassado por parametro 
        /// </summary>
        /// <param name="valor">Valor a ser repassado para converter por extenso</param>
        /// <returns>Valor por extenso</returns>
        public static string toExtenso(decimal valor)
        {
            if (valor <= 0 | valor >= 1000000000000000)
                return "Valor não suportado pelo sistema.";
            else
            {
                string strValor = valor.ToString("000000000000000.00");
                string valor_por_extenso = string.Empty;

                for (int i = 0; i <= 15; i += 3)
                {
                    valor_por_extenso += escreva_parte(Convert.ToDecimal(strValor.Substring(i, 3)));
                    if (i == 0 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
                            valor_por_extenso += " TRILHÃO" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0)
                                                     ? " E "
                                                     : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
                            valor_por_extenso += " TRILHÕES" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0)
                                                     ? " E "
                                                     : string.Empty);
                    }
                    else if (i == 3 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                            valor_por_extenso += " BILHÃO" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0)
                                                     ? " E "
                                                     : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                            valor_por_extenso += " BILHÕES" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0)
                                                     ? " E "
                                                     : string.Empty);
                    }
                    else if (i == 6 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                            valor_por_extenso += " MILHÃO" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0)
                                                     ? " E "
                                                     : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                            valor_por_extenso += " MILHÕES" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0)
                                                     ? " E "
                                                     : string.Empty);
                    }
                    else if (i == 9 & valor_por_extenso != string.Empty)
                        if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                            valor_por_extenso += " MIL" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0)
                                                     ? " E "
                                                     : string.Empty);

                    if (i == 12)
                    {
                        if (valor_por_extenso.Length > 8)
                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "BILHÃO" |
                                valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "MILHÃO")
                                valor_por_extenso += " DE";
                            else if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "BILHÕES" |
                                     valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "MILHÕES" |
                                     valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "TRILHÕES")
                                valor_por_extenso += " DE";
                            else if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "TRILHÕES")
                                valor_por_extenso += " DE";

                        if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                            valor_por_extenso += " REAL";
                        else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                            valor_por_extenso += " REAIS";

                        if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                            valor_por_extenso += " E ";
                    }

                    if (i == 15)
                        if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                            valor_por_extenso += " CENTAVO";
                        else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                            valor_por_extenso += " CENTAVOS";
                }

                return valor_por_extenso;
            }
        }

        private static string escreva_parte(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }

                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));

                if (a == 1) montagem += (b + c == 0) ? "CEM" : "CENTO";
                else if (a == 2)
                    montagem += "DUZENTOS";
                else if (a == 3)
                    montagem += "TREZENTOS";
                else if (a == 4)
                    montagem += "QUATROCENTOS";
                else if (a == 5)
                    montagem += "QUINHENTOS";
                else if (a == 6)
                    montagem += "SEISCENTOS";
                else if (a == 7)
                    montagem += "SETECENTOS";
                else if (a == 8)
                    montagem += "OITOCENTOS";
                else if (a == 9)
                    montagem += "NOVECENTOS";

                if (b == 1)
                {
                    if (c == 0) montagem += ((a > 0) ? " E " : string.Empty) + "DEZ";
                    else if (c == 1)
                        montagem += ((a > 0) ? " E " : string.Empty) + "ONZE";
                    else if (c == 2)
                        montagem += ((a > 0) ? " E " : string.Empty) + "DOZE";
                    else if (c == 3)
                        montagem += ((a > 0) ? " E " : string.Empty) + "TREZE";
                    else if (c == 4)
                        montagem += ((a > 0) ? " E " : string.Empty) + "QUATORZE";
                    else if (c == 5)
                        montagem += ((a > 0) ? " E " : string.Empty) + "QUINZE";
                    else if (c == 6)
                        montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSEIS";
                    else if (c == 7)
                        montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSETE";
                    else if (c == 8)
                        montagem += ((a > 0) ? " E " : string.Empty) + "DEZOITO";
                    else if (c == 9)
                        montagem += ((a > 0) ? " E " : string.Empty) + "DEZENOVE";
                }
                else if (b == 2)
                    montagem += ((a > 0) ? " E " : string.Empty) + "VINTE";
                else if (b == 3)
                    montagem += ((a > 0) ? " E " : string.Empty) + "TRINTA";
                else if (b == 4)
                    montagem += ((a > 0) ? " E " : string.Empty) + "QUARENTA";
                else if (b == 5)
                    montagem += ((a > 0) ? " E " : string.Empty) + "CINQUENTA";
                else if (b == 6)
                    montagem += ((a > 0) ? " E " : string.Empty) + "SESSENTA";
                else if (b == 7)
                    montagem += ((a > 0) ? " E " : string.Empty) + "SETENTA";
                else if (b == 8)
                    montagem += ((a > 0) ? " E " : string.Empty) + "OITENTA";
                else if (b == 9)
                    montagem += ((a > 0) ? " E " : string.Empty) + "NOVENTA";

                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " E ";

                if (strValor.Substring(1, 1) != "1")
                    if (c == 1)
                        montagem += "UM";
                    else if (c == 2)
                        montagem += "DOIS";
                    else if (c == 3)
                        montagem += "TRÊS";
                    else if (c == 4)
                        montagem += "QUATRO";
                    else if (c == 5)
                        montagem += "CINCO";
                    else if (c == 6)
                        montagem += "SEIS";
                    else if (c == 7)
                        montagem += "SETE";
                    else if (c == 8)
                        montagem += "OITO";
                    else if (c == 9)
                        montagem += "NOVE";

                return montagem;
            }
        }
    }
}
