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
namespace mmmBANGit.UrlShop.Common.Interfaces
{
	public interface IAppSettings
	{
		string ApplicationName { get; set; }
		string Environment { get; set; }
		string SwaggerJsonUrl { get; set; }
		int RetryLimit { get; set; }

		//BITLY
		string BitlyUsername { get; set; }
		string BitlyPassword { get; set; }
		string BitlyUrl { get; set; }
		string BitlyAuthUrl { get; set; }

		//REBRANDLY
		string RebrandlyApiKey { get; set; }
		string RebrandlyWorkSpace { get; set; }
		string RebrandlyFullName { get; set; }
		string RebrandlyUrl { get; set; }
	} // end interface
} // end namespace
