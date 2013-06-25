using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace EveCharacterStatus
{
	[TestFixture()]
	public class AttributeWriterTest
	{
		[Test()]
		public void Should_print_attribute_breakdown ()
		{
			var mockWriter = new SpyConsoleWriter();
			var attributeWriter = new AttributeWriter(mockWriter);
			
			attributeWriter.PrintAttributeBreakdown("Intelligence", 20, 19, 1);
			
			Assert.AreEqual("Intelligence: \t\t20 (19) +1", mockWriter.lastWritten());
		}

		[Test()]
		public void Should_print_attribute()
		{
			var mockwriter = new SpyConsoleWriter ();
			AttributeWriter attributeWriter = new AttributeWriter (mockwriter);

			KeyValuePair<string, double> mockAttribute = new KeyValuePair<string, double> ("test", 6);

			attributeWriter.PrintAttribute (mockAttribute);

			Assert.AreEqual ("Base test: , 6",  mockwriter.lastWritten());
		}

		[Test]
		public void Should_print_attribute_augmentors()
		{
			var mockwriter = new SpyConsoleWriter ();
			AttributeWriter attributeWriter = new AttributeWriter (mockwriter);

			KeyValuePair<string, double> mockAttribute = new KeyValuePair<string, double> ("test", 3);

			attributeWriter.PrintAttributeAugmentors (mockAttribute);

			Assert.AreEqual ("test Augmentation: , 3", mockwriter.lastWritten ());
		}

		[Test]
		public void Should_print_attribute_totals()
		{
			var mockwriter = new SpyConsoleWriter ();
			AttributeWriter attributeWriter = new AttributeWriter (mockwriter);

			KeyValuePair<string, double> mockAttribute = new KeyValuePair<string, double> ("test", 1.5);

			attributeWriter.PrintAttributeTotals (mockAttribute);

			Assert.AreEqual ("test Total: 1.5", mockwriter.lastWritten ());
		}
	}
}

