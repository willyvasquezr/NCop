﻿using NCop.Aspects.Aspects;
using NCop.Weaving;
using System.Reflection;
using System.Reflection.Emit;

namespace NCop.Aspects.Weaving
{
    internal class TopSetPropertyInterceptionAspectWeaver : AbstractSetPropertyInterceptionAspectWeaver
    {
        protected readonly IArgumentsWeaver argumentsWeaver = null;

        internal TopSetPropertyInterceptionAspectWeaver(IPropertyAspectDefinition aspectDefinition, IAspectWeavingSettings aspectWeavingSettings, FieldInfo weavedType)
            : base(aspectDefinition, aspectWeavingSettings, weavedType) {
            argumentsWeavingSettings.BindingsDependency = weavedType;
            argumentsWeavingSettings.Parameters = new[] { aspectDefinition.Member.PropertyType };
            argumentsWeaver = new TopSetPropertyInterceptionArgumentsWeaver(aspectDefinition.Member, argumentsWeavingSettings, aspectWeavingSettings);
            weaver = new MethodScopeWeaversQueue(methodScopeWeavers);
        }

        public override void Weave(ILGenerator ilGenerator) {
            argumentsWeaver.Weave(ilGenerator);
            weaver.Weave(ilGenerator);
        }
    }
}
