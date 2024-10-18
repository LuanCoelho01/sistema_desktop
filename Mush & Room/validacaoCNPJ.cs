using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mush___Room
{
    internal class validacaoCNPJ
    {
        public bool ValidarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int somador;
            int resto;
            string digito;
            string cnpjAux;

            //cnpj = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

            if (cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                cnpjAux = cnpj.Substring(0, 12);
                somador = 0;

                for (int i = 0; i < 12; i++)
                {
                    somador = somador + int.Parse(cnpjAux[i].ToString()) * multiplicador1[i];
                }
                resto = (somador % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString(); //primeiro digito armazenado


                cnpjAux = cnpjAux + digito;
                somador = 0;

                for (int i = 0; i < 13; i++)
                {
                    somador = somador + int.Parse(cnpjAux[i].ToString()) * multiplicador2[i];
                }
                resto = (somador % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString(); // concatenação do primeiro digito com o segundo

                return cnpj.EndsWith(digito);


            }
        }
    }
}


//Validacao valid = new Validacao();
//mskCNPJ.TextMaskFormat = MaskFormat.IncludeLiterals;
//string cnpj = mskCNPJ.Text;
//bool verFal = valid.validarCnpj(cnpj);
//if (verFal)
//{
//    MessageBox.Show("CNPJ válido");
//}
//else
//{
//    MessageBox.Show("CNPJ Inválido");
//}
