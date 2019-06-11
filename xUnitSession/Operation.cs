namespace xUnitSession
{
    public class Operation : IOperation
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
