using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sl = SuperLib.SuperIDsp;
using ADODB;

namespace SuperLib
{
    class UseDB : sl
    {
        enum eSQL
        {
            a_Access = 32,      // Access：ServerName = 場所, Password = パスワード
            b_SQLServer = 64,   // SQLServer：サーバー名, DB名, ユーザー名, パスワードの順
            c_ODBC = 256,
            d_MySQL = 2048,
            d_SQLServer = 4096,
            d_SQLite = 8192,
            m_sp = 1,           // Accessのログイン形式
            m_sdup = 2,         // SQLServerのログイン形式
            m_odbc = 3,         // ODBCのログイン形式
            n_dsn = 4,          // ODBCのDSNを使用したログイン形式
            x_AllOption = 31,
            z_LetItGo = 0       // 入力したものをそのまま使う
        }
        void Connect(eSQL CnctEnum, string ServerName, string dbName = "", string UserName = "", string Password = "", string DNS = "")
        {
            switch (CnctEnum)
            {
                case eSQL.a_Access:

                    break;
            }
        }
        protected override void Terminate() { }
    }
}