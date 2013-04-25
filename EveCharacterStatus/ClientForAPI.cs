using System;
using EveAI;
using EveAI.Live;
using EveAI.Live.Character;

namespace EveCharacterStatus
{
	public class ClientForAPI
	{
		// information stored by the client from the api

		private EveAI.Live.EveApi api;

		public string characterName;

		private Character character;

		private Int32 keyID;
		private string vCode;
		private Int32 characterID;

		public ClientForAPI (Int32 _keyID, string _vCode, Int32 _characterID)
		{
			keyID =_keyID;
			vCode = _vCode;
			characterID = _characterID;
		}

		public Character  getCharacter(bool useCache = true)
		{

			if(this.character == null || !useCache)
			{
				CharacterSheet cs = getApi().GetCharacterSheet();
				this.character = new Character(cs.Name);
			}

			return this.character;
		}

		private EveAI.Live.EveApi  getApi()
			{
				if (this.api == null)
				
				{
				this.api = new EveAI.Live.EveApi(keyID,vCode,characterID);
				}

				return this.api;
			}
	}
}

