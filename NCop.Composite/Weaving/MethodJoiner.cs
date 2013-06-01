﻿using NCop.Aspects.Aspects;
using NCop.Core;
using NCop.Mixins.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NCop.Core.Extensions;
using System.Collections;

namespace NCop.Composite.Weaving
{
    internal class MethodJoiner : AbstractMethodJoiner
    {
        internal MethodJoiner(IMixinsMap mixinsMap) {
            var joined = mixinsMap.Select(mixin => new {
                ContractType = mixin.ContractType,
                ImplementationType = mixin.ImplementationType,
                ContractMethods = mixin.ContractType.GetMethods(),
                ImplMethods = mixin.ImplementationType.GetMethods().ToSet()
            });

            Values = joined.SelectMany(join => {
                var methods = join.ContractMethods;

                return methods.Select(method => {
                    var result = method.SelectFirst(join.ImplMethods,
                                                   (c, impl) => MethodMatch(c, impl),
                                                   (c, impl) => impl);

                    return Tuple.Create(result, join.ImplementationType, join.ContractType);
                });
            });
        }
    }
}