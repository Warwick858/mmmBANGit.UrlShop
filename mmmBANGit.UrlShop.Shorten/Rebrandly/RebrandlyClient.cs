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
using mmmBANGit.UrlShop.Shorten.Rebrandly.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace mmmBANGit.UrlShop.Shorten.Rebrandly
{
	public class RebrandlyClient
	{
		private readonly IAppSettings _appSettings;
		private HttpClient? _httpClient;
		private readonly ShortenUrlRequest? _shortenUrlRequest;

		public RebrandlyClient(IAppSettings appSettings, HttpClient httpClient)
		{
			_appSettings = appSettings;
			_httpClient = httpClient;
			_shortenUrlRequest = new ShortenUrlRequest()
			{
				Domain = new Domain()
				{

				}
			};
		} // end method

		public string ShortenUrl(string url)
		{
			HttpRequestMessage? httpRequestMessage;
			ShortenUrlResponse? shortUrlResponse;
			string temp = string.Empty;

			try
			{
				_shortenUrlRequest!.Destination = url;

				httpRequestMessage = new HttpRequestMessage()
				{
					Method = HttpMethod.Post,
					RequestUri = new Uri(_appSettings.RebrandlyUrl),
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

			return shortUrlResponse!.ShortUrl!;
		} // end method
	} // end class
} // end namespace
