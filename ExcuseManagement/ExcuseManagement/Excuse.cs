using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExcuseManagement
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set;}

        public Excuse()
        {
            Description = "";
            Results = "";
            ExcusePath = "";
        }
        public Excuse(string path)
        {
            OpenFile(path);
        }
        

        public void OpenFile(string path) {
            StreamReader stream = new StreamReader(path);
            Description = stream.ReadLine();
            Results = stream.ReadLine();
            LastUsed = File.GetLastWriteTime(path);
            ExcusePath = path;
        }
        public void Save(string path) {
            File.WriteAllText(path, Description + Environment.NewLine + Results + Environment.NewLine + LastUsed.ToString());
        }
    }
}
