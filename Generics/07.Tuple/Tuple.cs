namespace _07.Tuple
{
    public class Tuple<T1, T2>
    {
        private T1 firstItem;

        private T2 secondItem;

        public Tuple(T1 firstItem, T2 seconitem)
        {
            this.firstItem = firstItem;
            this.secondItem = seconitem;
        }

        public override string ToString()
        => $"{firstItem} -> {secondItem}";
    }
}
