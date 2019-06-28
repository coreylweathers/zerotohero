namespace  _04_Conditionals
{
    public static class ExtensionMethods
    {
        public static bool IsOdd(this int n)
        {
            return(n%2 == 1);
        }
    }
}