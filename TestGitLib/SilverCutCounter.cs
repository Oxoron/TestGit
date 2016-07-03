namespace TestGitLib
{
    public static class SilverCutCounter
    {
        // 1-3-4-7-11 sequence. Do not remember it's name.
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
