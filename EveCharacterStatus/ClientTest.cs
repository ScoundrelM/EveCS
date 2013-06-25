using System;
using NUnit.Framework;

namespace EveCharacterStatus
{
	[TestFixture()]
	public class ClientTest
	{
		[Test()]
		public void Should_have_an_api ()
		{
			ClientForAPI api = new ClientForAPI(1904964, "zesRGv3T3jsETycEd0gChWLvA4VCj1xPN7c5kGgfdwRgrXIE80ARYe1EDcvAUZw7",  268435455);
			Assert.AreNotEqual(api, null);
		}
	}
}

