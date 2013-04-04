using System;
using NUnit.Framework;

namespace EveCharacterStatus
{
	[TestFixture()]
	public class CharacterTest
	{
		[Test()]
		public void Should_have_a_name ()
		{
			/**
			 * Write the character class required to make this test
			 * pass.
			 * 
			 * You can run the test by pressing View/UnitTesting then 
			 * clicking the green down arrow on the left.
			 * 
			 * After you've made it work, wire up the Main class to print
			 * out the name of your character.
			 * 
			 * We're not going to populate the character using the API yet
			 * so don't get side tracked.
			 */
			var character = new Character("Hank BangFlex");
			Assert.AreEqual(character.name, "Hank BangFlex");
		}
	}
}

