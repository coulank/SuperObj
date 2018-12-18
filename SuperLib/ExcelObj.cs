using Excel = Microsoft.Office.Interop.Excel;
using sp = SuperLib.SuperIDsp;

namespace SuperLib
{
    public class ExcelObj : sp
    {
        public Excel.Application xlApp;
        public Obj obj;
        public class Obj
        {
            public Excel.Application App;
            public Obj() { App = new Excel.Application(); }
        }
        public ExcelObj()
        {
            obj = new Obj(); xlApp = obj.App;
        }
        protected override void Terminate()
        {
            try { if (!xlApp.Visible || xlApp.Workbooks.Count == 0) xlApp.Quit(); } catch { }
            ReleaseCom(xlApp);
        }
    }
}
