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

namespace mmmBANGit.UrlShop.Shorten.Bitly.Model
{
	public class ShortenUrlResponse
	{
		[JsonPropertyName("references")]
		public References? References { get; set; }

		[JsonPropertyName("archived")]
		public bool Archived { get; set; }

		[JsonPropertyName("tags")]
		public IList<string>? Tags { get; set; }

		[JsonPropertyName("created_at")]
		public string CreatedAt { get; set; } = string.Empty;

		[JsonPropertyName("deeplinks")]
		public IList<DeepLink>? Deeplinks { get; set; }

		[JsonPropertyName("long_url")]
		public string LongUrl { get; set; } = string.Empty;

		[JsonPropertyName("custom_bitlinks")]
		public IList<string>? CustomBitLinks { get; set; }

		[JsonPropertyName("link")]
		public string Link { get; set; } = string.Empty;

		[JsonPropertyName("id")]
		public string Id { get; set; } = string.Empty;
	} // end class
} // end namespace
