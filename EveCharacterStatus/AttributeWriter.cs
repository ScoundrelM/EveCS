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
		
			if(total != original + augmentor)
			{
				console.WriteLine ("There is a problem with your incoming data. The augmentor plus the base value does not equal the total.");
			}
			else
			{
				if(augmentor != 0)
				{
					console.WriteLine("{0}: \t\t{1} ({2}) +{3}", name, original, total, augmentor);
				}
				else
				{
					console.WriteLine("{0}: \t\t{1} ({2})", name, original, total, augmentor);
				}
			}
		}
	}
	}
