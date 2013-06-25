using System;
using EveAI.Live;
using EveAI.Live.Character;

namespace EveCharacterStatus
{
	public class Eve_Testing
	{
		public long keyID = 1904964;
		public string vCode = "zesRGv3T3jsETycEd0gChWLvA4VCj1xPN7c5kGgfdwRgrXIE80ARYe1EDcvAUZw7";
		public long characterID = 268435455;

		public Eve_Testing ()
		{
				EveApi theThing = new EveApi (keyID, vCode, characterID);

			Console.WriteLine ("Character Name is: " + theThing.GetCharacterInfo());
			Console.ReadLine();

		}
	}
}

