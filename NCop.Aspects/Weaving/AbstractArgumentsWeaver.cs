﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCop.Aspects.Extensions;
using System.Reflection.Emit;
using System.Reflection;
using NCop.Weaving;

namespace NCop.Aspects.Weaving
{
    internal abstract class AbstractArgumentsWeaver : IArgumentsWeaver, IArgumentsWeavingSettings
	{
		protected readonly IAspectWeavingSettings aspectWeavingSettings = null;

		internal AbstractArgumentsWeaver(IArgumentsWeavingSettings argumentsWeavingSettings, IAspectWeavingSettings aspectWeavingSettings) {
            ReturnType = argumentsWeavingSettings.ReturnType;
            AspectType = argumentsWeavingSettings.AspectType;
			Parameters = new Type[argumentsWeavingSettings.Parameters.Length];
			LocalBuilderRepository = aspectWeavingSettings.LocalBuilderRepository;
			ArgumentType = argumentsWeavingSettings.ArgumentType;
			argumentsWeavingSettings.Parameters.CopyTo(Parameters, 0);
			IsFunction = argumentsWeavingSettings.IsFunction;
			this.aspectWeavingSettings = aspectWeavingSettings;
			WeavingSettings = aspectWeavingSettings.WeavingSettings;
            BindingsDependency = argumentsWeavingSettings.BindingsDependency;
		}

        public Type ReturnType { get; set; }
        
        public Type AspectType { get; protected set; }

		public bool IsFunction { get; protected set; }

		public Type ArgumentType { get; protected set; }

		public Type[] Parameters { get; protected set; }

		public FieldInfo BindingsDependency { get; protected set; }

		public IWeavingSettings WeavingSettings { get; protected set; }

		public ILocalBuilderRepository LocalBuilderRepository { get; protected set; }

		public abstract void Weave(ILGenerator ilGenerator);
	}
}
