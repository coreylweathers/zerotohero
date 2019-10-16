namespace _14_Scope
{
    using System;
    public class Difference
    {
        protected int[] Elements { get; }
        public int MaximumDifference {get;set;}

        public Difference(int[] array)
        {
            Elements = array;
        }

        public void ComputeDifference()
        {
            Array.Sort(Elements);

            var maxElement = Elements.Length -1;

            MaximumDifference = Math.Abs(Elements[maxElement] - Elements[0]);
        }

    }
}