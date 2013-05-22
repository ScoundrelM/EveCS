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
			 * Part 1.
			 * 
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
			var character = new Character("Hank Bangflex");
			Assert.AreEqual(character.name, "Hank Bangflex");
		}
		
		[Test()]
		public void Should_have_a_first_name ()
		{
			/**
			 * Part 2.
			 * 
			 * Add functionality to your character class to make this test pass.
			 */
			var character = new Character("Bank Hangflex");
			Assert.AreEqual(character.firstName, "Bank");
		}
		
		/**
		 * Part 3.
		 * 
		 * Write a test for the characters Surname and then write
		 * the functionality into the Character class.
		 */
		[Test()]
		public void Should_have_a_surname ()
		{		
			var character = new Character("Firsty Lasty");
			Assert.AreEqual(character.lastName, "Lasty");
		}
		
		/**
		 * Part 4.
		 * 
		 * Write a test that checks the surname is correct for a character 
		 * with the name: "Hank B. Hangflex", then add the functionality
		 * to your Character class.
		*/
		
		[Test()]
		public void Should_have_a_surname_inLongName ()
		{
			var character = new Character("Hank B. Hangflex");
			Assert.AreEqual(character.lastName, "Hangflex");
		}
		
		/* 
		 * Write another test that checks that the surname is correct 
		 * for a character called just "Hank", then add the functionality
		 * to your Character class.
		 */
		
		[Test()]
		public void Should_have_no_surname_inSingleWordName ()
		{
			var character = new Character("Hank");
			Assert.AreEqual(character.lastName, "");
		}
	
		[Test()]
		public void Should_have_integer_value_in_attributes ()
		{
			var character = new Character("Test Tester");
			
			Assert.IsInstanceOfType(character, Character);
				
		}
		
	}
	
	
}


