﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан инструментальным средством
//     В случае повторного создания кода изменения, внесенные в этот файл, будут потеряны.
// </auto-generated>
//------------------------------------------------------------------------------
namespace GeneralPackage.GameData
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
    using Controller;

	public class Board
	{
        public Board()
        {
            walls = new WallList();
            agents = new AgentList();
        }

        #region attributes

        public WallList Walls
		{
            get { return walls; }
		}

		public AgentList Agents
		{
            get { return agents; }
		}

        private WallList walls;
        private AgentList agents;

        #endregion



    }
}

