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

using System.Text.Json.Serialization;

namespace mmmBANGit.UrlShop.Shorten.Bitly.Model
{
	public class DeepLink
	{
		[JsonPropertyName("bitlink")]
		public string Bitlink { get; set; } = string.Empty;

		[JsonPropertyName("install_url")]
		public string InstallUrl { get; set; } = string.Empty;

		[JsonPropertyName("created")]
		public string Created { get; set; } = string.Empty;

		[JsonPropertyName("app_uri_path")]
		public string AppUriPath { get; set; } = string.Empty;

		[JsonPropertyName("modified")]
		public string Modified { get; set; } = string.Empty;

		[JsonPropertyName("install_type")]
		public string InstallType { get; set; } = string.Empty;

		[JsonPropertyName("app_guid")]
		public string AppGuid { get; set; } = string.Empty;

		[JsonPropertyName("guid")]
		public string Guid { get; set; } = string.Empty;

		[JsonPropertyName("os")]
		public string Os { get; set; } = string.Empty;

		[JsonPropertyName("brand_guid")]
		public string BrandGuid { get; set; } = string.Empty;
	} // end class
} // end namespace
