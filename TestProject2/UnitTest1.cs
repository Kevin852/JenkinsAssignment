using NUnit.Framework;
using Assignment;

namespace TestProject2
{
    [TestFixture]
    public class UnitTest1
    {
        Assignment1 a1 = new Assignment1();
        Add a = new Add();
        Bank b = new Bank();
        
       [Test]
        public void TestCalcTotal()
        {
            double actual = a1.calculateTotalPrice(20);
            Assert.AreEqual(expected:24,actual);
        }
        [Test]
        public void TestAdd()
        {
            int actual = a.addition(20,10);
            Assert.AreEqual(expected: 30, actual);
           
        }
        [Test]
        public void TestDeposit()
        {
            double actual = b.deposit(2000);
            Assert.Greater(8000, actual);
        }
        [Test]
        public void TestWithdraw()
        {
            double actual = b.withdraw(2000);
            Assert.Less(1000, actual);
        }
    }
}
