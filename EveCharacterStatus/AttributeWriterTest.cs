using System;
using NUnit.Framework;

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
	}
}

