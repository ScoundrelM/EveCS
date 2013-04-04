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
		}
	}
}
