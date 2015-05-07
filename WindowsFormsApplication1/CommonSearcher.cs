using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralPackage.Controller;
using GeneralPackage.GameData;
using GeneralPackage.Structures;

namespace WindowsFormsApplication1
{
    class CommonSearcher : AgentBaseClass
    {
        private IWalker walk;
        private ISearcher search;
        private ISensor sense;
        bool seted = false;
        string mode;


        #region general functions

        private bool moveToAim(Coord aim)
        {
            Coord vec = aim - sense.myPosition();
            return walk.makeStep(vec);
        }

        private double distance(Coord point)
        {
            return (sense.myPosition() - point).norm();
        }

        private bool nearestTarget(out AgentCutaway res)
        {//есть ли рядом цели поиска? Если есть, записать в res
            IReadOnlyCollection<AgentCutaway> list = sense.agentsAround();
            foreach (AgentCutaway ac in list)
            {
                if (ac.state == AgentState.Target)
                {
                    res = ac;
                    return true;
                }
            }
            res = new AgentCutaway();
            return false;
        }

        #endregion

        #region random searcher

        private Coord path;
        private bool pathSeted = false;
        private bool seeAgent = false;
        private AgentCutaway aimAgent;
        private void randSearcherMakeTurn()
        {
            if (!seeAgent)
            {
                seeAgent = nearestTarget(out aimAgent);
            }
            if (seeAgent)
            {
                if (search.grabObject(aimAgent.ID))
                {
                    seeAgent = false;
                    pathSeted = false;
                }
                else
                {
                    moveToAim(aimAgent.coord);
                    return;
                }

            }
            if (pathSeted)
            {
                if (!moveToAim(path))
                {
                    pathSeted = false;
                }
                else
                {
                    if (distance(path) < 0.00001)
                    {
                        pathSeted = false;
                    }
                }
            }
            if (!pathSeted)
            {
                path = Coord.rand();
                pathSeted = true;
            }
        }

        #endregion

        public CommonSearcher(string mode)
        {
            this.mode = mode;
        }

        public override void setController(ControllerSet com_) {
            walk = com_.iWalker;
            search = com_.iSearcher;
            sense = com_.iSensor;
            seted = true;
        }

        public override void makeTurn()
        {
            if (mode == "Random searcher")
            {
                randSearcherMakeTurn();
            }
        }

    }
}
