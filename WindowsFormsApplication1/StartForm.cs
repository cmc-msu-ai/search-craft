using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneralPackage.GameData;

namespace WindowsFormsApplication1
{
    public partial class StartForm : Form
    {
        private PreSettings set = new PreSettings();

        public StartForm()
        {
            InitializeComponent();
        }

        public StartForm(AgentTypeTemplate[] userAgents)
        {
            InitializeComponent();
            set.userAgents = userAgents;
        }

        private void startGame()
        {
            this.Hide();
            Form f = new DemoForm(set);
            var d = f.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            set.sudo = true;
            set.description = Descriptions.demoDescription;
            startGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            set.maxAgents = 20;
            set.targetCount = 40;
            set.setTimeLimit(2, 0);
            set.turnLimit = 1000;
            set.description = Descriptions.standartTaskDescription;
            startGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            set.maxAgents = 20;
            set.targetCount = 40;
            set.setTimeLimit(2, 0);
            set.turnLimit = 1000;
            set.wallCount = 10;
            startGame();
        }
    }
}
