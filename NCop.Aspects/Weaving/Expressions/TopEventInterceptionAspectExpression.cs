﻿using NCop.Aspects.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCop.Aspects.Weaving.Expressions
{
    internal class TopEventInterceptionAspectExpression : AbstractAspectEventExpression
    {
        public TopEventInterceptionAspectExpression(IAspectExpression aspectExpression, IEventAspectDefinition aspectDefinition)
            : base(aspectExpression, aspectDefinition) {
        }

        public override IAspectWeaver Reduce(IAspectWeavingSettings aspectWeavingSettings) {
            throw new NotImplementedException();
        }
    }
}