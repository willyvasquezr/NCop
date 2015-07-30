﻿using NCop.Aspects.Aspects;
using NCop.Aspects.Weaving;
using System.Reflection;
using NCop.Weaving;

namespace NCop.Composite.Weaving
{
    internal class CompositeRemoveEventWeaver : AspectEventWeaver
    {
        internal CompositeRemoveEventWeaver(IEventTypeBuilder eventTypeBuilder, MethodInfo method, IAspectDefinitionCollection aspectDefinitions, IAspectWeavingSettings aspectWeavingSettings)
            : base(eventTypeBuilder, method, aspectDefinitions, aspectWeavingSettings) {
            methodSignatureWeaver = new RemoveEventMethodSignatureWeaver(eventTypeBuilder, aspectWeavingSettings.WeavingSettings.TypeDefinition);
        }
    }
}
