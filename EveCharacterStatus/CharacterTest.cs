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
			var character = new Character("Hank Bangflex");
			Assert.AreEqual(character.name, "Hank Bangflex");
		}
		
		[Test()]
		public void Character_should_not_return_null ()
		{
			var character = new Character("Hank Bangflex");
			Assert.AreNotEqual(character,null);
		}
	}
}



	



