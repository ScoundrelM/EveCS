using System;

namespace EveCharacterStatus
{
	public class Character
	{
		string name;
		string firstName;
		string secondName;
		
		public Character (string inputName)
		{
			this.name =	inputName.Trim();			
			
			char[] delimit = new char[] { ' ' };
			string [] split = name.Split(delimit);
			
			firstName = split[0];
			secondName = split[1];
		}
	}
}

