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

		public void PrintAttributeBreakdown(string name, double original, double total)
		{
			double augmentor = total - original;

			if (augmentor == 0)
			{
				console.WriteLine ("{0}: \t\t{1}.", name, total);
			}

			else
			{
				console.WriteLine ("{0}: \t\t{1} ({2}) +{3}", name, total, original, augmentor);
			}

		}
	}
}






