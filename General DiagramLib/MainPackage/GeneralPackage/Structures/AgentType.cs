﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан инструментальным средством
//     В случае повторного создания кода изменения, внесенные в этот файл, будут потеряны.
// </auto-generated>
//------------------------------------------------------------------------------
namespace GeneralPackage.Structures
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public enum AgentType
	{
		Dummy,
        CommonSearcher,
		SearchTarget
	}

    public enum AgentState
    {
        Common,
        Target, 
        FoundTarget
    }
}
