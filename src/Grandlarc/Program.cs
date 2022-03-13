using SampSharp.Core;

namespace Grandlarc
{
    internal static class Program
    {
        public static void Main()
        {
            new GameModeBuilder()
                .Use<GameMode>()
                .Run();
        }
    }
}