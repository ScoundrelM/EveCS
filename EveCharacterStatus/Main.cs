using System;
//using EveAI.Live;


namespace EveCharacterStatus
{
	class MainClass
	{
		public static void Main (string[] args)
	{

			ClientForAPI api = new ClientForAPI(1904964, "zesRGv3T3jsETycEd0gChWLvA4VCj1xPN7c5kGgfdwRgrXIE80ARYe1EDcvAUZw7",  268435455);

			Character character = api.getCharacter(false);

			Console.WriteLine ("Name: " + character.name);

			Console.ReadLine();

		}
	}
}
