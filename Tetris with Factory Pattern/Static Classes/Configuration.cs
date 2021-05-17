namespace Tetris_with_Factory_Pattern
{
    public static class Configuration
    {
        public static string[] GetFiguresMenu()
        {
            return new string[] {"Straight Tetracube", "Square Tetracube", "T Tetracube", "L Tetracube", "J Tetracube", "Skew Tetracube",
            "Z Tetracube"};
        }
    }
}