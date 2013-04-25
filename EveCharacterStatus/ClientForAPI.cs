using System;
using EveAI;
using EveAI.Live;

namespace EveCharacterStatus
{
	public class ClientForAPI
	{
		// information stored by the client from the api
		public string characterName;

		public ClientForAPI (Int32 iD1, string iD2, Int32 iD3)
		{
			// Incoming identification information
			Int32 incomingNumber1 =iD1;
			string incomingString1 = iD2;
			Int32 incomingNumber2 = iD3;

			EveAI.Live.EveApi apiInformationStore = new EveAI.Live.EveApi  (incomingNumber1, incomingString1,  incomingNumber2);


			string characterName =apiInformationStore.GetCharacterSheet().Name;


		}

		public getCharacter()
		{

		}
	}
}

