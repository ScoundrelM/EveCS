using System;
using EveAI;
using EveAI.Live.Character;

namespace EveCharacterStatus
{
	public class Character
	{
		public string name;
		public string firstName;
		public string lastName;
		
		// Character attributes. Double value.	
		public double intelligence;
		public double perception;
		public double charisma;
		public double willpower;
		public double memory;
		
		
		
		
		
		
		public Character ()
		{

			EveAI.Live.EveApi api = new EveAI.Live.EveApi  (1904964, "zesRGv3T3jsETycEd0gChWLvA4VCj1xPN7c5kGgfdwRgrXIE80ARYe1EDcvAUZw7",  268435455);

			CharacterSheet charSheet = api.GetCharacterSheet ();
							
			intelligence = charSheet.AttributeIntelligenceTotal;
			perception = charSheet.AttributePerceptionTotal;
			charisma = charSheet.AttributeCharismaTotal;
			willpower = charSheet.AttributeWillpowerTotal;
			intelligence = charSheet.AttributeIntelligenceTotal;

			name =	charSheet.Name.Trim();

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
