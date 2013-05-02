using System;
using System.Collections.Generic;
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

		
		//public double intelligence;
		//public double perception;
		//public double charisma;
		//public double willpower;
		//public double memory;

		//public Dictionary<string, double> attributesInClient;
		
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

			if(!useCache || this.character == null)
			{
				CharacterSheet cs = getApi().GetCharacterSheet();
				character = new Character(cs.Name);

				character.attributes = new Dictionary<string, double>();
				

				character.attributes.Add("Intelligence", cs.AttributeIntelligence);
				character.attributes.Add("Perception", cs.AttributePerception);
				character.attributes.Add("Charisma", cs.AttributeCharisma);
				character.attributes.Add("Willpower", cs.AttributeWillpower);
				character.attributes.Add("Memory", cs.AttributeMemory);
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

