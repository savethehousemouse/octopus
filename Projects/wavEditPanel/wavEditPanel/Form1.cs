using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wavEditPanel
{
    public partial class Form1 : Form
    {
        Random r = null;
        public Form1()
        {
            r = new Random();
            InitializeComponent();
            ProgramLocationField.Text=@"C:\Users\Günti\Documents\Visual Studio 2013\Projects\wavEdit\Debug\wavEdit.exe";
        }

        private void codeFile_Click(object sender, EventArgs e)
        {   // code file
            getFile.Filter = "All | *.*";
            if (getFile.ShowDialog() == DialogResult.OK)
            {
                codeFileField.Text = getFile.FileName;
            }
            checkInput();
        }

        private void fileInSelect_Click(object sender, EventArgs e)
        {
            if (getFile.ShowDialog() == DialogResult.OK)
            {
                fileInField.Text = getFile.FileName;
            }
            checkInput();
        }

        private void FileOutSelect_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.OverwritePrompt = true;
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileOutField.Text = saveFileDialog1.FileName;
            }
            checkInput();
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            String cmdArg= (@"mode="+encodeBtn.Text+
                            ",codeFile="+codeFileField.Text+
                            ",srcFilein="+fileInField.Text+
                            ",srcfileOut="+fileOutField.Text+
                            ",seed="+seedField.Text+
                            ",residualPerc="+residualField.Text+
                            ",BlockLen="+BlocklengthField.Text+
                            ",displacement="+DisplacementField.Text
                            ).ToLower();
            cmdLineField.Text = '"'+ProgramLocationField.Text+'"'+" "+cmdArg;
            System.Diagnostics.Process.Start('"'+ProgramLocationField.Text+'"', cmdArg);
        }

        private void encodeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (encodeBtn.Checked)
            {
                encodeBtn.Text = "Decode";
                if ((fileInField.Text.Length > 0) && (fileOutField.Text.Length == 0))
                {
                    fileOutField.Text = fileInField.Text;
                    fileInField.Text = "N/A";
                }
                fileInField.Enabled = false;
                automaticBtn.Visible = false;
                checkInput();
                return;
            }
            else
            {
                    encodeBtn.Text = "Encode";
                    fileInField.Enabled = true;
                    automaticBtn.Visible = true;
                    checkInput();
                    return;
            }
        }

        private void automaticBtn_Click(object sender, EventArgs e)
        {
            int x = r.Next();
            seedField.Text = x.ToString();
            residualField.Text = r.Next(50).ToString();
            BlocklengthField.Text = (x = (2000 + r.Next(4000))).ToString();
            DisplacementField.Text = r.Next(((x * 100) / 6) / 100).ToString();
            checkInput();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = r.Next();
            seedField.Text = x.ToString();
            checkInput();
        }

        private bool checkInput()
        {
            int x;
            if ((int.TryParse(seedField.Text, out x) == true)
                & (int.TryParse(residualField.Text, out x) == true)
                & (int.TryParse(BlocklengthField.Text, out x) == true)
                & (int.TryParse(DisplacementField.Text, out x) == true)
                & (codeFileField.Text.Length > 0)
                & (fileInField.Text.Length>0)
                )
            {
                if(
                    ((encodeBtn.Checked) & (fileOutField.Text.Length>0))
                    || (!encodeBtn.Checked)
                   )
                {
                    ProcessBtn.Enabled = true;
                    return (true);
                }
            }
            ProcessBtn.Enabled = false;
            return (false);
        }

        private void codeFileField_Leave(object sender, EventArgs e)
        {
            checkInput();
        }

        private void ProgramLocationBtn_Click(object sender, EventArgs e)
        {
            getFile.Filter = "Program Location | wavEdit.exe";
            if (getFile.ShowDialog() == DialogResult.OK)
            {
                ProgramLocationField.Text = getFile.FileName;
            }
            checkInput();
        }

        private void codeFileField_DoubleClick(object sender, EventArgs e)
        {
            codeFile_Click(sender, e);

        }

        private void fileInField_DoubleClick(object sender, EventArgs e)
        {
            fileInSelect_Click(sender, e);
        }

        private void fileOutField_DoubleClick(object sender, EventArgs e)
        {
            FileOutSelect_Click(sender, e);
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
