﻿using NCop.Aspects.Aspects;
using System.Reflection;

namespace NCop.Aspects.Engine
{
    public class AspectValidatorVisitor
    {
        public void Visit(MethodInfo method, IAspect aspect, AspectMap aspectMap) {
            AspectTypeValidator.ValidateMethodAspect(aspect, aspectMap);
        }

        public void Visit(PropertyInfo property, IAspect aspect, AspectMap aspectMap) {
            AspectTypeValidator.ValidatePropertyAspect(property, aspect, aspectMap);
        }

        public void Visit(EventInfo @event, IAspect aspect, AspectMap aspectMap) {
            AspectTypeValidator.ValidateEventAspect(aspect, aspectMap);
        }
    }
}
