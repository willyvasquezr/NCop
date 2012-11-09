﻿using NCop.Aspects.Advices;
using NCop.Aspects.Aspects.Interception;
using NCop.Aspects.Engine;
using NCop.Core.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCop.Aspects.Aspects
{
    public interface IMethodInterceptionContract : IAspect
    {
        [OnInvokeAdvice]
        void OnInvoke(MethodInterception methodInterception);
    }
}
