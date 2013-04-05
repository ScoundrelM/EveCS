using System;

namespace EveCharacterStatus
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Name: ");
			string inPutName = Console.ReadLine().ToString();
			Character character = new Character(inPutName);
			
			Console.WriteLine("Your Character Name is: "+character.name);
			Console.WriteLine("The character's first name is: " +character.firstName);
			Console.WriteLine("The character's last name is: " +character.lastName);
		}
	}
}
