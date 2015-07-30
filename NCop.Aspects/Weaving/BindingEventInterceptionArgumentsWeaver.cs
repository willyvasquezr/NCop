﻿using NCop.Aspects.Aspects;
using NCop.Aspects.Extensions;
using NCop.Weaving.Extensions;
using System.Reflection.Emit;

namespace NCop.Aspects.Weaving
{
    internal class BindingEventInterceptionArgumentsWeaver : AbstractEventAspectArgumentsWeaver
    {
        internal BindingEventInterceptionArgumentsWeaver(IEventAspectDefinition aspectDefinition, IArgumentsWeavingSettings argumentWeavingSettings, IAspectWeavingSettings aspectWeavingSettings, BindingSettings bindingSettings)
            : base(aspectDefinition, argumentWeavingSettings, aspectWeavingSettings, bindingSettings) {
        }

        public override LocalBuilder BuildArguments(ILGenerator ilGenerator) {
            var ctorInterceptionArgs = ArgumentType.GetConstructors()[0];
            var aspectArgLocalBuilder = ilGenerator.DeclareLocal(ArgumentType);
            var eventArgumentContract = Member.ToEventArgumentContract();

            ilGenerator.EmitLoadArg(1);
            ilGenerator.Emit(OpCodes.Ldind_Ref);
            ilGenerator.EmitLoadArg(3);
            ilGenerator.Emit(OpCodes.Callvirt, eventArgumentContract.GetProperty("Event").GetGetMethod());
            ilGenerator.EmitLoadArg(3);
            ilGenerator.Emit(OpCodes.Callvirt, eventArgumentContract.GetProperty("Handler").GetGetMethod());
            ilGenerator.Emit(OpCodes.Ldsfld, BindingsDependency);
            ilGenerator.EmitLoadArg(3);
            ilGenerator.Emit(OpCodes.Callvirt, eventArgumentContract.GetProperty("EventBroker").GetGetMethod());
            ilGenerator.Emit(OpCodes.Newobj, ctorInterceptionArgs);
            ilGenerator.EmitStoreLocal(aspectArgLocalBuilder);

            return aspectArgLocalBuilder;
        }
    }
}