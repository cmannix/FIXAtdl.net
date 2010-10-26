﻿#region Copyright (c) 2010, Cornerstone Technology Limited. http://atdl4net.org
//
//   This software is released under both commercial and open-source licenses.
//
//   If you received this software under the commercial license, the terms of that license can be found in the
//   Commercial.txt file in the Licenses folder.  If you received this software under the open-source license,
//   the following applies:
//
//      This file is part of Atdl4net.
//
//      Atdl4net is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public 
//      License as published by the Free Software Foundation, version 3.
// 
//      Atdl4net is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
//      of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more details.
//
//      You should have received a copy of the GNU Lesser General Public License along with Atdl4net.  If not, see
//      http://www.gnu.org/licenses/.
//
#endregion

using Atdl4net.Diagnostics;
using Atdl4net.Resources;
using System;

namespace Atdl4net.Utility
{
    public static class StringExtensions
    {
        private static readonly string TypeName = typeof(StringExtensions).Name;

        public static T ParseAsEnum<T>(this string value) where T : struct
        {
            if (string.IsNullOrEmpty(value))
                throw ThrowHelper.New<ArgumentNullException>(TypeName, ErrorMessages.NullOrEmptyStringEnumParseFailure, typeof(T).Name);

            T result;

            if (!typeof(T).IsEnum)
                throw new InvalidOperationException(InternalErrors.InvalidUseOfParseAsEnum);

#if NET_40
            if (!Enum.TryParse<T>(value, out result))
                throw ThrowHelper.New<ArgumentException>(TypeName, ErrorMessages.InvalidValueEnumParseFailure, value, typeof(T).Name);
#else
            try
            {
                result = (T)Enum.Parse(typeof(T), value);
            }
            catch (ArgumentException ex)
            {
                // We don't Rethrow here as we want the error message (that may be shown to the user) to be consistent between the .NET 3.5 
                // and .NET 4.0 implementations.
                throw ThrowHelper.New<ArgumentException>(TypeName, ex, ErrorMessages.InvalidValueEnumParseFailure, value, typeof(T).Name);
            }
#endif

            return result;
        }
    }
}
