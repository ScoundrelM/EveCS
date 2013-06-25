using System;
using System.Collections.Generic;

namespace EveCharacterStatus
{
	public class AttributeWriter
	{
		
		private IConsoleWriter console;
			
		public AttributeWriter(IConsoleWriter _console)
		{
			console = _console;
		}

		public void PrintAttribute(KeyValuePair<string, double> attributeToPrint)
		{
			console.WriteLine("Base {0}: {1}", attributeToPrint.Key, attributeToPrint.Value);
		}

		public void PrintAttributeAugmentors (KeyValuePair<string,double> attributeAugmentorToPrint)
		{
			console.WriteLine("{0} Augmentation: {1}", attributeAugmentorToPrint.Key, attributeAugmentorToPrint.Value);
		}

		public void PrintAttributeTotals(KeyValuePair<string,double> attributeTotalToPrint)
		{
			console.WriteLine("{0} Total: {1}", attributeTotalToPrint.Key, attributeTotalToPrint.Value);
		}

		public void PrintAttributeBreakdown(string name, double original, double total,  double augmentor)
		{
			console.WriteLine("{0}: \t\t{1} ({2}) +{3}", name, original, total, augmentor);
		}

		// public void PrintIntelligence(Character charToPrintFor)
		// {
			// Console.WriteLine("Intelligence: " + charToPrintFor.intelligence);
		// }

		// public void PrintPerception(Character charToPrintFor)
		// {
			// Console.WriteLine("Perception: " + charToPrintFor.perception);
		// }

		// public void PrintCharisma(Character charToPrintFor)
		// {
			// Console.WriteLine("Charisma: " + charToPrintFor.charisma);
		// }

		// public void PrintWillpower(Character charToPrintFor)
		// {
			// Console.WriteLine("Willpower: " + charToPrintFor.willpower);
		// }

		// public void PrintMemory(Character charToPrintFor)
		// {
			// Console.WriteLine("Memory: " + charToPrintFor.memory);
		// }


	}
	}