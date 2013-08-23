﻿using NCop.Aspects.Advices;
using NCop.Aspects.Engine;
using System;
using NCop.Aspects.LifetimeStrategies;
using NCop.Aspects.Aspects;

namespace NCop.Aspects.Framework
{
	[LifetimeStrategy(KnownLifetimeStrategy.Singleton)]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	public class MethodInterceptionAspectAttribute : AspectAttribute
	{
		public MethodInterceptionAspectAttribute(Type aspectType)
			: base(aspectType) {
		}
	}
}
