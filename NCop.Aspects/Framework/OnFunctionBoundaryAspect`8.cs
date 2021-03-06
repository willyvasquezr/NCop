﻿using NCop.Aspects.Advices;
using NCop.Aspects.Engine;

namespace NCop.Aspects.Framework
{
    public abstract class OnFunctionBoundaryAspect<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> : IOnMethodBoundaryAspect
    {	
		[OnMethodEntryAdvice]
		public virtual void OnEntry(FunctionExecutionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> args) { }

		[FinallyAdvice]
		public virtual void OnExit(FunctionExecutionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> args) { }

		[OnMethodSuccessAdvice]
		public virtual void OnSuccess(FunctionExecutionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> args) { }

		[OnMethodExceptionAdvice]
		public virtual void OnException(FunctionExecutionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> args) { }
	}
}
