using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace EveCharacterStatus
{
		[TestFixture()]
		public class SkillWriterTest
		{
			private SpyConsoleWriter mockWriter;
			private SkillWriter skillWriter;

			[SetUp]
			public void Init ()
			{
				mockWriter = new SpyConsoleWriter();
				skillWriter = new SkillWriter(this.mockWriter);
			}

		[Test()]
		public void Should_print_skills()
		{
			this.skillWriter.PrintSkill(mockSkill("test", 1));
			Assert.AreEqual("test Rank: 1", this.mockWriter.lastWritten());
		}

		private KeyValuePair<string,int> mockSkill(string name,int value)
		{
			return new KeyValuePair<string, int> (name,value);
		}

	}
}

