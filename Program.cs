using Dark.Net;

namespace NCMDumpGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IDarkNet darkNet = DarkNet.Instance;
            if (!File.Exists("libncmdump.dll"))
            {
                MessageBox.Show("���Ĳ�����\n��ȷ��libncmdump.dll�뱾������ͬһĿ¼", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Form mainForm = new WndMain();
                Theme windowTheme = Theme.Auto;
                darkNet.SetWindowThemeForms(mainForm, windowTheme);
                Application.Run(mainForm);
            }
        }
    }
}