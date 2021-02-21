using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreater.Models
{
    class Report
    {
        public string title;
        public string author;
        public List<Package> Packages = new List<Package>();
        public Report(DirectoryInfo dir, string title, string author)
        {
            this.author = author;
            this.title = title;
            foreach(var i in dir.GetDirectories())
                Packages.Add(new Package(i));
        }
    }
}
