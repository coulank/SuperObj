using System;
// SuperlDspが中心となって動作するオブジェクトになります

namespace SuperLib
{
    abstract public class SuperIDsp : IDisposable
    {
        private bool disposed = false;
        ~SuperIDsp() { Dispose(); }
        public void Dispose()
        {
            if (!disposed)
            {
                Terminate();
                GC.Collect();
                disposed = true;
            }
        }
        abstract protected void Terminate();
        protected void ReleaseCom(params object[] args)
        {
            foreach (object item in args)
            {
                try { System.Runtime.InteropServices.Marshal.ReleaseComObject(item); } catch { }
            }
        }
    }
}
