using System;

namespace EveCharacterStatus
{
	public class AttributeWriter
	{
		public AttributeWriter ()
		{
		}

		public void PrintIntelligence(Character charToPrintFor)
		{
			Console.WriteLine("Intelligence: " + charToPrintFor.intelligence);
		}

		public void PrintPerception(Character charToPrintFor)
		{
			Console.WriteLine("Perception: " + charToPrintFor.perception);
		}

		public void PrintCharisma(Character charToPrintFor)
		{
			Console.WriteLine("Charisma: " + charToPrintFor.charisma);
		}

		public void PrintWillpower(Character charToPrintFor)
		{
			Console.WriteLine("Willpower: " + charToPrintFor.willpower);
		}

		public void PrintMemory(Character charToPrintFor)
		{
			Console.WriteLine("Memory: " + charToPrintFor.memory);
		}


	}
}

