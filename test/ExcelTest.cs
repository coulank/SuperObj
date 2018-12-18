using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sl = SuperLib;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace test
{
    class ExcelTest
    {
        public static void test()
        {
            LibFlr();
        }
        static void LibFlr()
        {
            using (sl.FileSelect fl = new sl.FileSelect())
            {
                if (fl.show(sl.FileSelect.ExcelStr))
                {
                    using (sl.ExcelObj x = new sl.ExcelObj())
                    {
                        x.xlApp.Visible = true;
                        Workbook xlBook;
                        foreach (string item in fl.items)
                        {
                            try
                            {
                                xlBook = x.xlApp.Workbooks.Open(item);
                            }
                            catch { continue; }
                            MessageBox.Show(item);
                            xlBook.Close();
                        }
                    }
                }
            }
        }
        static void DoFolder()
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
        }
        static void DoFiler()
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Multiselect = true;
            a.Filter = "Text files(*.txt) | *.txt | All files(*.*) | *.*";
            a.ShowDialog();
        }
        static void DoExcel()
        {
            using (sl.ExcelObj s = new sl.ExcelObj())
            {
            }
        }
    }
}