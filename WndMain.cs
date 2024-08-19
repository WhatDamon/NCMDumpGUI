using System;
using System.Windows.Forms;

namespace NCMDumpGUI
{
    public partial class WndMain : Form
    {
        public WndMain()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "NCM���ܸ���|*.ncm";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filepathTextBox.Text = dialog.FileName;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (filepathTextBox.Text == "")
            {
                MessageBox.Show("�ļ�·��Ϊ�գ�\n���ṩncm�ļ�·��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!filepathTextBox.Text.EndsWith(".ncm"))
            {
                MessageBox.Show("���ƺ�������ncm�ļ���\n���ṩncm�ļ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!File.Exists("libncmdump.dll"))
            {
                MessageBox.Show("���Ĳ�����\n��ȷ��libncmdump.dll�뱾������ͬһĿ¼", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                filepathTextBox.Enabled = false;
                browseButton.Enabled = false;
                convertButton.Enabled = false;
                NeteaseCrypt neteaseCrypt = new NeteaseCrypt(filepathTextBox.Text);
                int result = neteaseCrypt.Dump();
                if (fixMetaDataCheckBox.Checked)
                {
                    neteaseCrypt.FixMetadata();
                }
                neteaseCrypt.Destroy();
                if (result != 0) {
                    toolStripStatusLabel2.Text = "�������󣬴�����룺" + result.ToString();
                }
                else
                {
                    toolStripStatusLabel2.Text = "ת����ɣ��ļ���ncm����ͬ��Ŀ¼��";
                }
                filepathTextBox.Enabled = true;
                browseButton.Enabled = true;
                convertButton.Enabled = true;
            }
        }

        public void WndMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertButton.PerformClick();
            }
        }
    }
}
