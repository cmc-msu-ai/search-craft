using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EndScreen : Form
    {
        public struct inputData {
            public DemoForm.endReason reason;
            public int time;
            public int turns;
            public int timeOut;
            public int turnOut;
            public int totalTargetCount;
            public int targetsFound;
        }

        public EndScreen(inputData input)
        {
            InitializeComponent();
            timeLabel.Text = "Time = " + timeToString(input.time);
            turnLabel.Text = "Turns = " + input.turns.ToString();
            targetsLabel.Text = string.Format("Targets found {0}/{1}", input.targetsFound, input.totalTargetCount);
            if (input.totalTargetCount == input.targetsFound)
            {
                targetsLabel.ForeColor = Color.Green;
            }
            else
            {
                targetsLabel.ForeColor = Color.Red;
            }
            switch (input.reason)
            {
                case DemoForm.endReason.success:
                    mainLabel.Text = "All aims found.";
                    break;
                case DemoForm.endReason.timeLimit:
                    mainLabel.Text = "Timeout.\nTime limit = " + timeToString(input.timeOut);
                    timeLabel.Text = "Your time = " + timeToString(input.time);
                    mainLabel.ForeColor = Color.Red;
                    timeLabel.ForeColor = Color.Red;
                    break;
                case DemoForm.endReason.turnLimit:
                    mainLabel.Text = "Too much turns.\nTurns limit = " + input.turnOut.ToString();
                    turnLabel.Text = "Turns made = " + input.turns.ToString();
                    mainLabel.ForeColor = Color.Red;
                    turnLabel.ForeColor = Color.Red;
                    break;
            }

        }

        #region attributes


        #endregion

        private static string timeToString(int time)
        {
            return (time / 60000).ToString() + " minutes, "
                               + ((time / 1000) % 60).ToString() + '.'
                               + ((time / 100) % 10).ToString() + " seconds.";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
