using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralPackage.GameData;

namespace WindowsFormsApplication1
{
    using cellType = Tuple<string, Func<AgentBaseClass>>;
    class AgentAdder
    {
        List<AgSt> agentList = new List<AgSt>();
        List<AgSt> targetList = new List<AgSt>();
        public Dictionary<string, cellType> agentTypeDict = new Dictionary<string, cellType>();
        public Dictionary<string, cellType> targetTypeDict = new Dictionary<string, cellType>();

        public AgentAdder()
        {//ENTRY POINT
            addAgentType("Agent 'right'", "w", () => new SimpleWalker("move right"));
            addAgentType("Agent 'random'", "w", () => new SimpleWalker("random movement"));
            addAgentType("Random searcher", "wsf", () => new CommonSearcher("Random searcher"));
            addTargetType("Common target", "", () => new AgentBaseClass());

        }

        public void addAgentType(string key, string permissions, Func<AgentBaseClass> func)
        {
            agentTypeDict.Add(key, new cellType(permissions, func));
        }
        private void addTargetType(string key, string permissions, Func<AgentBaseClass> func)
        {
            targetTypeDict.Add(key, new cellType(permissions, func));
        }

        private struct AgSt
        {
            public int id;
            public string agentType;
        }

        public void addAgent(int id_, string type_)
        {
            agentList.Add(new AgSt { id = id_, agentType = type_ });
        }

        public void addTarget(int id_, string agentType_ = "__target__")
        {
            targetList.Add(new AgSt { id = id_, agentType = agentType_ });
        }

        public void delTarget(int id_)
        {
            AgSt res = agentList.Find(
                delegate(AgSt ag)
                {
                    return ag.id == id_;
                });
            agentList.Remove(res);
        }

        public int delAgent(string type_)
        {
            AgSt res = agentList.Find(
                delegate(AgSt ag)
                {
                    return ag.agentType == type_;
                });
            if (agentList.Remove(res))
            {
                return res.id;
            }
            else
            {
                return -1;
            }

        }

        public int countAgents(string agentType)
        {
            return agentList.Count((AgSt ag) => ag.agentType == agentType);
        }

        public int countAgents(bool andTargets = false)
        {//returns number of agent. If "andTargets" returns targets + agent count.

            return agentList.Count + (andTargets ? targetList.Count : 0);
        }

        #region public functions


        public List<int> countActiveTargets()
        {
            List<int> res = new List<int>();
            foreach (AgSt ag in targetList)
            {
                res.Add(ag.id);
            }
            return res;
        }
        #endregion
    }
}
