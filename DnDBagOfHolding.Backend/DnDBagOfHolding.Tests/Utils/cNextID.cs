namespace DnDBagOfHolding.Tests.Utils
{
    public class cNextID
    {
        private static int lastId = 0;

        public static int NextId()
        {
            return Interlocked.Increment(ref lastId);
        }
    }
}
