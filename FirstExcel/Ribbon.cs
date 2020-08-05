using FirstExcel.GUI;
using Microsoft.Office.Tools.Ribbon;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace FirstExcel
{
    public partial class GOODS
    {
        public event System.Action ClickedbtnFillInFileGOODS;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnFillInFileGOODS_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileGoods openFileGoods = new OpenFileGoods();
            openFileGoods.Show();
        }

        private void chooseCategory_TextChanged(object sender, RibbonControlEventArgs e)
        {
            
        }

        private void FindDivide_Click(object sender, RibbonControlEventArgs e)
        {
            OpenExcelFileDialog openExcelFileDialog = new OpenExcelFileDialog();
            openExcelFileDialog.Show();
        }
    }
}
