namespace ReportCreater
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildReport = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.ProjectPathButton = new System.Windows.Forms.Button();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildReport
            // 
            this.BuildReport.Location = new System.Drawing.Point(12, 192);
            this.BuildReport.Name = "BuildReport";
            this.BuildReport.Size = new System.Drawing.Size(380, 43);
            this.BuildReport.TabIndex = 0;
            this.BuildReport.Text = "Построить отчёт";
            this.BuildReport.UseVisualStyleBackColor = true;
            this.BuildReport.Click += new System.EventHandler(this.BuildReport_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(12, 144);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 1;
            // 
            // ProjectPathButton
            // 
            this.ProjectPathButton.Location = new System.Drawing.Point(15, 58);
            this.ProjectPathButton.Name = "ProjectPathButton";
            this.ProjectPathButton.Size = new System.Drawing.Size(195, 23);
            this.ProjectPathButton.TabIndex = 2;
            this.ProjectPathButton.Text = "Выбрать папку с проектом";
            this.ProjectPathButton.UseVisualStyleBackColor = true;
            this.ProjectPathButton.Click += new System.EventHandler(this.ProjectPathButton_Click);
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(15, 113);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(195, 20);
            this.TextBoxTitle.TabIndex = 4;
            this.TextBoxTitle.Text = "Название отчета";
            this.TextBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.Location = new System.Drawing.Point(15, 87);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(195, 20);
            this.TextBoxAuthor.TabIndex = 6;
            this.TextBoxAuthor.Text = "Фамилия И.О.";
            this.TextBoxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(216, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(185, 121);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 247);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.TextBoxAuthor);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.ProjectPathButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.BuildReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Создатель отчетов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuildReport;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ProjectPathButton;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

