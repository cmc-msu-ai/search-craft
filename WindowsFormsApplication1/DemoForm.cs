using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneralPackage.Manager;
using GeneralPackage.Visualizer;
using GeneralPackage.Structures;
using GeneralPackage.Controller;
using GeneralPackage.GameData;
using System.Threading;



namespace WindowsFormsApplication1
{
    public partial class DemoForm : Form
    {
        #region Form attributes

        #region State vars

        private enum gameState { running, pause, deploy };
        private bool sudo = false;
        private gameState state = gameState.deploy;
        private Semaphore clickZone = new Semaphore(1, 1);

        #endregion

        #region Time vars

        private int passedTime = 0;
        private int passedTurns = 0;
        private int timeLimit = int.MaxValue;
        private int turnLimit = int.MaxValue;

        #endregion

        #region agent adder vars

        private AgentAdder agentAdder = new AgentAdder();
        private Func<AgentBaseClass> myFunc = () => new SimpleWalker();
        private List<string> activeAgentList = new List<string>();
        private int totalTargetCount = 0;
        private int activeTargets = 0;
        private int agentLimit {
            get { return __agentLimit__; }
            set {
                __agentLimit__ = value;
                updateAgentLimit();
            }
        }
        private int __agentLimit__ = int.MaxValue;




        #endregion

        #region enums

        public enum endReason { success, turnLimit, timeLimit };

        #endregion

        #endregion

        #region gameData

        private Manager manager;
        private CommonFormVisualizer vis;

        #endregion

        #region constructors

        public DemoForm()
        {
            InitializeComponent();

            manager = new Manager();

            vis = manager.getFormVis(screenBox);
            vis.showSightAreas = checkShowAreas.Checked;

            foreach (string st in agentAdder.agentTypeDict.Keys)
            {
                agentSelectBox.Items.Add(st);
            }
            agentSelectBox.Items.Add("Search target");
            //addTarget();
        }

        public DemoForm(PreSettings preset): this()
        {
            applySetup(preset);
        }

        #endregion


        #region addding/deleting agents

        void addAgent(string agentType)
        {
            if (agentAdder.agentTypeDict.ContainsKey(agentType))
            {
                string per = agentAdder.agentTypeDict[agentType].Item1;
                AgentBaseClass ag = agentAdder.agentTypeDict[agentType].Item2();
                Tuple<ControllerSet, int> ctrl = manager.addAgent(genDeploy(), ag, Average.speed, Average.viewRadius, per);
                ag.setController(ctrl.Item1);
                agentAdder.addAgent(ctrl.Item2, agentType);
                updateAgentLimit();
            }
        }

        void addTarget(string targetType = "Common target")
        {
            if (agentAdder.targetTypeDict.ContainsKey(targetType))
            {
                totalTargetCount++;
                string per = agentAdder.targetTypeDict[targetType].Item1;
                AgentBaseClass ag = agentAdder.targetTypeDict[targetType].Item2();
                Tuple<ControllerSet, int> ctrl = manager.addAgent(Coord.rand(), ag, Average.speed, Average.viewRadius,
                    per,AgentType.SearchTarget, AgentState.Target);
                ag.setController(ctrl.Item1);
                agentAdder.addTarget(ctrl.Item2, targetType);
            }
        }

        private Coord genDeploy()
        {
            Coord co = Coord.rand();
            co.x /= 20;
            co.y /= 20;
            return co;
        }


        #endregion


        private void updateAgentLimit()
        {
            if (agentLimit < int.MaxValue)
            {
                limitLabel.Text = (agentLimit - agentAdder.countAgents()).ToString() + " agent left.";
            }
            limitLabel.ForeColor = Color.Black;
        }
        private void changeState(gameState st)
        {
            if (state == gameState.deploy)
            {
                if (st == gameState.running)
                {
                    drawTimer.Enabled = true;
                    activeTargets = totalTargetCount + 1;
                    updateGoals();
                    if (!sudo)
                    {
                        addAgentButton.Enabled = false;
                        deleteAgentButon.Enabled = false;
                    }
                    //запуск игры
                }
            }
            if (state == gameState.running)
            {
                if (st == gameState.pause)
                {
                    //установка паузы
                }
            }
            if (state == gameState.pause)
            {
                if (st == gameState.running)
                {
                    //сброс паузы
                }
            }
            state = st;
        }

        private void refreshListBox()
        {
            int count1;
            activeAgentList.Clear();
            foreach (string str in agentAdder.agentTypeDict.Keys)
            {
                count1 = agentAdder.countAgents(str);
                if (count1 > 0)
                {
                    activeAgentList.Add(str + " x" + count1.ToString());
                }
            }
            agentsBox.DataSource = null;
            agentsBox.DataSource = activeAgentList;
            updateAgentLimit();
        }

        private int countActiveTargets()
        {
            int count = 0;
            foreach (int ID in agentAdder.countActiveTargets())
            {
                if (manager.getAgentState(ID) == AgentState.Target)
                {
                    count++;
                }
            }
            return count;
        }

        private bool updateGoals()
        {// If true - all goals are accomplished
         //TODO: если добавятся разные типы целей - обновит
            int c = countActiveTargets();
            if (activeTargets != c)
            {
                activeTargets = c;
                taskList.Items.Clear();
                taskList.Items.Add(String.Format("{0}/{1} targets found", totalTargetCount-c, totalTargetCount), c == 0);
                taskList.Refresh();
            }
            return c == 0;
        }

