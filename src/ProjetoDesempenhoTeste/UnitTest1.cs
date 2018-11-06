using NUnit.Framework;
using ProjetoDesempenho;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Orcamento orcamento = new Orcamento(100.0);
            Imposto imposto = new Imposto();
            double result = imposto.calcula(orcamento);
            // valor esperado, valor obtido
            Assert.AreEqual(10.0, result);
        }
    }
}