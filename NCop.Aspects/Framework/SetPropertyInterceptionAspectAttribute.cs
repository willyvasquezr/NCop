﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCop.Aspects.Aspects;
using NCop.Aspects.Advices;

namespace NCop.Aspects.Framework
{
    public class SetPropertyInterceptionAspectAttribute : PropertyInterceptionAspectAttribute
    {
		public SetPropertyInterceptionAspectAttribute(Type aspectType)
			: base(aspectType) {
		}
    }
}
