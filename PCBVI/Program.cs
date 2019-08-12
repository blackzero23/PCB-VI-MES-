using PCBVI.Forms.Login;
using PCBVI.Forms.Main;
using System;
using System.Windows.Forms;

namespace PCBVI
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForms());
        }
    }
}
