using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralPackage.Structures;
using GeneralPackage.Controller;
using GeneralPackage.GameData;

namespace WindowsFormsApplication1
{
    class TestAgent: AgentBaseClass
    {
        private IWalker walk;
        private ISearcher search;
        private ISensor sense;
        //переменные для хранения интерфейсов 
        private Coord aim = Coord.rand();
        //в этой переменной будет храниться точка на карте к которой будет двигаться агент
        public override void setController(ControllerSet com_)
        {
            walk = com_.iWalker;
            search = com_.iSearcher;
            sense = com_.iSensor;
        }
        public override void makeTurn()
        {
            Coord myPos = sense.myPosition();
            if ((aim - myPos).norm() <= 0.00001)
            {//если мы добрались до точки, к которой шли, выбрать новую цель
                aim = Coord.rand();
            }
            AgentCutaway[] objectsAround = sense.agentsAround();
            foreach (AgentCutaway ag in objectsAround)
            {
                if (ag.state == AgentState.Target)
                {//Если в поле видимости попала цель поиска, то попробовать взять её
                    search.grabObject(ag.ID);
                    break;
                }
            }
            walk.makeStep(aim - myPos);
            // продолжать движение к точке
        }
    }
}
