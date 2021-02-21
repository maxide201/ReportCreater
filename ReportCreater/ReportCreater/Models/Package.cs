using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreater.Models
{
    class Package
    {
        public string name;
        public List<Class> Classes = new List<Class>();
        public Package(DirectoryInfo dir)
        {
            name = dir.Name;
            foreach (var i in dir.GetFiles())
                Classes.Add(new Class(i));
        }
    }
}
