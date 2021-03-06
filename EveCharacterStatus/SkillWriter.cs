using System;
using System.Collections.Generic;

namespace EveCharacterStatus
{
	public class SkillWriter
	{
		private IConsoleWriter console;

		public SkillWriter (IConsoleWriter _console)
		{
			console = _console;
		}

		public void PrintSkill(KeyValuePair<string, int> skillToPrint)
		{
			console.WriteLine ("{0} Rank: {1}", skillToPrint.Key, skillToPrint.Value);
		}
}
}

