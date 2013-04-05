using System;

namespace EveCharacterStatus
{
	public class Character
	{
		public string name;
		public string firstName;
		public string lastName;
		
		public Character (string inputName)
		{
			this.name =	inputName.Trim();			
			
			char[] delimit = new char[] { ' ' };
			string [] split = name.Split(delimit);
			
			firstName = split[0];
			
			if (split.Length > 1)
			{
				lastName = split[split.Length - 1];
			}	
				
		}
			
	}
}
