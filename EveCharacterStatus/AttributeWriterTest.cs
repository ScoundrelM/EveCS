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
			mockWriter = new SpyConsoleWriter();
			attributeWriter = new AttributeWriter(this.mockWriter);
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
			this.attributeWriter.PrintAttribute(mockAttribute("test",6));
			Assert.AreEqual("Base test: 6",  this.mockWriter.lastWritten());
		}

		[Test]
		public void Should_print_attribute_augmentors()
		{
			this.attributeWriter.PrintAttributeAugmentors(mockAttribute("test",3));
			Assert.AreEqual("test Augmentation: 3", this.mockWriter.lastWritten ());
		}

		[Test]
		public void Should_print_attribute_totals()
		{
			this.attributeWriter.PrintAttributeTotals(mockAttribute("test",1.5));
			Assert.AreEqual("test Total: 1.5", this.mockWriter.lastWritten ());
		}

		private KeyValuePair<string,double> mockAttribute(string name,double value)
		{
			return new KeyValuePair<string, double> (name,value);
		}


	}
}

