using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace empty_folder_deleter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelectOutFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
            folderBrowserDialog.Description = "Please select an target folder for the Extracted Files";
            DialogResult res = folderBrowserDialog.ShowDialog();

            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                Program.OutputFolderPath = folderBrowserDialog.SelectedPath;
                tbTargetFolder.Text = Program.OutputFolderPath;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {

            Invoke(new Action(Program.RunClean));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            Invoke(new Action(Program.RunClear));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            Invoke(new Action(Program.RunPrint));
        }        
        private void btnStop_Click(object sender, EventArgs e)
        {

            Invoke(new Action(Program.InvokeStop));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbTargetFolder_TextChanged(object sender, EventArgs e)
        {
            Program.OutputFolderPath = tbTargetFolder.Text;
            //var newPath = "path change to:" + tbTargetFolder.Text + "\r\n";
            //this.tbConsole.Text += newPath;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
