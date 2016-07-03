namespace TestGitLib
{
    public static class SilverCutCounter
    {
        public static int GetNumber(int index)
        {
            if (index == 1)
            {
                return 1;
            }
            else if (index == 2)
            {
                return 3;
            }
            else if (index > 10 || index < 1)
            {
                return 0;
            }
            else
            {
                return GetNumber(index - 1) + GetNumber(index - 2);
            }
        }
    }
}
