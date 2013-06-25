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

//		[Test()]
//		public void Attributes_should_not_return_null ()
//		{
//			var character = new Character("Hank Bangflex");
//			Assert.AreNotEqual(character.attributes,null);
//		}

//		[Test()]
//		public void Character_should_have_intelligence ()
//		{
//			var character = new Character("Hank Bangflex");
//			Assert.AreNotEqual(character.intelligence,null);
//		}
//
//		[Test()]
//		public void Character_should_have_perception ()
//		{
//			var character = new Character("Hank Bangflex");
//			Assert.AreNotEqual(character.perception,null);
//		}	
//
//		[Test()]
//		public void Character_should_have_charisma ()
//		{
//			var character = new Character("Hank Bangflex");
//			Assert.AreNotEqual(character.charisma,null);
//		}	
//
//		[Test()]
//		public void Character_should_have_willpower ()
//		{
//			var character = new Character("Hank Bangflex");
//			Assert.AreNotEqual(character.willpower,null);
//		}	
//
//		[Test()]
//		public void Character_should_have_memory ()
//		{
//			var character = new Character("Hank Bangflex");
//			Assert.AreNotEqual(character.memory,null);
//		}	

	}
}



	



