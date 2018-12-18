using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sp = SuperLib.SuperIDsp;

namespace SuperLib
{
    public class FileSelect : sp
    {
        public const string FileAllStr = "すべてのファイル | *.*";
        public const string ExcelStr = "Excel|*.xls*";

        public string FileStr;
        public string[] items;
        OpenFileDialog Fl;
        FolderBrowserDialog Fd;
        public bool show(string FilterStr = FileAllStr, bool MultSelect = true, bool FolderFlag = false)
        {
            bool Filer = !FolderFlag;
            DialogResult dr;
            if (Filer)
            {
                Fl = new OpenFileDialog();
                Fl.Multiselect = MultSelect;
                Fl.Filter = FilterStr;
                dr = Fl.ShowDialog();
                items = Fl.FileNames;
                FileStr = Fl.FileName;
                Fl = null;
            }
            else
            {
                Fd = new FolderBrowserDialog();
                dr = Fl.ShowDialog();
                FileStr = Fd.SelectedPath;
                items = new string[0];
                items[0] = FileStr;
                Fd = null;
            }
            return (int)dr == 1;
        }
        protected override void Terminate() { }
    }
}
