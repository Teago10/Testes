using _02_CacaAoBugsMVC.Model;


namespace _02_CacaAoBugsMVC.Test
{
    [TestClass]
    public  class AlunoServiceTests
    {
        [TestMethod]
        public void CalcularMedia_DaveRetornarCorreto()
        {
            //Arrange (preparar)
            var service = new AlunoService();

            //Act (Agir)
            var resultado = service.CalcularMedia(8.0, 7.5, 6.5);

            //Assert (Afirmar)
            Assert.AreEqual(7.33, resultado);
        }

        [TestMethod]
        public void CalcularMedia_DaveRetornarErro()
        {
            //Arrange (preparar)
            var service = new AlunoService();

            //Act (Agir)
            var resultado = service.CalcularMedia(6.0, 5.5, 3.5);

            //Assert (Afirmar)
            Assert.AreNotEqual(7.33, resultado);
        }

        [TestMethod]
        public void ObterSituacao_DeveRetornarCorreto()
        {
            //Arrange (preparar)
            var service = new AlunoService();

            //Act (Agir)
            var resultadoAprovado = service.ObterSituacao(8.0);
            var resultaExame = service.ObterSituacao(6.0);
            var resultadoReprovado = service.ObterSituacao(4.0);

            //Assert (Afirmar)
            Assert.AreEqual("Aprovado", resultadoAprovado);
            Assert.AreEqual("Exame Final", resultaExame);
            Assert.AreEqual("Reprovado", resultadoReprovado);
        }
    }
}
