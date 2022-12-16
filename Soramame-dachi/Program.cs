namespace Soramame_dachi
{
    internal static class Program
    {
        /// Tyler Housand
        /// Soramame-dachi
        /// A tomogachi-lite style game where you take care of a frog named Soramame.
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}