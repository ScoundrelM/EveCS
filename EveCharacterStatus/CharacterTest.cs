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

		[Test()]
		public void Character_should_have_intelligence ()
		{
			var character = new Character("Hank Bangflex");
			Assert.AreEqual(character.intelligence,0.0);
		}

		[Test()]
		public void Character_should_have_perception ()
		{
			var character = new Character("Hank Bangflex");
			Assert.AreEqual(character.perception,0.0);
		}	

		[Test()]
		public void Character_should_have_charisma ()
		{
			var character = new Character("Hank Bangflex");
			Assert.AreEqual(character.charisma,0.0);
		}	

		[Test()]
		public void Character_should_have_willpower ()
		{
			var character = new Character("Hank Bangflex");
			Assert.AreEqual(character.willpower,0.0);
		}	

		[Test()]
		public void Character_should_have_memory ()
		{
			var character = new Character("Hank Bangflex");
			Assert.AreEqual(character.memory,0.0);
		}	

	}
}



	



