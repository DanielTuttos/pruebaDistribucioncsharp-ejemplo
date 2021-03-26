using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;
using System.Threading.Tasks;

namespace ExtraerTexto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/DanielTuttos/pruebaDistribucioncsharp-ejemplo"))
            {
                await mgr.Result.UpdateApp();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
