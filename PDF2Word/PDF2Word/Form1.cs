using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF2Word
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF files | *.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    txtInput.Text = filePath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            string folderPath = folder.SelectedPath;
            txtOutpath.Text = folderPath;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            string filePDF = txtInput.Text;
            string folder = txtOutpath.Text;
            string wordFileName = folder + "AppConverted_TO_WORDFILE.docx";
            f.OpenPdf(filePDF);
            if (f.PageCount > 0)
            {
                f.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx;
                f.ToWord(wordFileName);
            }
            MessageBox.Show("Thành công","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
