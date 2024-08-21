using Dark.Net;

namespace NCMDumpGUI
{
    public static class GlobalVariables
    {
        public static readonly string assemblyPath = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string libncmdumpPath = assemblyPath + "libncmdump.dll";
    }

    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IDarkNet darkNet = DarkNet.Instance;
            if (!File.Exists(GlobalVariables.libncmdumpPath))
            {
                MessageBox.Show("���Ĳ�����\n��ȷ��libncmdump.dll�뱾������ͬһĿ¼", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Form mainForm = new WndMain(args);
                Theme windowTheme = Theme.Auto;
                darkNet.SetWindowThemeForms(mainForm, windowTheme);
                Application.Run(mainForm);
            }
        }
    }
}