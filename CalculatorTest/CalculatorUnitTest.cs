using net_calculator_tester;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorUnitTest
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestSomma()
        {
            float a = 2f;
            float b = 3f;

            float aspettativa = 5f;

            float risultatoSomma = Calculator.Somma (a, b);


            Assert.AreEqual(aspettativa, risultatoSomma);
        }

        [Test]
        public void TestSottrazione()
        {
            float c = 6.2f;
            float d = 3.1f;

            float aspettativa = 3.1f;

            float risultatoSottrazione = Calculator.Sottrazione(c, d);


            Assert.AreEqual(aspettativa, risultatoSottrazione);

        }

        [Test]
        public void TestDivisione()
        {
            float e = 6.0f;
            float f = 3.0f;

            float aspettativa = 2.0f;

            float risultatoDivisione = Calculator.Divisione(e, f);


            Assert.AreEqual(aspettativa, risultatoDivisione);

        }


        [Test]
        public void TestMoltiplicazione()
        {
            float i = 6.0f;
            float l = 3.0f;

            float aspettativa = 18.0f;

            float risultatoMoltiplicazione = Calculator.Moltiplicazione(i, l);


            Assert.AreEqual(aspettativa, risultatoMoltiplicazione);

        }

    }
        
    
}