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
        [DataRow("XXI", 21)]
        [DataRow("XXII", 22)]
        [DataRow("XXIII", 23)]
        [DataRow("XXIV", 24)]
        [DataRow("XXV", 25)]
        [DataRow("XXVI", 26)]
        [DataRow("XXVII", 27)]
        [DataRow("XXVIII", 28)]
        [DataRow("XXIX", 29)]
        [DataRow("XXX", 30)]
        public void Deve_converter_romanos_numeros_do_21_ao_30(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XXXI", 31)]
        [DataRow("XXXII", 32)]
        [DataRow("XXXIII", 33)]
        [DataRow("XXXIV", 34)]
        [DataRow("XXXV", 35)]
        [DataRow("XXXVI", 36)]
        [DataRow("XXXVII", 37)]
        [DataRow("XXXVIII", 38)]
        [DataRow("XXXIX", 39)]
        [DataRow("XL", 40)]
        public void Deve_converter_romanos_numeros_do_31_ao_40(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XLI", 41)]
        [DataRow("XLII", 42)]
        [DataRow("XLIII", 43)]
        [DataRow("XLIV", 44)]
        [DataRow("XLV", 45)]
        [DataRow("XLVI", 46)]
        [DataRow("XLVII", 47)]
        [DataRow("XLVIII", 48)]
        [DataRow("XLIX", 49)]
        [DataRow("L", 50)]
        public void Deve_converter_romanos_numeros_do_41_ao_50(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XCI", 91)]
        [DataRow("XCII", 92)]
        [DataRow("XCIII", 93)]
        [DataRow("XCIV", 94)]
        [DataRow("XCV", 95)]
        [DataRow("XCVI", 96)]
        [DataRow("XCVII", 97)]
        [DataRow("XCVIII", 98)]
        [DataRow("XCIX", 99)]
        [DataRow("C", 100)]
        public void Deve_converter_romanos_numeros_do_91_ao_100(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LI", 51)]
        [DataRow("LII", 52)]
        [DataRow("LIII", 53)]
        [DataRow("LIV", 54)]
        [DataRow("LV", 55)]
        [DataRow("LVI", 56)]
        [DataRow("LVII", 57)]
        [DataRow("LVIII", 58)]
        [DataRow("LIX", 59)]
        [DataRow("LX", 60)]
        public void Deve_converter_romanos_numeros_do_51_ao_60(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LXI", 61)]
        [DataRow("LXII", 62)]
        [DataRow("LXIII", 63)]
        [DataRow("LXIV", 64)]
        [DataRow("LXV", 65)]
        [DataRow("LXVI", 66)]
        [DataRow("LXVII", 67)]
        [DataRow("LXVIII", 68)]
        [DataRow("LXIX", 69)]
        [DataRow("LXX", 70)]
        public void Deve_converter_romanos_numeros_do_61_ao_70(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LXXI", 71)]
        [DataRow("LXXII", 72)]
        [DataRow("LXXIII", 73)]
        [DataRow("LXXIV", 74)]
        [DataRow("LXXV", 75)]
        [DataRow("LXXVI", 76)]
        [DataRow("LXXVII", 77)]
        [DataRow("LXXVIII", 78)]
        [DataRow("LXXIX", 79)]
        [DataRow("LXXX", 80)]
        public void Deve_converter_romanos_numeros_do_71_ao_80(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LXXXI", 81)]
        [DataRow("LXXXII", 82)]
        [DataRow("LXXXIII", 83)]
        [DataRow("LXXXIV", 84)]
        [DataRow("LXXXV", 85)]
        [DataRow("LXXXVI", 86)]
        [DataRow("LXXXVII", 87)]
        [DataRow("LXXXVIII", 88)]
        [DataRow("LXXXIX", 89)]
        [DataRow("XC", 90)]
        public void Deve_converter_romanos_numeros_do_81_ao_90(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        //[TestMethod]
        //[DataRow("CI", 101)]
        //[DataRow("CII", 102)]
        //[DataRow("CIII", 103)]
        //[DataRow("CIV", 104)]
        //[DataRow("CV", 105)]
        //[DataRow("CVI", 106)]
        //[DataRow("CVII", 107)]
        //[DataRow("CVIII", 108)]
        //[DataRow("CIX", 109)]
        //[DataRow("CX", 110)]
        //public void Deve_converter_romanos_numeros_do_101_ao_110(string numero, int resultadoEsperado)
        //{
        //    string numeroRomano = numero;

        //    //ação - action 
        //    var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

        //    //verificação - assert
        //    Assert.AreEqual(resultadoEsperado, resultado);
        //}

        [TestMethod]
        [DataRow("CXI", 111)]
        [DataRow("CXXIII", 123)]
        [DataRow("CXXXV", 135)]
        [DataRow("CXLVII", 147)]
        [DataRow("CLVIII", 158)]
        [DataRow("CLXIX", 169)]
        [DataRow("CLXXI", 171)]
        [DataRow("CLXXXII", 182)]
        [DataRow("CXCIII", 193)]
        [DataRow("CC", 200)]
        public void Deve_converter_romanos_numeros_entre_111_e_200(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("CCI", 201)]
        [DataRow("CMXCIX", 999)]
        [DataRow("CCCLVII", 357)]
        [DataRow("CDLVI", 456)]
        [DataRow("DLXXXII", 582)]
        [DataRow("DCXXXIX", 639)]
        [DataRow("DCCXLI", 741)]
        [DataRow("DCCCXLVI", 846)]
        [DataRow("CMXXX", 930)]
        [DataRow("CDLVIII", 458)]
        public void Deve_converter_romanos_numeros_entre_201_e_999(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversorNumeroRomanoParaArabico.ConverterRomanosParaNumerico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("M", 1000)]
        [DataRow("MMMCMXCIX", 3999)]
        [DataRow("MMCXXVII", 2127)]
        [DataRow("MDCCLVIII", 1758)]
        [DataRow("MMDCLXXXIV", 2684)]
        [DataRow("MMMCCXLVIII", 3248)]
        [DataRow("MDCLXXXVII", 1687)]
        [DataRow("MMMCCX", 3210)]
        [DataRow("MCDXCVI", 1496)]
        [DataRow("MMDCCCLXXIX", 2879)]
        public void Deve_converter_romanos_numeros_entre_1000_e_3999(string numero, int resultadoEsperado)
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
