using FirstExcel.Functional;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FirstExcel.GUI
{
    public partial class OpenExcelFileDialog : Form
    {
        public OpenExcelFileDialog()
        {
            InitializeComponent();
        }

        private void Open1CFile_Click(object sender, EventArgs e)
        {
            if (openFileXLSX.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileXLSX.FileName;
            textBoxName1C.Text = fileName;
        }

        private void OpenPlatformFile_Click(object sender, EventArgs e)
        {
            if (openFileXLSX.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileXLSX.FileName;
            textBoxNamePlatform.Text = fileName;
        }

        private void SetFilesName_Click(object sender, EventArgs e)
        {
            List<int> list = WorkWithXSLX.FindDivideInFiles(textBoxName1C.Text, textBoxNamePlatform.Text);
            string[,] data = WorkWithXSLX.FindLinesInTableById(list);
            WorkWithXSLX.WriteInNewWorkbook(data);
        }

    }
}
