using System;

namespace EveCharacterStatus
{
	public class Character
	{
		public string name;
		public string firstName;
		public string lastName;
		
		// Character attributes. Integer value.	
		public int intelligence;
		public int perception;
		public int charisma;
		public int willpower;
		public int memory;
		
		
		
		
		
		
		public Character (string inputName)
		{
			name =	inputName.Trim();	
			intelligence = 10;
			perception = 10;
			charisma = 10;
			willpower = 10;
			lastName = "";
			
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
