using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ReportCreater.Models;
using ReportCreater.Converters;

namespace ReportCreater
{
    public partial class MainForm : Form
    {
        Report report;
        public MainForm()
        {
            InitializeComponent();
            pictureBox.Image = Properties.Resources.Vlad; // картиночка
        }

        private void BuildReport_Click(object sender, EventArgs e)
        {
            try 
            {
                ToWord.Convert(report); // создаём word
                label.ForeColor = Color.Green;
                label.Text = "Успешно создано и помещено в Документы :)";
            }
            catch 
            {
                label.ForeColor = Color.Red;
                label.Text = "Произошла ошибка. Возможные прчиины:\n-Не найден файл template.docx\n-Нужно разрешить редактирвоанеи в файле template.docx";
            }
        }

        private void ProjectPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    report = new Report(FindSrc(fbd.SelectedPath), TextBoxTitle.Text, TextBoxAuthor.Text);
                    label.ForeColor = Color.Green;
                    label.Text = "Проект найден :)";
                }
                catch (Exception)
                {
                    label.ForeColor = Color.Red;
                    label.Text = "В этой папке нет проекта :(";
                }
            }
        }

        private DirectoryInfo FindSrc(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var i in dir.GetDirectories())
                if (i.Name == "src")
                    return i;
            throw new Exception();
        }
    }
}
