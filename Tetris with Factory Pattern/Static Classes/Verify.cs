namespace Tetris_with_Factory_Pattern
{
    public static class Verify
    {
        public static bool IsChoiceExist(byte input, byte finalOption)
        {
            return input >= 1 && input <= finalOption;
        }
    }
}