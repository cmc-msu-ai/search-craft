using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneralPackage.GameData;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                
            AgentTypeTemplate[] userAgents = new AgentTypeTemplate[1];
            userAgents[0] = new AgentTypeTemplate("DEMO", "wsf", () => new TestAgent());
            Application.Run(new StartForm(userAgents));
        }
    }
}
