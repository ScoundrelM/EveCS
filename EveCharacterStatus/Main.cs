using System;
//using EveAI.Live;


namespace EveCharacterStatus
{
	class MainClass
	{
		public static void Main (string[] args)
	{
			Console.WriteLine ("Name: ");

			Character character = new Character();


			Console.WriteLine("Your Character Name is: " +character.name);




			Console.ReadLine();

		}
	}
}
