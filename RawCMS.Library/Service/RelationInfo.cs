﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Mina'</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using System.Collections.Generic;
using MongoDB.Bson;

namespace RawCMS.Library.Service
{
    //TODO: REFACTORING: Move to the DataModel
    public class RelationInfo
    {
        public bool IsMultiple { get; set; }
        public string LookupCollection { get; set; }
        public List<BsonObjectId> Values { get; set; }
    }
}