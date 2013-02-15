﻿using System;
using System.Diagnostics.Contracts;
using NCop.Aspects.Advices;
using NCop.Aspects.Engine;
using NCop.Aspects.LifetimeStrategies;
using System.Diagnostics;
using NCop.Aspects.Aspects;
using NCop.Aspects.Framework;

namespace NCop.Aspects.Framework
{
    [LifetimeStrategy(KnownLifetimeStrategy.Singleton)]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public abstract class OnMethodBoundaryAspectAttribute : AspectAttribute, IOnMethodBoundryAspect
    {
        [OnEntryAdvice]
        public virtual void OnEntry(IMethodExecution methodExecution) { }

        [FinallyAdvice]
        public virtual void OnExit(IMethodExecution methodExecution) { }

        [OnSuccessAdvice]
        public virtual void OnSuccess(IMethodExecution methodExecution) { }

        [OnExceptionAdvice]
        public virtual void OnException(IMethodExecution methodExecution) { }
    }
}
