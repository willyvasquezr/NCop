﻿using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using NCop.Aspects.Weaving;
using NCop.Core;
using NCop.Core.Extensions;
using NCop.IoC;
using NCop.Mixins.Weaving;
using NCop.Weaving;
using NCop.Weaving.Extensions;

namespace NCop.Composite.Weaving
{
    internal class CompositeWeavingStrategy : MixinsWeaverStrategy
    {
        internal CompositeWeavingStrategy(IAspectTypeDefinition typeDefinition, ITypeMap mixins, IEnumerable<IMethodWeaver> methodWeavers, INCopDependencyAwareRegistry registry)
            : base(typeDefinition, mixins, methodWeavers, registry) {
        }

        protected override void EmitConstructorBody(ILGenerator ilGenerator) {
            var compositeTypeDefinition = (IAspectTypeDefinition)typeDefinition;

            base.EmitConstructorBody(ilGenerator);

            compositeTypeDefinition.EventBrokerFieldTypeDefinitions.ForEach(fieldTypeDefinition => {
                var contractType = fieldTypeDefinition.DeclaringType;
                var contractField = compositeTypeDefinition.GetFieldBuilder(contractType);
                var eventBrokerCtor = fieldTypeDefinition.EventBrokerType.GetConstructors()[0];

                //ilGenerator.EmitLoadArg(0);
                //ilGenerator.Emit(OpCodes.Ldnull);
                //ilGenerator.Emit(OpCodes.Stfld, fieldTypeDefinition.FieldBuilder);
                //ilGenerator.Emit(OpCodes.Pop);

                //ilGenerator.EmitLoadArg(0);
                //ilGenerator.EmitLoadArg(0);
                //ilGenerator.Emit(OpCodes.Ldfld, contractField);
                //ilGenerator.EmitLoadArg(0);
                //ilGenerator.Emit(OpCodes.Ldftn, fieldTypeDefinition.InvokeMethodBuilder);
                //ilGenerator.Emit(OpCodes.Newobj, fieldTypeDefinition.EventBrokerDelegateType);
                //ilGenerator.Emit(OpCodes.Newobj, eventBrokerCtor);
                //ilGenerator.Emit(OpCodes.Stfld, fieldTypeDefinition.FieldBuilder);
            });
        }
    }
}
