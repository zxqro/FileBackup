using System;
using System.Data;
using System.Windows.Forms;
using WinSCP;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;



namespace Liller_Backup_Tool_v0._1
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void butBackup_Click(object sender, EventArgs e)
        {
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Ftp,
                HostName = "FTP.HOST.COM",
                UserName = "FTP_USERNAME",
                Password = "FTP_PASSWORD",


            };

            using (Session session = new Session())
            {

                // Connect
                session.Open(sessionOptions);
                session.FileTransferred += FileTransferred;
                // Synchronize files
                SynchronizationResult synchronizationResult;
                synchronizationResult =
                    session.SynchronizeDirectories(
                        SynchronizationMode.Remote, @buPath.Text, "/backup", false);

            }
        }
            private void FileTransferred(object sender, TransferEventArgs e)
            {

            table.Rows.Add(e.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Files Uploaded", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Files Uploaded"].Width = 300;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butDelete_Click(object sender, EventArgs e)
        {

            string path = @buPath.Text;

            DirectoryInfo directory = new DirectoryInfo(path);

            foreach (FileInfo file in directory.EnumerateFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in directory.EnumerateDirectories())
            {
                dir.Delete(true);
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                buPath.Text = dialog.FileName;
            }
        }
    }
}
