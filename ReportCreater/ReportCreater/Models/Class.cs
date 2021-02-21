using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreater.Models
{
    class Class
    {
        public string name;
        public string content;
        public Class(FileInfo file)
        {
            name = file.Name;
            using(var i = file.OpenText())
                content = i.ReadToEnd();
        }
    }
}
