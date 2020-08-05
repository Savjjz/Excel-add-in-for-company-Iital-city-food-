namespace FirstExcel.GUI
{
    partial class OpenFileGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFileGoods = new System.Windows.Forms.Button();
            this.textBoxNameGoods = new System.Windows.Forms.TextBox();
            this.FillInFileGoods = new System.Windows.Forms.Button();
            this.openFileDialogGoods = new System.Windows.Forms.OpenFileDialog();
            this.ProductCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOpenFileGoods
            // 
            this.btnOpenFileGoods.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFileGoods.Name = "btnOpenFileGoods";
            this.btnOpenFileGoods.Size = new System.Drawing.Size(116, 36);
            this.btnOpenFileGoods.TabIndex = 0;
            this.btnOpenFileGoods.Text = "Goods file";
            this.btnOpenFileGoods.UseVisualStyleBackColor = true;
            this.btnOpenFileGoods.Click += new System.EventHandler(this.btnOpenFileGoods_Click);
            // 
            // textBoxNameGoods
            // 
            this.textBoxNameGoods.Location = new System.Drawing.Point(134, 15);
            this.textBoxNameGoods.MaximumSize = new System.Drawing.Size(309, 30);
            this.textBoxNameGoods.MinimumSize = new System.Drawing.Size(309, 30);
            this.textBoxNameGoods.Name = "textBoxNameGoods";
            this.textBoxNameGoods.Size = new System.Drawing.Size(309, 30);
            this.textBoxNameGoods.TabIndex = 3;
            // 
            // FillInFileGoods
            // 
            this.FillInFileGoods.Location = new System.Drawing.Point(322, 90);
            this.FillInFileGoods.Name = "FillInFileGoods";
            this.FillInFileGoods.Size = new System.Drawing.Size(116, 36);
            this.FillInFileGoods.TabIndex = 4;
            this.FillInFileGoods.Text = "OK";
            this.FillInFileGoods.UseVisualStyleBackColor = true;
            this.FillInFileGoods.Click += new System.EventHandler(this.FillInFileGoods_Click);
            // 
            // openFileDialogGoods
            // 
            this.openFileDialogGoods.FileName = "openFileDialog1";
            // 
            // ProductCategory
            // 
            this.ProductCategory.FormattingEnabled = true;
            this.ProductCategory.Items.AddRange(new object[] {
            "Консервированные супы",
            "Консервы грибные",
            "Консервы овощные",
            "Консервы фруктовые",
            "Оливки, маслины",
            "Паштет",
            "Урбеч, хумус, тапенад, диетическая ореховая паста",
            "Бобовые",
            "Крупа",
            "Лапша",
            "Макаронные изделия",
            "Мука",
            "Масло растительное",
            "Варенье, ягоды с сахаром, пюре, десерты",
            "Джем, конфитюр, повидло",
            "Мед",
            "Ореховая паста",
            "Шоколадно-ореховая паста",
            "Орехи",
            "Семечки",
            "Сухофрукты, ягоды, цукаты",
            "Сушеные, вяленые овощи и грибы",
            "Десертный соус",
            "Сироп, пекмез",
            "Сахар",
            "Соль",
            "Специи и приправы",
            "Горчица, хрен",
            "Заправка для салата",
            "Кетчуп",
            "Маринад",
            "Соусы",
            "Томатная паста",
            "Уксус",
            "Кофе зерновой и молотый",
            "Кофе растворимый",
            "Цикорий и злаковые напитки",
            "Чай",
            "Диетическая крупа, макароны, бобовые, клетчатка, отруби",
            "Диетические напитки",
            "Диетические снеки",
            "Злаковые батончики, фруктово-ореховые батончики, мюсли",
            "Листья нори, сушеная морская капуста",
            "Мюсли, гранола",
            "Овощные и фруктовые чипсы",
            "Печенье",
            "Нуга, щербет, халва",
            "Конфеты шоколадные, наборы, драже",
            "Шоколад и шоколадные изделия, фигурки, батончики",
            "Мармелад",
            "Пастила"});
            this.ProductCategory.Location = new System.Drawing.Point(134, 51);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Size = new System.Drawing.Size(309, 33);
            this.ProductCategory.TabIndex = 5;
            // 
            // OpenFileGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 132);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.FillInFileGoods);
            this.Controls.Add(this.textBoxNameGoods);
            this.Controls.Add(this.btnOpenFileGoods);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpenFileGoods";
            this.Text = "OpenFileGoods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFileGoods;
        private System.Windows.Forms.TextBox textBoxNameGoods;
        private System.Windows.Forms.Button FillInFileGoods;
        private System.Windows.Forms.OpenFileDialog openFileDialogGoods;
        private System.Windows.Forms.ComboBox ProductCategory;
    }
}