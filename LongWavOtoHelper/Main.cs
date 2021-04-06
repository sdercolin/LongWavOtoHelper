using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LongWavOtoHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string wavDirectoryPath = string.Empty;
        string divisionInputOtoFilePath = string.Empty;
        string joiningInputOtoFilePath = string.Empty;

        private void UpdateViews()
        {
            textBoxWavDirectoryPath.Text = wavDirectoryPath;
            textBoxDivisionInputOtoFilePath.Text = divisionInputOtoFilePath;
            textBoxJoiningInputOtoFilePath.Text = joiningInputOtoFilePath;
        }

        private void buttonLoadResultFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    wavDirectoryPath = dialog.SelectedPath;
                    UpdateViews();
                }
            }
        }

        private void buttonLoadInputOtoFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.RestoreDirectory = true;
                dialog.Filter = "oto files (*.ini)|*.ini";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    divisionInputOtoFilePath = dialog.FileName;
                    UpdateViews();
                }
            }
        }

        private void buttonSelectJoiningInputOtoFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.RestoreDirectory = true;
                dialog.Filter = "oto files (*.ini)|*.ini";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    joiningInputOtoFilePath = dialog.FileName;
                    UpdateViews();
                }
            }
        }

        private void textBoxResultFilePath_TextChanged(object sender, EventArgs e)
        {
            wavDirectoryPath = textBoxWavDirectoryPath.Text;
        }

        private void textBoxInputOtoFilePath_TextChanged(object sender, EventArgs e)
        {
            divisionInputOtoFilePath = textBoxDivisionInputOtoFilePath.Text;
        }

        private void textBoxJoiningInputOtoFilePath_TextChanged(object sender, EventArgs e)
        {
            joiningInputOtoFilePath = textBoxJoiningInputOtoFilePath.Text;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

            string[] wavFilePaths;
            try
            {
                wavFilePaths = new DirectoryInfo(wavDirectoryPath).GetFiles("*.wav").Select(x => x.FullName).ToArray();
                if (wavFilePaths.Count() < 2)
                {
                    ShowErrorDialog(string.Format("Could not find multiple wav files under directory \"{0}\"", wavDirectoryPath));
                    return;
                }
            }
            catch
            {
                ShowErrorDialog(string.Format("Could not find directory \"{0}\"", wavDirectoryPath));
                return;
            }

            string[] otoLines;
            try
            {
                otoLines = File.ReadAllLines(divisionInputOtoFilePath);
            }
            catch
            {
                ShowErrorDialog(string.Format("Could not read input oto file fom path \"{0}\"", divisionInputOtoFilePath));
                return;
            }

            var outputOtoContent = Model.GetOtoWithDividedWav(otoLines, wavFilePaths);
            var savedFilePath = SaveOtoFile(outputOtoContent);
            if (savedFilePath != null)
            {
                joiningInputOtoFilePath = savedFilePath;
                UpdateViews();
            }
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            if (textBoxLongWavName.Text == "")
            {

                ShowErrorDialog("Please enter file name of the original wav file.");
            }
            var longWavName = textBoxLongWavName.Text;
            if (!longWavName.EndsWith(".wav"))
            {
                longWavName += ".wav";
            }

            string[] wavFilePaths;
            try
            {
                wavFilePaths = new DirectoryInfo(wavDirectoryPath).GetFiles("*.wav").Select(x => x.FullName).ToArray();
                if (wavFilePaths.Count() < 2)
                {
                    ShowErrorDialog(string.Format("Could not find multiple wav files under directory \"{0}\"", wavDirectoryPath));
                    return;
                }
            }
            catch
            {
                ShowErrorDialog(string.Format("Could not find directory \"{0}\"", wavDirectoryPath));
                return;
            }

            string[] otoLines;
            try
            {
                otoLines = File.ReadAllLines(joiningInputOtoFilePath);
            }
            catch
            {
                ShowErrorDialog(string.Format("Could not read input oto file fom path \"{0}\"", joiningInputOtoFilePath));
                return;
            }

            var outputOtoContent = Model.GetOtoWithJoinedWav(otoLines, longWavName, wavFilePaths);
            SaveOtoFile(outputOtoContent);
        }

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message);
        }

        private string SaveOtoFile(string content)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "oto files (*.ini)|*.ini";
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, content);
                    return dialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
