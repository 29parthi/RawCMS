﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Min�</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using GraphQL;
using RawCMS.Library.Service.Contracts;
using SchemaQL = GraphQL.Types.Schema;

namespace RawCMS.Plugins.GraphQL.Classes
{
    public class GraphQLSchema : SchemaQL
    {
        public GraphQLSchema(IDependencyResolver dependencyResolver, ICollectionMetadata collectionMetadata, GraphQLService manager) : base(dependencyResolver)
        {
            Query = new GraphQLQuery(collectionMetadata, manager);
        }
    }
}