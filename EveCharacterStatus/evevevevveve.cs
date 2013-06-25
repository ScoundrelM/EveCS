using System;
using EveAI;
using EveAI.Live.Character;

namespace evetesting
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			EveAI.Live.EveApi api = new EveAI.Live.EveApi  (1904964, "zesRGv3T3jsETycEd0gChWLvA4VCj1xPN7c5kGgfdwRgrXIE80ARYe1EDcvAUZw7",  268435455);

			CharacterSheet charSheet = api.GetCharacterSheet ();
			 
			if(charSheet == null)
			{
				Console.WriteLine("It's Null you fool");
				Console.ReadLine ();
			}

			else
			{
				Console.WriteLine ("Nope not that");
				Console.WriteLine ("Character " + charSheet.Name + " has " + charSheet.SkillpointTotal + " skillpoints");
				Console.WriteLine ("Skills:");
				foreach (CharacterSheet.LearnedSkill skill in charSheet.Skills)
				Console.WriteLine (skill);
				Console.ReadLine ();
			}
		}
	}
}
