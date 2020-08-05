namespace FirstExcel
{
    partial class GOODS : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public GOODS()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.ChoosePlatform = this.Factory.CreateRibbonComboBox();
            this.ShowGoodsDialog = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.FindDivide = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.button4 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "Конвертирование";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.ChoosePlatform);
            this.group1.Items.Add(this.ShowGoodsDialog);
            this.group1.Label = "Заполнение таблиц";
            this.group1.Name = "group1";
            // 
            // ChoosePlatform
            // 
            ribbonDropDownItemImpl1.Label = "Goods";
            this.ChoosePlatform.Items.Add(ribbonDropDownItemImpl1);
            this.ChoosePlatform.Label = "Выбрать платформу";
            this.ChoosePlatform.Name = "ChoosePlatform";
            this.ChoosePlatform.Text = null;
            // 
            // ShowGoodsDialog
            // 
            this.ShowGoodsDialog.Label = "Заполнить файл";
            this.ShowGoodsDialog.Name = "ShowGoodsDialog";
            this.ShowGoodsDialog.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnFillInFileGOODS_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.FindDivide);
            this.group2.Label = "Поиск расхождений";
            this.group2.Name = "group2";
            // 
            // FindDivide
            // 
            this.FindDivide.Label = "Найти расхождения";
            this.FindDivide.Name = "FindDivide";
            this.FindDivide.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FindDivide_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.button4);
            this.group3.Label = "Опции";
            this.group3.Name = "group3";
            // 
            // button4
            // 
            this.button4.Label = "Найти строки с недостающей информацией";
            this.button4.Name = "button4";
            // 
            // GOODS
            // 
            this.Name = "GOODS";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ShowGoodsDialog;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FindDivide;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox ChoosePlatform;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
    }

    partial class ThisRibbonCollection
    {
        internal GOODS Ribbon1
        {
            get { return this.GetRibbon<GOODS>(); }
        }
    }
}
