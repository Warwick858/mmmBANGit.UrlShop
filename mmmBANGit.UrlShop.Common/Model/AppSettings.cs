﻿// ******************************************************************************************************************
//  This file is part of BattleAxe.Dal.
//
//  BattleAxe.Dal - web service for the data access layer.
//  Copyright(C)  2020  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  BattleAxe.Dal is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Affero General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Affero General Public License for more details.
//
//  You should have received a copy of the GNU Affero General Public License
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

namespace mmmBANGit.UrlShop.Common.Model
{
	public class AppSettings : IAppSettings
	{
		public string ApplicationName { get; set; } = string.Empty;
		public string Environment { get; set; } = string.Empty;
		public string SwaggerJsonUrl { get; set; } = string.Empty;
		public int RetryLimit { get; set; }

		//BITLY
		public string BitlyUsername { get; set; } = string.Empty;
		public string BitlyPassword { get; set; } = string.Empty;
		public string BitlyUrl { get; set; } = string.Empty;
		public string BitlyAuthUrl { get; set; } = string.Empty;

		//Rebrandly
		public string RebrandlyApiKey { get; set; } = string.Empty;
		public string RebrandlyWorkSpace { get; set; } = string.Empty;
		public string RebrandlyFullName { get; set; } = string.Empty;
		public string RebrandlyUrl { get; set; } = string.Empty;
	} // end class
} // end namespace
