using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralPackage.GameData;

namespace WindowsFormsApplication1
{
    public struct PreSettings
    {
    #region attributes

        public uint targetCount;

        public uint wallCount;

        public Dictionary<string, uint> agents;

        public uint maxAgents;

        private uint timeLimit;

        public uint turnLimit;

        public bool startGame;

        public string description;

        public bool sudo;

        public AgentTypeTemplate[] userAgents;

    #endregion


        public void setTimeLimit(uint minutes, uint seconds)
        {
            timeLimit = 60000 * minutes + 1000 * seconds;
        }

        public uint getTimeLimit()
        {
            return timeLimit;
        }

        public void addAgent(string agentType, uint count)
        {
            if (agents == null)
            {
                agents = new Dictionary<string, uint>();
            }
            if (!agents.ContainsKey(agentType))
            {
                agents.Add(agentType, count);
            }
            else
            {
                agents[agentType] += count;
            }
        }
    }

    public struct AgentTypeTemplate
    {
        public string name;
        public string permissions;
        public Func<AgentBaseClass> typeFunc;

        public AgentTypeTemplate(string agentName, string agentPermissions, Func<AgentBaseClass> agentGenerator)
        {
            name = agentName;
            permissions = agentPermissions;
            typeFunc = agentGenerator;
        }
    }
}
