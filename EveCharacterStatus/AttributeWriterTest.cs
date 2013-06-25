using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace EveCharacterStatus
{
	[TestFixture()]
	public class AttributeWriterTest
	{
		private SpyConsoleWriter mockWriter;
		private AttributeWriter attributeWriter;

		[SetUp]
		public void Init ()
		{
			mockWriter = new SpyConsoleWriter ();
			attributeWriter = new AttributeWriter (this.mockWriter);
		}


		[Test()]
		public void Should_print_attribute_breakdown ()
		{
			this.attributeWriter.PrintAttributeBreakdown("Intelligence", 20, 19, 1);
			
			Assert.AreEqual("Intelligence: \t\t20 (19) +1", this.mockWriter.lastWritten());

		}

		[Test()]
		public void Should_print_attribute()
		{
		
			KeyValuePair<string, double> mockAttribute = new KeyValuePair<string, double> ("test", 6);

			this.attributeWriter.PrintAttribute (mockAttribute);

			Assert.AreEqual ("Base test: , 6",  this.mockWriter.lastWritten());
		}

		[Test]
		public void Should_print_attribute_augmentors()
		{

			KeyValuePair<string, double> mockAttribute = new KeyValuePair<string, double> ("test", 3);

			this.attributeWriter.PrintAttributeAugmentors (mockAttribute);

			Assert.AreEqual ("test Augmentation: , 3", this.mockWriter.lastWritten ());
		}

		[Test]
		public void Should_print_attribute_totals()
		{

			KeyValuePair<string, double> mockAttribute = new KeyValuePair<string, double> ("test", 1.5);

			this.attributeWriter.PrintAttributeTotals (mockAttribute);

			Assert.AreEqual ("test Total: 1.5", this.mockWriter.lastWritten ());
		}



	}
}

