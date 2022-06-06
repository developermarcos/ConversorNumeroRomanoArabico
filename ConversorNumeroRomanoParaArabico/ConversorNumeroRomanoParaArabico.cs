﻿using System;
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
            numeroArabicos.Add("MM", 2000);
            numeroArabicos.Add("MMM", 3000);
        }

        public int ConverterRomanosParaNumerico(string numeroRomano)
        {
            string[] numerosRomanosArray = numeroRomano.Split("");
            int numeroConvertido = 0;

            if (numeroRomano.StartsWith("X"))
            {
                numeroConvertido = IniciaX(numeroRomano);
            }
            else if (numeroRomano.StartsWith("L"))
            {
                numeroConvertido = IniciaL(numeroRomano);
            }
            else if (numeroRomano.StartsWith("C"))
            {
                numeroConvertido = IniciaC(numeroRomano);
            }
            else if (numeroRomano.StartsWith("D"))
            {
                numeroConvertido = IniciaD(numeroRomano);
            }
            else if (numeroRomano.StartsWith("M"))
            {
                numeroConvertido = IniciaM(numeroRomano);
            }
            else
            {
                numeroConvertido = numeroArabicos[numeroRomano];
            }

            return numeroConvertido;
        }

        private int IniciaX(string numeroRomano)
        {
            int numeroConvertido = 0;

            string numeroRomanoUnidade = "";

            if (numeroRomano.StartsWith("XXX"))
            {
                numeroRomanoUnidade = numeroRomano.Substring(3);
                numeroConvertido = 30;
            }

            else if (numeroRomano.StartsWith("XX"))
            {
                numeroRomanoUnidade = numeroRomano.Substring(2);
                numeroConvertido = 20;
            }

            else if (numeroRomano.StartsWith("XL"))
            {

                numeroRomanoUnidade = numeroRomano.Substring(2);
                numeroConvertido = 40;
            }

            else if (numeroRomano.StartsWith("XC"))
            {

                numeroRomanoUnidade = numeroRomano.Substring(2);
                numeroConvertido = 90;
            }

            else if (numeroRomano.StartsWith("X"))
            {

                numeroRomanoUnidade = numeroRomano.Substring(1);
                numeroConvertido = 10;
            }

            numeroConvertido += numeroArabicos[numeroRomanoUnidade];

            return numeroConvertido;
        }
        private int IniciaL(string numeroRomano)
        {
            int numeroConvertido = 0;
            string numeroRomanoUnidade = "";

            if (numeroRomano.StartsWith("LXXX"))
            {
                numeroRomanoUnidade = numeroRomano.Substring(4);
                numeroConvertido = 80;
            }

            else if (numeroRomano.StartsWith("LXX"))
            {
                numeroRomanoUnidade = numeroRomano.Substring(3);
                numeroConvertido = 70;
            }

            else if (numeroRomano.StartsWith("LX"))
            {
                numeroRomanoUnidade = numeroRomano.Substring(2);
                numeroConvertido = 60;
            }

            else if (numeroRomano.StartsWith("L"))
            {
                numeroRomanoUnidade = numeroRomano.Substring(1);
                numeroConvertido = 50;
            }

            numeroConvertido += numeroArabicos[numeroRomanoUnidade];
            return numeroConvertido;
        }
        private int IniciaC(string numeroRomano)
        {
            int numeroConvertido = 0;
            string numeroRomanoDecimal = "";

            if (numeroRomano.StartsWith("CCC"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(3);
                numeroConvertido = 300;
            }

            else if (numeroRomano.StartsWith("CC"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(2);
                numeroConvertido = 200;
            }

            else if (numeroRomano.StartsWith("CD"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(2);
                numeroConvertido = 400;
            }

            else if (numeroRomano.StartsWith("CM"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(2);
                numeroConvertido = 900;
            }

            else if (numeroRomano.StartsWith("C"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(1);
                numeroConvertido = 100;
            }
            numeroConvertido += ConverterRomanosParaNumerico(numeroRomanoDecimal);
            return numeroConvertido;
        }
        private int IniciaD(string numeroRomano)
        {
            int numeroConvertido = 0;
            string numeroRomanoDecimal = "";

            if (numeroRomano.StartsWith("DCCC"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(4);
                numeroConvertido = 800;
            }

            else if (numeroRomano.StartsWith("DCC"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(3);
                numeroConvertido = 700;
            }

            else if (numeroRomano.StartsWith("DC"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(2);
                numeroConvertido = 600;
            }

            else if (numeroRomano.StartsWith("D"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(1);
                numeroConvertido = 500;
            }

            numeroConvertido += ConverterRomanosParaNumerico(numeroRomanoDecimal);
            
            return numeroConvertido;
        }
        private int IniciaM(string numeroRomano)
        {
            int numeroConvertido = 0;
            string numeroRomanoDecimal = "";

            if (numeroRomano.StartsWith("MMM"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(3);
                numeroConvertido = 3000;
            }

            else if (numeroRomano.StartsWith("MM"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(2);
                numeroConvertido = 2000;
            }

            else if (numeroRomano.StartsWith("M"))
            {
                numeroRomanoDecimal = numeroRomano.Substring(1);
                numeroConvertido = 1000;
            }

            numeroConvertido += ConverterRomanosParaNumerico(numeroRomanoDecimal);

            return numeroConvertido;
        }
    }
}
