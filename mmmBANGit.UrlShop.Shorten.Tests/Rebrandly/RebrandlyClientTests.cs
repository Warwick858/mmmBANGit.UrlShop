// ******************************************************************************************************************
//  This file is part of mmmBANGit.UrlShop.
//
//  mmmBANGit.UrlShop - collection of methods for manipulating, and working with, urls.
//  Copyright(C)  2020  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  mmmBANGit.UrlShop is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program. If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using mmmBANGit.UrlShop.Common.Interfaces;
using mmmBANGit.UrlShop.Common.Model;
using mmmBANGit.UrlShop.Shorten.Rebrandly;
using NUnit.Framework;
using System.Net.Http;
using System.Net.Http.Headers;

namespace mmmBANGit.UrlShop.Shorten.Tests.Rebrandly
{
	/// <summary>
	/// This is more of a initiator class than a test class.
	/// Its sole purpose is to call and exercise the client methods.
	/// </summary>
	[TestFixture]
	public class RebrandlyClientTests
	{
		private IAppSettings? _appSettings;
		private HttpClient? _httpClient;
		private RebrandlyClient? _rebrandlyClient;

		[OneTimeSetUp]
		public void Setup()
		{
			_appSettings = new AppSettings()
			{
				RetryLimit = 3,
				RebrandlyApiKey = "<apikey_here>",
				RebrandlyWorkSpace = "<workspace_here>",
				RebrandlyUrl = "https://api.rebrandly.com/v1/links"
			};

			_httpClient = new HttpClient();
			_httpClient.DefaultRequestHeaders.Add("apikey", _appSettings.RebrandlyApiKey);
			_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			_rebrandlyClient = new RebrandlyClient(_appSettings, _httpClient);
		} // end method

		[Test]
		[TestCase("www.test.com/read/write/48787685484786548")]
		[TestCase("http://jimmyloforti.com/docs/resume-printable.pdf")]
		public void ShortenUrl(string url)
		{
			var shortenedUrl = _rebrandlyClient!.ShortenUrl(url);
			Assert.AreNotEqual(url, shortenedUrl);
		} // end method
	} // end class
} // end namespace
