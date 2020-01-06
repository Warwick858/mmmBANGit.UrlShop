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
using mmmBANGit.UrlShop.Common.Utilities;
using mmmBANGit.UrlShop.Shorten.Bitly.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace mmmBANGit.UrlShop.Shorten.Bitly
{
	public class BitlyClient
	{
		private readonly IAppSettings _appSettings;
		private HttpClient? _httpClient;
		private readonly ShortenUrlRequest? _shortenUrlRequest;
		private string _accessToken;

		public BitlyClient(IAppSettings appSettings, HttpClient httpClient)
		{
			_appSettings = appSettings;
			_httpClient = httpClient;
			_accessToken = string.Empty;
			_shortenUrlRequest = new ShortenUrlRequest();
			Authenticate();
		} // end method

		public void Authenticate()
		{
			HttpRequestMessage? httpRequestMessage;
			HttpResponseMessage? httpResponseMessage;
			string result = string.Empty;
			string temp = string.Empty;

			try
			{
				httpRequestMessage = new HttpRequestMessage()
				{
					Method = HttpMethod.Post,
					RequestUri = new Uri(_appSettings.BitlyAuthUrl),
					Headers = { { "Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_appSettings.BitlyUsername}:{_appSettings.BitlyPassword}"))}" } },
					Content = new StringContent($"<auth_content_here>", Encoding.UTF8, "application/json")
				};

				httpResponseMessage = _httpClient!.SendAsync(httpRequestMessage).GetAwaiter().GetResult();
				temp = httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
				httpResponseMessage.EnsureSuccessStatusCode();
				_accessToken = temp;
			} // end try
			catch (Exception ex)
			{
				throw ex;
			}
		} // end method

		public string ShortenUrl(string url)
		{
			HttpRequestMessage? httpRequestMessage;
			ShortenUrlResponse? shortUrlResponse;
			string temp = string.Empty;

			try
			{
				_shortenUrlRequest!.LongUrl = url;

				httpRequestMessage = new HttpRequestMessage()
				{
					Method = HttpMethod.Post,
					RequestUri = new Uri(_appSettings.BitlyUrl),
					Headers = { { "Authorization", $"Bearer {_accessToken}" } },
					Content = new StringContent(JsonSerializer.Serialize(_shortenUrlRequest), Encoding.UTF8, "application/json")
				};

				temp = HttpTransmitter.Transmit(httpRequestMessage, _httpClient!);
				shortUrlResponse = JsonSerializer.Deserialize<ShortenUrlResponse>(temp);
				httpRequestMessage.Dispose();
			} // end try
			catch (Exception ex)
			{
				throw ex;
			}

			return shortUrlResponse.Link;
		} // end method
	} // end class
} // end namespace
