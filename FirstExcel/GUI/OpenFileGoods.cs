using FirstExcel.Platforms.Goods.Products;
using System;
using System.Windows.Forms;

namespace FirstExcel.GUI
{
    public partial class OpenFileGoods : Form
    {
        public OpenFileGoods()
        {
            InitializeComponent();
        }

        private void btnOpenFileGoods_Click(object sender, EventArgs e)
        {
            if (openFileDialogGoods.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialogGoods.FileName;
            textBoxNameGoods.Text = filename;
        }

        private void FillInFileGoods_Click(object sender, EventArgs e)
        {
            string selectedGoodsFile = textBoxNameGoods.Text;
            Product product = new Product(ProductCategory.Text);
            product.FillDataInGoodsFile(textBoxNameGoods.Text);
        }
    }
}
