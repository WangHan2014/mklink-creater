using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace mklink创建硬链接 {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //不检测跨线程
        }

        private void source_address_serach_Click(object sender, EventArgs e) {
            FolderBrowserDialog s = filepath_selector;
            s.Description = "选择你要链接的源地址：";
            s.ShowDialog();
            source_address_preview.Text = s.SelectedPath;
        }

        private void destination_address_search_Click(object sender, EventArgs e) {
            FolderBrowserDialog s = filepath_selector;
            s.Description = "选择你要链接的目标地址：";
            s.ShowDialog();
            destination_address_preview.Text = s.SelectedPath;
        }

        private void source_address_preview_TextChanged(object sender, EventArgs e) {
            updateCommandPreview(source_address_preview.Text, destination_address_preview.Text);
        }

        private void destination_address_preview_TextChanged(object sender, EventArgs e) {
            updateCommandPreview(source_address_preview.Text, destination_address_preview.Text);
        }

        public void updateCommandPreview(String source, String destination) {
            command_preview.Text = "mklink /d " + destination + destination_address_folder.Text + " " + source;
        }

        private void toMklink_Click(object sender, EventArgs e) {
            new Mklinker(command_preview.Text);
            if (MessageBox.Show("点击确定跳转到目的地目录", "命令执行完成", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                //跳转到目录
                Process.Start("explorer.exe", destination_address_preview.Text);
            }
        }

        private void destination_address_folder_TextChanged(object sender, EventArgs e) {
            updateCommandPreview(source_address_preview.Text, destination_address_preview.Text);
        }
    }
}