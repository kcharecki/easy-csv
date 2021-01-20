using NUnit.Framework;

namespace Easy.Csv.Tests
{
    public class Tests
    {
        private ToCsv _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new ToCsv();
        }

        [Test]
        public void Passing_Null_Returns_Empty_String()
        {
            var result = _sut.Convert(null);

            Assert.That(result == string.Empty);
        }
    }
}