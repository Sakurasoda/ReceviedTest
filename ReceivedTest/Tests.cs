using NUnit.Framework;

namespace ReceivedTest
{
    [TestFixture]
    public class Tests
    {
        private FakeActTest _actTest;

        [SetUp]
        public void SetUp()
        {
            _actTest = new FakeActTest();
        }

        [Test]
        public void recevied_without_parameter()
        {
            _actTest.Add();
            Assert.IsTrue(_actTest.Recevied());
        }
        
        [Test]
        public void recevied_1_but_method_is_not_call_fail()
        {
            Assert.IsFalse(_actTest.Recevied(1));
        }
        
        [Test]
        public void recevied_3()
        {
            _actTest.Add();
            _actTest.Add();
            _actTest.Add();
            Assert.IsTrue(_actTest.Recevied(3));
        }
    }
}