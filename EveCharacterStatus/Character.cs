using System;
using System.Collections.Generic;

namespace EveCharacterStatus
{
	public class Character
	{
		public string name;
		
		public Dictionary<string, double> attributes;
		public Dictionary<string,double> attributeAugmentations;
		public Dictionary<string, double> attributeTotals;

		public Character(string _name)
		{
			name = _name;
		}
			
	}
}
