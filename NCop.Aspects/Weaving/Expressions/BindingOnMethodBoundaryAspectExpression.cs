﻿using NCop.Aspects.Aspects;
using NCop.Aspects.Extensions;

namespace NCop.Aspects.Weaving.Expressions
{
    internal class BindingOnMethodBoundaryAspectExpression : AbstractAspectExpression
    {
        internal BindingOnMethodBoundaryAspectExpression(IAspectExpression expression, IAspectDefinition aspectDefinition)
            : base(expression, aspectDefinition) {
        }

        public override IAspectWeaver Reduce(IAspectWeavingSettings aspectWeavingSettings ) {
            var clonedSettings = aspectWeavingSettings.CloneWith(settings => {
                settings.LocalBuilderRepository = new LocalBuilderRepository();
            });

            var nestedWeaver = aspectExpression.Reduce(clonedSettings); 
            
            return new BindingOnMethodBoundaryAspectWeaver(nestedWeaver, aspectDefinition, aspectWeavingSettings);
        }
    }
}