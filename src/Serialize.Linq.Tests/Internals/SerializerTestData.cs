﻿#region Copyright
//  Copyright, Sascha Kiefer (esskar)
//  Released under LGPL License.
//  
//  License: https://raw.github.com/esskar/Serialize.Linq/master/LICENSE
//  Contributing: https://github.com/esskar/Serialize.Linq
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Serialize.Linq.Tests.Internals
{
    internal static class SerializerTestData
    {
        private static readonly int[] _arrayOfIds = { 6, 7, 8, 9, 10 };
        private static readonly List<int> _listOfIds = new List<int> { 6, 7, 8, 9, 10 };
        public static readonly Expression[] TestExpressions =
        {
            null,
            (Expression<Func<bool, bool>>)(b => b), 
            (Expression<Func<Bar, bool>>)(p => p.LastName == "Miller" && p.FirstName.StartsWith("M")),        
            (Expression<Func<Bar, bool>>)(p => (new [] { 1, 2, 3, 4, 5 }).Contains(p.Id)),
            (Expression<Func<bool>>)(() => true),
            (Expression<Func<bool>>)(() => false),
            (Expression<Func<bool>>)(() => 5 != 4),
            (Expression<Func<int>>)(() => 42),
            (Expression<Func<Guid>>)(() => Guid.NewGuid()),
            (Expression<Func<Guid>>)(() => new Guid("00000000-0000-0000-0000-00000000000")),
            (Expression<Func<Guid>>)(() => Guid.Empty),
            (Expression<Func<DayOfWeek, bool>>)(p => p == DayOfWeek.Monday)
			
        };
        public static readonly Expression[] TestNodesOnlyExpressions =
        {
            (Expression<Func<Bar, bool>>)(p => _arrayOfIds.Contains(p.Id)),
            (Expression<Func<Bar, bool>>)(p => _listOfIds.Contains(p.Id))
        };
    }
}