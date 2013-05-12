using System;
using System.Collections.Generic;

namespace EveCharacterStatus
{
	public class AttributeWriter
	{
		public AttributeWriter ()
		{
		}

		public void PrintAttribute(KeyValuePair<string, double> attributeToPrint)
		{
			Console.WriteLine("Base {0}: , {1}", attributeToPrint.Key, attributeToPrint.Value);
		}

		public void PrintAttributeAugmentors (KeyValuePair<string,double> attributeAugmentorToPrint)
		{
			Console.WriteLine("{0} Augmentation: , {1}", attributeAugmentorToPrint.Key, attributeAugmentorToPrint.Value);
		}

		public void PrintAttributeTotals(KeyValuePair<string,double> attributeTotalToPrint)
		{
			Console.WriteLine ("{0} Total: {1}", attributeTotalToPrint.Key, attributeTotalToPrint.Value);
		}

		public void PrintAttributeBreakdown(KeyValuePair<string, double> attributes, KeyValuePair<string,double> attributeAugmentors, KeyValuePair<string, double> attributeTotals)
		{
			Console.WriteLine ("Base Attribute {0}: {1} : Attribute Augmentation: {2} : Attribute Total: {3}", attributes.Key, attributes.Value, attributeAugmentors.Value, attributeTotals.Value);
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

