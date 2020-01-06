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
	public class References
	{
		[JsonPropertyName("group")]
		public string Group { get; set; } = string.Empty;

		[JsonPropertyName("property2")]
		public string Property2 { get; set; } = string.Empty;
	} // end class
} // end namespace
