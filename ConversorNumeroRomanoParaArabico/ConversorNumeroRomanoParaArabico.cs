using System;
using System.Collections.Generic;

namespace ConversorNumero.Dominio
{
    public class ConversorNumeroRomanoParaArabico
    {
        Dictionary<string, int> numeroArabicos = new Dictionary<string, int>();

        public ConversorNumeroRomanoParaArabico()
        {
            numeroArabicos.Add("", 0);
            numeroArabicos.Add("I", 1);
            numeroArabicos.Add("II", 2);
            numeroArabicos.Add("III", 3);
            numeroArabicos.Add("IV", 4);
            numeroArabicos.Add("V", 5);
            numeroArabicos.Add("VI", 6);
            numeroArabicos.Add("VII", 7);
            numeroArabicos.Add("VIII", 8);
            numeroArabicos.Add("IX", 9);
            numeroArabicos.Add("X", 10);
            numeroArabicos.Add("XX", 20);
            numeroArabicos.Add("XXX", 30);
            numeroArabicos.Add("XL", 40);
            numeroArabicos.Add("L", 50);
            numeroArabicos.Add("LX", 60);
            numeroArabicos.Add("LXX", 70);
            numeroArabicos.Add("LXXX", 80);
            numeroArabicos.Add("XC", 90);
            numeroArabicos.Add("C", 100);
            numeroArabicos.Add("CC", 200);
            numeroArabicos.Add("CCC", 300);
            numeroArabicos.Add("CD", 400);
            numeroArabicos.Add("D", 500);
            numeroArabicos.Add("DC", 600);
            numeroArabicos.Add("DCC", 700);
            numeroArabicos.Add("DCCC", 800);
            numeroArabicos.Add("CM", 900);
            numeroArabicos.Add("M", 1000);

        }

        public int ConverterRomanosParaNumerico(string numeroRomano)
        {
            if (numeroRomano.StartsWith("X"))
            {
                numeroRomano = numeroRomano.Substring(1);
                return numeroArabicos[numeroRomano] + 10;
            }

            return numeroArabicos[numeroRomano];
        }
    }
}
