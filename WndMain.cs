using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NCMDumpGUI
{
    public partial class WndMain : Form
    {
        // ��ʼ��
        public WndMain()
        {
            InitializeComponent();
            toolTip.SetToolTip(fixMetaDataCheckBox, "����������ϸ��Ϣ��ӵ�ת������ļ�\nע�⣺���ܱ�֤100%��������������Ԫ���ݿ����޷��޸���");
            toolTip.SetToolTip(convertButton, "�����ʼת���ļ����ܱ�����������ʶ��ĸ�ʽ");
            fileFolderComboBox.SelectedIndex = 0;

        }

        // ���ڱ������Ҽ��˵�
        #region fields
        private const int WM_SYSCOMMAND = 0X112;
        private const int MF_STRING = 0X0;
        private const int MF_SEPARATOR = 0X800;
        private enum SystemMenuItem : int
        {
            About,
        }
        #endregion

        #region GetSystemMenu
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        #endregion

        #region AppendMenu
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);
        #endregion

        #region InsertMenu
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);
        #endregion

        #region OnHandleCreated
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            var hSysMenu = GetSystemMenu(this.Handle, false);
            AppendMenu(hSysMenu, MF_SEPARATOR, 0, String.Empty);
            AppendMenu(hSysMenu, MF_STRING, (int)SystemMenuItem.About, "����");
        }
        #endregion

        #region WndProc
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_SYSCOMMAND)
            {
                switch ((SystemMenuItem)m.WParam)
                {
                    case SystemMenuItem.About:
                        MessageBox.Show("NCMDumpGUI v1.0.1.1\n����libncmdump����\nʹ��MIT���֤��Դ", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
        }
        #endregion

        // ���������ť�����
        private void browseButton_Click(object sender, EventArgs e)
        {
            if (fileFolderComboBox.SelectedIndex == 0)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "NCM���ܸ���|*.ncm";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filepathTextBox.Text = dialog.FileName;
                }
            }
            else if (fileFolderComboBox.SelectedIndex == 1)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowNewFolderButton = true;
                dialog.RootFolder = Environment.SpecialFolder.ApplicationData;
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filepathTextBox.Text = dialog.SelectedPath;
                }
            }
        }

        // ���ncm�������ļ�
        private bool CheckNCMBinary(string filePath)
        {
            string correctHeader = "CTENFDAM";

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[8];
                    int bytesRead = fileStream.Read(bytes, 0, 8);

                    if (bytesRead == 8)
                    {
                        string header = Encoding.ASCII.GetString(bytes);
                        if (header == correctHeader)
                        {
                            return true;
                        }
                        else
                        {
                            if (fileFolderComboBox.SelectedIndex == 0)
                            {
                                MessageBox.Show("����ncm�ļ�\n�ļ�ͷΪ��" + header, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                toolStripStatusLabel2.Text = "����ncm�ļ���";
                            }
                            return false;
                        }
                    }
                    else
                    {
                        if (fileFolderComboBox.SelectedIndex == 0)
                        {
                            MessageBox.Show("�ļ���С�쳣", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            toolStripStatusLabel2.Text = "�ļ���С�쳣��������ncm�ļ�";
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (fileFolderComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("��������: \n" + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toolStripStatusLabel2.Text = "�����ļ�ʱ��������";
                }
                return false;
            }
        }

        // ���·���Ϸ���
        public static bool IsValidFilePath(string path)
        {
            if (Path.GetInvalidPathChars().Any(c => path.Contains(c)))
            {
                return false;
            }
            try
            {
                string normalizedPath = Path.GetFullPath(path);
                return Path.IsPathRooted(normalizedPath);
            }
            catch
            {
                return false;
            }
        }

        public int ProcessNCMFile(string path)
        {
            NeteaseCrypt neteaseCrypt = new NeteaseCrypt(path);
            int result = neteaseCrypt.Dump();
            if (fixMetaDataCheckBox.Checked)
            {
                neteaseCrypt.FixMetadata();
            }
            neteaseCrypt.Destroy();
            return result;
        }

        // ��ת������ť�����
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("libncmdump.dll"))
            {
                MessageBox.Show("���Ĳ�����\n��ȷ��libncmdump.dll�뱾������ͬһĿ¼", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel2.Text = "���Ĳ����ڣ�����libncmdump.dll";
            }
            else if (filepathTextBox.Text == "")
            {
                MessageBox.Show("�ļ�·��Ϊ�գ�\n���ṩncm�ļ�·��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel2.Text = "���ṩ�ļ�";
            }
            else if (!IsValidFilePath(filepathTextBox.Text))
            {
                MessageBox.Show("�Ƿ��ļ�·��\n�ļ�·���а����Ƿ��ַ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel2.Text = "�Ƿ��ļ�·��";
            }
            else
            {
                filepathTextBox.Enabled = false;
                browseButton.Enabled = false;
                convertButton.Enabled = false;
                fileFolderComboBox.Enabled = false;
                fixMetaDataCheckBox.Enabled = false;
                if (fileFolderComboBox.SelectedIndex == 1)
                {
                    int bypassFiles = 0;
                    int processedFiles = 0;
                    int allProcessedFiles = 0;
                    string directoryPath = filepathTextBox.Text;
                    string fileExtension = ".ncm";
                    string[] files = Directory.GetFiles(directoryPath, "*.*", scanMoreFoldersCheckBox.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Where(file => Path.GetExtension(file).ToLower() == fileExtension.ToLower()).ToArray();

                    toolStripProgressBar1.Maximum = files.Length;
                    foreach (var file in files)
                    {
                        if (CheckNCMBinary(file))
                        {
                            if (ProcessNCMFile(file) != 0)
                            {
                                bypassFiles += 1;
                            }
                            else
                            {
                                processedFiles += 1;
                            }
                        }
                        allProcessedFiles += 1;
                        Debug.WriteLine(allProcessedFiles.ToString());
                        toolStripProgressBar1.Value = allProcessedFiles;
                        toolStripStatusLabel2.Text = "�Ѵ���" + allProcessedFiles.ToString();
                    }
                    toolStripStatusLabel2.Text = "�ɹ���" + processedFiles.ToString() + "��ʧ�ܣ�" + bypassFiles.ToString();
                }
                else if (fileFolderComboBox.SelectedIndex == 0)
                {
                    toolStripProgressBar1.Maximum = 1;
                    if (!filepathTextBox.Text.EndsWith(".ncm"))
                    {
                        MessageBox.Show("���ƺ�������ncm�ļ���\n���ṩncm�ļ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        toolStripStatusLabel2.Text = "���ṩ��ȷ��ncm�ļ�";
                    }
                    else if (CheckNCMBinary(filepathTextBox.Text))
                    {
                        int result = ProcessNCMFile(filepathTextBox.Text);
                        toolStripProgressBar1.Value += 1;
                        if (result != 0)
                        {
                            toolStripStatusLabel2.Text = "�������󣬷���ֵΪ��" + result.ToString();
                        }
                        else
                        {
                            toolStripStatusLabel2.Text = "ת����ɣ��ļ���ncm����ͬ��Ŀ¼��";
                            toolStripProgressBar1.Value += 1;
                        }
                    }
                }
                filepathTextBox.Enabled = true;
                browseButton.Enabled = true;
                convertButton.Enabled = true;
                fileFolderComboBox.Enabled = true;
                fixMetaDataCheckBox.Enabled = true;
                toolStripProgressBar1.Value = 0;
            }
        }

        // ���ڼ����¼�
        public void WndMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertButton.PerformClick();
            }
        }

        // �ļ�����
        private void WndMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void WndMain_DragDrop(object sender, DragEventArgs e)
        {
            filepathTextBox.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("ע�⣡\n��Ӧ��ֻ����ѧϰ��;����ֹ������ҵ��Υ����;��\n��������NCM�ļ��ṩƽ̨�ķ���������ʹ�ñ�Ӧ�ã�\n���߶���ҵ��Υ��ʹ�ñ������ɵ��κκ�����е��κ����Σ�", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fileFolderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filepathTextBox.Text = "";
            if (fileFolderComboBox.SelectedIndex == 1)
            {
                scanMoreFoldersCheckBox.Visible = true;
            }
            else
            {
                scanMoreFoldersCheckBox.Visible = false;
            }
        }
    }
}
