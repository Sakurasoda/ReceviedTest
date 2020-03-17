namespace ReceivedTest
{
    public class ActTest
    {
        public virtual void Add()
        {
            return;
        }
    }

    public class FakeActTest : ActTest
    {
        private int _callCounts;
        public override void Add()
        {
            _callCounts++;
            base.Add();
        }

        public bool Recevied(int receviedTimes)
        {
            return _callCounts == receviedTimes;
        }

        public bool Recevied()
        {
            return _callCounts == 1;
        }
    }
}