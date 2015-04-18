﻿using NCop.Aspects.Advices;
using NCop.Aspects.Engine;

namespace NCop.Aspects.Framework
{
    public class FunctionEventInterceptionAspect<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> : IEventInterceptionAspect
    {
        [OnAddHandlerAdvice]
        public virtual void OnAddHandler(FunctionEventInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> args) { }

        [OnRemoveHandlerAdvice]
        public virtual void OnRemoveHandler(FunctionEventInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> args) { }

        [OnInvokeHandlerAdvice]
        public virtual void OnInvokeHandler(FunctionEventInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> args) { }
    }
}