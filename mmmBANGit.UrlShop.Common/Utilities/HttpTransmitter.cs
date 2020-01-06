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
using System.Net.Http;

namespace mmmBANGit.UrlShop.Common.Utilities
{
	public static class HttpTransmitter
	{
		private static int _retries = 1;
		private static bool _retrying = false;

		/// <summary>
		/// To handle the actual transmission of a HttpRequestMessage.
		/// When a transmission fails, the request is re-attempted based on
		/// the number of the given retry limit.
		/// </summary>
		/// <returns>The httpResponseMessage as a string</returns>
		public static string Transmit(HttpRequestMessage request, HttpClient httpClient, int retryLimit = 3)
		{
			HttpResponseMessage? httpResponseMessage;
			string temp = string.Empty;

			do
			{
				try
				{
					httpResponseMessage = httpClient!.SendAsync(request).GetAwaiter().GetResult();
					temp = httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
					httpResponseMessage.EnsureSuccessStatusCode();
					_retrying = false;
				}
				catch
				{
					//Retries available
					if (_retries <= retryLimit)
					{
						_retrying = true;
						_retries++;
					}
					else
					{
						_retrying = false;
					}
				} // end catch
			} while (_retrying);

			return temp;
		} // end method
	} // end class
} // end namespace
