using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyPost.DataBase;

namespace CopyPost
{
    static class Program
    {

        public static StatusBarGlobal statusBarGlobal = new StatusBarGlobal();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataBaseControl db = new DataBaseControl();
            db.GetLastRecordListRutor();

            Application.Run(new Form_Main());
        }
    }
}
