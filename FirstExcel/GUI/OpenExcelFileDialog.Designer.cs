namespace FirstExcel.GUI
{
    partial class OpenExcelFileDialog
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
            this.Open1CFile = new System.Windows.Forms.Button();
            this.OpenPlatformFile = new System.Windows.Forms.Button();
            this.textBoxName1C = new System.Windows.Forms.TextBox();
            this.textBoxNamePlatform = new System.Windows.Forms.TextBox();
            this.SetFilesName = new System.Windows.Forms.Button();
            this.openFileXLSX = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Open1CFile
            // 
            this.Open1CFile.Location = new System.Drawing.Point(12, 12);
            this.Open1CFile.Name = "Open1CFile";
            this.Open1CFile.Size = new System.Drawing.Size(140, 40);
            this.Open1CFile.TabIndex = 0;
            this.Open1CFile.Text = "1C File";
            this.Open1CFile.UseVisualStyleBackColor = true;
            this.Open1CFile.Click += new System.EventHandler(this.Open1CFile_Click);
            // 
            // OpenPlatformFile
            // 
            this.OpenPlatformFile.Location = new System.Drawing.Point(12, 58);
            this.OpenPlatformFile.Name = "OpenPlatformFile";
            this.OpenPlatformFile.Size = new System.Drawing.Size(140, 40);
            this.OpenPlatformFile.TabIndex = 1;
            this.OpenPlatformFile.Text = "Platform File";
            this.OpenPlatformFile.UseVisualStyleBackColor = true;
            this.OpenPlatformFile.Click += new System.EventHandler(this.OpenPlatformFile_Click);
            // 
            // textBoxName1C
            // 
            this.textBoxName1C.Location = new System.Drawing.Point(158, 17);
            this.textBoxName1C.Name = "textBoxName1C";
            this.textBoxName1C.Size = new System.Drawing.Size(309, 30);
            this.textBoxName1C.TabIndex = 2;
            // 
            // textBoxNamePlatform
            // 
            this.textBoxNamePlatform.Location = new System.Drawing.Point(158, 63);
            this.textBoxNamePlatform.Name = "textBoxNamePlatform";
            this.textBoxNamePlatform.Size = new System.Drawing.Size(309, 30);
            this.textBoxNamePlatform.TabIndex = 3;
            // 
            // SetFilesName
            // 
            this.SetFilesName.Location = new System.Drawing.Point(348, 112);
            this.SetFilesName.Name = "SetFilesName";
            this.SetFilesName.Size = new System.Drawing.Size(119, 40);
            this.SetFilesName.TabIndex = 4;
            this.SetFilesName.Text = "OK";
            this.SetFilesName.UseVisualStyleBackColor = true;
            this.SetFilesName.Click += new System.EventHandler(this.SetFilesName_Click);
            // 
            // openFileXLSX
            // 
            this.openFileXLSX.FileName = "openFileDialog1";
            // 
            // OpenExcelFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 164);
            this.Controls.Add(this.SetFilesName);
            this.Controls.Add(this.textBoxNamePlatform);
            this.Controls.Add(this.textBoxName1C);
            this.Controls.Add(this.OpenPlatformFile);
            this.Controls.Add(this.Open1CFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpenExcelFileDialog";
            this.Text = "OpenExcelFileDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open1CFile;
        private System.Windows.Forms.Button OpenPlatformFile;
        private System.Windows.Forms.TextBox textBoxName1C;
        private System.Windows.Forms.TextBox textBoxNamePlatform;
        private System.Windows.Forms.Button SetFilesName;
        private System.Windows.Forms.OpenFileDialog openFileXLSX;
    }
}