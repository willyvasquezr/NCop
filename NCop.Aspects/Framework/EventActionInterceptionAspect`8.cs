﻿using NCop.Aspects.Advices;
using NCop.Aspects.Engine;

namespace NCop.Aspects.Framework
{
    public class EventActionInterceptionAspect<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> : IEventInterceptionAspect
    {
        [OnAddHandlerAdvice]
        public virtual void OnAddHandler(EventActionInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> args) { }

        [OnRemoveHandlerAdvice]
        public virtual void OnRemoveHandler(EventActionInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> args) { }

        [OnInvokeHandlerAdvice]
        public virtual void OnInvokeHandler(EventActionInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> args) { }
    }
}