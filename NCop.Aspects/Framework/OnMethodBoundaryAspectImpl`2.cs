﻿using System;
using NCop.Aspects.Advices;
using NCop.Aspects.Engine;
using NCop.Aspects.LifetimeStrategies;
using System.Diagnostics;
using NCop.Aspects.Aspects;
using NCop.Aspects.Framework;

namespace NCop.Aspects.Framework
{
    public abstract class OnMethodBoundaryAspectImpl<TArg1, TArg2, TResult>
    {	
		[OnMethodEntryAdvice]
		public virtual void OnEntry(MethodExecutionArgs<TArg1, TArg2, TResult> args) { }

		[FinallyAdvice]
		public virtual void OnExit(MethodExecutionArgs<TArg1, TArg2, TResult> args) { }

		[OnMethodSuccessAdvice]
		public virtual void OnSuccess(MethodExecutionArgs<TArg1, TArg2, TResult> args) { }

		[OnMethodExceptionAdvice]
		public virtual void OnException(MethodExecutionArgs<TArg1, TArg2, TResult> args) { }
	}
}
