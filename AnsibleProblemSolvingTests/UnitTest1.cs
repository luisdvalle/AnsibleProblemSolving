using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintNumbers;

namespace AnsibleProblemSolvingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            PrintNumbers.PrintNumbers processor = new PrintNumbers.PrintNumbers();

            // Act
            TypeNumber typeNumber1 = processor.ProcessNumber(1);
            TypeNumber typeNumber2 = processor.ProcessNumber(3);
            TypeNumber typeNumber3 = processor.ProcessNumber(5);
            TypeNumber typeNumber4 = processor.ProcessNumber(15);

            // Assert
            Assert.AreEqual(TypeNumber.None, typeNumber1);
            Assert.AreEqual(TypeNumber.Ansible, typeNumber2);
            Assert.AreEqual(TypeNumber.Australia, typeNumber3);
            Assert.AreEqual(TypeNumber.AnsibleAustralia, typeNumber4);
        }
    }
}
