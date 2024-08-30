﻿/*
Copyright (c) 2018-2023 Festo SE & Co. KG <https://www.festo.com/net/de_de/Forms/web/contact_international>
Author: Michael Hoffmeister

This source code is licensed under the Apache License 2.0 (see LICENSE.txt).

This source code may use other Open Source software components (see LICENSE.txt).
*/
using Extensions;
using System.Collections.Generic;
using System.Linq;
using AdminShellNS;
using Aas = AasCore.Aas3_0;

namespace Extensions
{
    public static class ExtendILevelType
    {
        public static bool IsEmpty(this ILevelType level)
        {
            return !(level.Nom || level.Typ || level.Min || level.Max);
        }
    }
}
