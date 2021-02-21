using System;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace ReportCreater.Converters
{
    class ToWord
    {
        public static bool Convert(Models.Report report)
        {
            Application app = new Application();
            Document doc;
            try
            {
                doc = app.Documents.Add(Path.Combine(Environment.CurrentDirectory, "template.docx"));
            }
            catch(Exception e)
            {
                app.Quit();
                throw new Exception();
            }
            
            doc.SaveAs2(report.title);

            
            string FindText = "{name}";
            string ReplaceText = report.author;
            doc.Content.Find.Execute(FindText: FindText, ReplaceWith: ReplaceText); // Замена {name} на Фамилия И.О.


            Paragraph p; // текст
            Table t; // таблица
            foreach (var pckg in report.Packages)
            {
                p = doc.Content.Paragraphs.Add();
                p.Range.Text = "\nПакет "+pckg.name + ":";
                p.Range.Font.Bold = 20;
                p.Range.InsertParagraphAfter(); // название пакета
                
                foreach (var cls in pckg.Classes)
                {
                    p = doc.Content.Paragraphs.Add();
                    p.Range.Text = "\n - " + cls.name + ":";
                    p.Range.Font.Bold = 0;
                    p.Range.InsertParagraphAfter(); // название класса

                    t = doc.Tables.Add(p.Range, 1, 1);
                    t.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                    t.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                    t.Cell(1, 1).Range.Text = cls.content; // текст класса
                }
            }

            doc.Close();
            app.Quit();
            return false;
        }
    }
}
