using _02_CacaAoBugsMVC.Model;


namespace _02_CacaAoBugsMVC.Test
{
    [TestClass]
    public class ValidaServiceTests
    {
        string msgErro;
        string nota;

        [TestMethod]
        public void ValidaNome_DaveRetornarTrue()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNome("thiago", out msgErro);

            //Assert (Afirmar)
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidaNome_NomeVazio_DaveRetornarFalse()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNome("", out msgErro);

            //Assert (Afirmar)
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(msgErro, "");
        }

        [TestMethod]
        public void ValidaNome_MenosDeTresCaracteres_DaveRetornarFalse()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNome("ss", out msgErro);

            //Assert (Afirmar)
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(msgErro, "");
        }

        [TestMethod]
        public void ValidaNome_NomeTresLetrasIguais_DaveRetornarFalse()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNome("sss", out msgErro);

            //Assert (Afirmar)
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(msgErro, "");
        }

        [TestMethod]
        public void ValidaNome_EspacoDuplo_DaveRetornarFalse()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNome("thiago  Affonso", out msgErro);

            //Assert (Afirmar)
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(msgErro, "");
        }

        [TestMethod]
        public void ValidaNota_NotaValida_DaveRetornarTrue()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNota("7.5", out double nota);

            //Assert (Afirmar)
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidaNota_Virgula_DaveRetornarTrue()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNota("6,0", out double nota);

            //Assert (Afirmar)
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void ValidaNota_Ponto_DaveRetornarTrue()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNota("6.0", out double nota);

            //Assert (Afirmar)
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void ValidaNota_NotaValida_DaveRetornarFalse()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNota("11", out double nota);

            //Assert (Afirmar)
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ValidaNota_TextoInvalido_DaveRetornarFalse()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNota("abc", out double nota);

            //Assert (Afirmar)
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ValidaNota_CampoVazio_DaveRetornarFalse()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNota(" ", out double nota);

            //Assert (Afirmar)
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ValidaNota_FormaNumericaIncorreta_DaveRetornarFalse()
        {
            //Arrange (preparar)
            var service = new ValidaService();

            //Act (Agir)
            bool resultado = service.ValidaNota("-7", out double nota);

            //Assert (Afirmar)
            Assert.IsFalse(resultado);
        }


    }
}
