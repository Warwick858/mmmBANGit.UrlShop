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
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace mmmBANGit.UrlShop.Shorten.Rebrandly.Model
{
	public class ShortenUrlResponse
	{
		[JsonPropertyName("favourite")]
		public bool Favourite { get; set; }

		[JsonPropertyName("https")]
		public bool Https { get; set; }

		[JsonPropertyName("domain")]
		public Domain? Domain { get; set; }

		[JsonPropertyName("domainName")]
		public string? DomainName { get; set; }
		
		[JsonPropertyName("domainId")]
		public string? DomainId { get; set; }

		[JsonPropertyName("shortUrl")]
		public string? ShortUrl { get; set; }

		[JsonPropertyName("isPublic")]
		public bool IsPublic { get; set; }

		[JsonPropertyName("creator")]
		public Creator? Creator { get; set; }

		[JsonPropertyName("clicks")]
		public int Clicks { get; set; }

		[JsonPropertyName("status")]
		public string? Status { get; set; }

		[JsonPropertyName("updatedAt")]
		public string? UpdatedAt { get; set; }

		[JsonPropertyName("createdAt")]
		public string? CreatedAt { get; set; }

		[JsonPropertyName("destination")]
		public string? Destination { get; set; }

		[JsonPropertyName("slashtag")]
		public string? Slashtag { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("id")]
		public string? Id { get; set; }

		[JsonPropertyName("tags")]
		public IList<string>? Tags { get; set; }

		[JsonPropertyName("integrated")]
		public bool Integrated { get; set; }
	} // end class
} // end namespace