        private void endGame(endReason reason)
        {
            EndScreen.inputData data = new EndScreen.inputData();
            data.reason = reason;
            data.targetsFound = totalTargetCount - activeTargets;
            data.totalTargetCount = totalTargetCount;
            data.turns = passedTurns;
            data.time = passedTime;
            data.timeOut = timeLimit;
            data.turnOut = turnLimit;
            Form gameOver = new EndScreen(data);
            timeUpdater.Enabled = false;
            drawTimer.Enabled = false;
            var d = gameOver.ShowDialog();
            this.Close();
        }

        private void applySetup(PreSettings preset)
        {
            sudo = preset.sudo;
            if (preset.maxAgents > 0)
            {
                agentLimit = (int)preset.maxAgents;
            }
            if (preset.turnLimit > 0)
            {
                turnLimit = (int)preset.turnLimit;
            } 
            if (preset.getTimeLimit() > 0)
            {
                timeLimit = (int)preset.getTimeLimit();
            }
            for (uint i = 0; i < preset.wallCount; i++) {
                manager.board.Walls.addWall(Segment.rand());
            }
            for (uint i = 0; i < preset.targetCount; i++)
            {
                addTarget();
            }
            if (preset.startGame)
            {
                button1_Click(null, null);
            }
            if (preset.agents != null)
            {
                foreach (string ag in preset.agents.Keys)
                {
                    for (int i = 0; i < preset.agents[ag] ; i++)
                    {
                        addAgent(ag);
                    }
                }
            }
            if (preset.description != null)
            {
                descriptionBox.Text = preset.description;
            }
            if (preset.userAgents != null)
            {
                foreach (AgentTypeTemplate tup in preset.userAgents)
                {
                    agentAdder.addAgentType(tup.name, tup.permissions, tup.typeFunc);
                    agentSelectBox.Items.Add(tup.name);
                }
            }
            refreshListBox();

            
        }

        #region events

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (state == gameState.deploy)
            {
                changeState(gameState.running);
                pauseButton.Text = "Пауза";
            }
            else if (state == gameState.running)
            {
                changeState(gameState.pause);
                pauseButton.Text = "Продолжить";
            }
            else if (state == gameState.pause)
            {
                changeState(gameState.running);
                pauseButton.Text = "Пауза";
            }
        }

        

        

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            if (clickZone.WaitOne(2))
            {
                //если дождались семафора
                if (state == gameState.running)
                {
                    manager.launchAgents();
                    passedTurns += 1;
                    turnCountLabel.Text = passedTurns.ToString();
                }
                screenBox.Refresh();
                if (updateGoals() && state == gameState.running)
                {
                    endGame(endReason.success);
                }
                if (passedTurns >= turnLimit)
                {
                    endGame(endReason.turnLimit);
                }
                clickZone.Release();
            }
            else
            {
                return;
            }
            
        }

        private void screenBox_Paint(object sender, PaintEventArgs e)
        {
            if (checkDrawField.Checked)
            {
                vis.draw(e);
            }
        }

        private void checkShowAreas_CheckedChanged(object sender, EventArgs e)
        {
            vis.showSightAreas = checkShowAreas.Checked;
            screenBox.Refresh();
        }

        private void timeUpdater_Tick(object sender, EventArgs e)
        {
            if (state == gameState.running)
            {
                passedTime += 100;
                timeLabel.Text = (passedTime / 60000).ToString() + ':' 
                               + ((passedTime / 1000) % 60).ToString() + ',' 
                               + ((passedTime / 100) % 10).ToString();
                if (passedTime >= timeLimit)
                {
                    endGame(endReason.timeLimit);
                    changeState(gameState.pause);
                    timeLimit = int.MaxValue;
                }
            }
        }

        private void addAgentButton_Click_1(object sender, EventArgs e)
        {
            if (addAgentNumeric.Value + agentAdder.countAgents() > agentLimit)
            {
                addAgentNumeric.Value = Math.Max(0,agentLimit - agentAdder.countAgents());
                limitLabel.ForeColor = Color.Red;
                return; 
            }
            if ((string)agentSelectBox.SelectedItem == "Search target")
            {
                for (int i = 0; i < addAgentNumeric.Value; ++i)
                {
                    addTarget();
                }
            }
            else if (agentSelectBox.SelectedItem != null)
            {
                for (int i = 0; i < addAgentNumeric.Value; ++i)
                {
                    addAgent((string)agentSelectBox.SelectedItem);
                }
            }
            refreshListBox();
        }


        private void deleteAgentButon_Click(object sender, EventArgs e)
        {
            if (!(state == gameState.deploy || sudo))
            {
                return;
            }
            if (agentsBox.SelectedIndex >= 0)
            {
                string str = (string)agentsBox.SelectedItem;
                int i = str.LastIndexOf('x');
                str = str.Substring(0, i - 1);
                while (true)
                {
                    i = agentAdder.delAgent(str);
                    if (i < 0)
                    {
                        return;
                    }
                    else
                    {
                        manager.delAgent(i);
                        refreshListBox();
                    }
                }
            }
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        

    }
}
