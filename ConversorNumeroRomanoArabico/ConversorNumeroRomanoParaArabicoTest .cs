using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ConversorNumero.Dominio;

namespace ConversorNumero.Teste
{
    [TestClass]
    public class ConversorNumeroRomanoParaArabicoTest
    {
        private ConversorNumeroRomanoParaArabico conversorNumeroRomanoParaArabico;
        private ConversorNumeroArabicoParaRomano conversorArabicoParaRomano;

        public ConversorNumeroRomanoParaArabicoTest()
        {
            conversorNumeroRomanoParaArabico = new ConversorNumeroRomanoParaArabico();
            conversorArabicoParaRomano = new ConversorNumeroArabicoParaRomano();
        }

        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        public void Deve_converter_romanos_numeros_do_1_ao_10(string numero, int resultadoEsperado)
        {
            //cenário - arrange
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XI", 11)]
        [DataRow("XII", 12)]
        [DataRow("XIII", 13)]
        [DataRow("XIV", 14)]
        [DataRow("XV", 15)]
        [DataRow("XVI", 16)]
        [DataRow("XVII", 17)]
        [DataRow("XVIII", 18)]
        [DataRow("XIX", 19)]
        [DataRow("XX", 20)]
        public void Deve_converter_romanos_numeros_do_11_ao_20(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(1,"I")]
        [DataRow(2,"II")]
        [DataRow(3,"III")]
        [DataRow(4,"IV")]
        [DataRow(5,"V")]
        [DataRow(6,"VI")]
        [DataRow(7,"VII")]
        [DataRow(8,"VIII")]
        [DataRow(9,"IX")]
        [DataRow(10, "X")]

        public void Deve_converter_numeros_romanos_do_1_ao_10(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroRomano = numero;

            //ação - action 
            //var resultado = conversor.Converter(numeroRomano);
            var resultado = conversorArabicoParaRomano.TesteConverterNumericoParaRomano(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(11, "XI")]
        [DataRow(12, "XII")]
        [DataRow(13, "XIII")]
        [DataRow(14, "XIV")]
        [DataRow(15, "XV")]
        [DataRow(16, "XVI")]
        [DataRow(17, "XVII")]
        [DataRow(18, "XVIII")]
        [DataRow(19, "XIX")]
        [DataRow(20, "XX")]
        public void Deve_converter_numeros_romanos_do_11_ao_20(int numero, string resultadoEsperado)
        {
            int numeroRomano = numero;

            //ação - action 
            //var resultado = conversor.Converter(numeroRomano);
            var resultado = conversorArabicoParaRomano.TesteConverterNumericoParaRomano(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow(27, "XXVII")]
        [DataRow(33, "XXXIII")]
        [DataRow(42, "XLII")]
        [DataRow(56, "LVI")]
        [DataRow(68, "LXVIII")]
        [DataRow(91, "XCI")]
        [DataRow(82, "LXXXII")]
        [DataRow(64, "LXIV")]
        [DataRow(68, "LXVIII")]
        [DataRow(44, "XLIV")]
        [DataRow(99, "XCIX")]
        public void Deve_converter_numeros_romanos_entre21_a_99(int numero, string resultadoEsperado)
        {
            int numeroRomano = numero;

            //ação - action 
            //var resultado = conversor.Converter(numeroRomano);
            var resultado = conversorArabicoParaRomano.TesteConverterNumericoParaRomano(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow(100, "C")]
        [DataRow(999, "CMXCIX")]
        [DataRow(231, "CCXXXI")]
        [DataRow(349, "CCCXLIX")]
        [DataRow(485, "CDLXXXV")]
        [DataRow(571, "DLXXI")]
        [DataRow(638, "DCXXXVIII")]
        [DataRow(755, "DCCLV")]
        [DataRow(815, "DCCCXV")]
        [DataRow(908, "CMVIII")]
        public void Deve_converter_numeros_romanos_entre100_a_999(int numero, string resultadoEsperado)
        {
            int numeroRomano = numero;

            //ação - action 
            //var resultado = conversor.Converter(numeroRomano);
            var resultado = conversorArabicoParaRomano.TesteConverterNumericoParaRomano(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [DataRow(1000, "M")]
        [DataRow(3999, "MMMCMXCIX")]
        [DataRow(1915, "MCMXV")]
        [DataRow(2511, "MMDXI")]
        [DataRow(3855, "MMMDCCCLV")]
        [DataRow(1777, "MDCCLXXVII")]
        [DataRow(2222, "MMCCXXII")]
        [DataRow(3333, "MMMCCCXXXIII")]
        [DataRow(3589, "MMMDLXXXIX")]
        [DataRow(2039, "MMXXXIX")]
        public void Deve_converter_numeros_romanos_entre1000_a_3999(int numero, string resultadoEsperado)
        {
            int numeroRomano = numero;

            //ação - action 
            //var resultado = conversor.Converter(numeroRomano);
            var resultado = conversorArabicoParaRomano.TesteConverterNumericoParaRomano(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
