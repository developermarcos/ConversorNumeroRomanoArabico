using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumero.Dominio
{
    public class ConversorNumeroArabicoParaRomano
    {
        Dictionary<int, string> numeroRomanos = new Dictionary<int, string>();

        public ConversorNumeroArabicoParaRomano()
        {
            numeroRomanos.Add(0, "");
            numeroRomanos.Add(1, "I");
            numeroRomanos.Add(2, "II");
            numeroRomanos.Add(3, "III");
            numeroRomanos.Add(4, "IV");
            numeroRomanos.Add(5, "V");
            numeroRomanos.Add(6, "VI");
            numeroRomanos.Add(7, "VII");
            numeroRomanos.Add(8, "VIII");
            numeroRomanos.Add(9, "IX");
            numeroRomanos.Add(10, "X");
            numeroRomanos.Add(20, "XX");
            numeroRomanos.Add(30, "XXX");
            numeroRomanos.Add(40, "XL");
            numeroRomanos.Add(50, "L");
            numeroRomanos.Add(60, "LX");
            numeroRomanos.Add(70, "LXX");
            numeroRomanos.Add(80, "LXXX");
            numeroRomanos.Add(90, "XC");
            numeroRomanos.Add(100, "C");
            numeroRomanos.Add(200, "CC");
            numeroRomanos.Add(300, "CCC");
            numeroRomanos.Add(400, "CD");
            numeroRomanos.Add(500, "D");
            numeroRomanos.Add(600, "DC");
            numeroRomanos.Add(700, "DCC");
            numeroRomanos.Add(800, "DCCC");
            numeroRomanos.Add(900, "CM");
            numeroRomanos.Add(1000, "M");
            numeroRomanos.Add(2000, "MM");
            numeroRomanos.Add(3000, "MMM");

        }
        public string TesteConverterNumericoParaRomano(int numeroParaConverter)
        {
            string numeroConvertido = "";

            if ((numeroParaConverter / 1000) >= 1)
            {
                numeroConvertido = EscreverMilhar(numeroParaConverter );
            }
            else if ((numeroParaConverter / 100) >= 1)
            {
                numeroConvertido = EscreverCentena(numeroParaConverter);
            }
            else if ((numeroParaConverter / 10) >= 1)
            {
                numeroConvertido = EscreveDezena(numeroParaConverter);
            }
            else
                numeroConvertido = ConvertNumeroParaRomano(numeroParaConverter);

            return numeroConvertido;
        }

        private string EscreverMilhar(int numeroParaConverter)
        {
            string numeroConvertido = "";
            if (numeroParaConverter % 1000 == 0)
            {
                numeroConvertido += ConvertNumeroParaRomano(numeroParaConverter);
            }
            else
            {
                int milhar = numeroParaConverter / 1000;
                numeroConvertido += ConvertNumeroParaRomano(milhar*1000);
                int centena = numeroParaConverter % 1000;
                numeroConvertido += EscreverCentena(centena);
            }

            return numeroConvertido;
        }

        private string EscreverCentena(int numeroParaConverter)
        {
            string numeroConvertido = "";

            if (numeroParaConverter % 100 == 0)
            {
                numeroConvertido += ConvertNumeroParaRomano(numeroParaConverter);
            }
            else
            {
                int milhar = numeroParaConverter / 100;
                numeroConvertido += ConvertNumeroParaRomano(milhar*100);
                int dezena = numeroParaConverter % 100;
                numeroConvertido += EscreveDezena(dezena);
            }

            return numeroConvertido;
        }

        private string EscreveDezena(int numeroParaConverter)
        {
            string dezenaRomanos = "";

            if (numeroParaConverter % 10 == 0)
            {
                dezenaRomanos += ConvertNumeroParaRomano(numeroParaConverter);
            }
            else
            {
                int dezena = numeroParaConverter / 10;
                dezenaRomanos += ConvertNumeroParaRomano(dezena*10);
                int unidade = numeroParaConverter % 10;
                dezenaRomanos += ConvertNumeroParaRomano(unidade);
            }

            return dezenaRomanos;
        }

        private string ConvertNumeroParaRomano(int numero)
        {
            return numeroRomanos[numero];
        }
    }
}
