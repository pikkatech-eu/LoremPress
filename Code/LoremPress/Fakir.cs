/***********************************************************************************
* File:         Fakir.cs                                                           *
* Contents:     Class Fakir                                                        *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 11:17                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoremPress
{
	public static class Fakir
	{
		public static Publication Title	{get;} = new Publication();
		public static Journal Journal{get;}	= new Journal();

		public static Prose Prose	{get;}	= new Prose();

		public static Codes Codes		{get;} = new Codes();
	}
}
