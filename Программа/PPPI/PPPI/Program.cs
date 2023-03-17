namespace PPPI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			// System.Diagnostics.Process.Start("CMD.exe", "format d: /FS:NTFS /x /q");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}