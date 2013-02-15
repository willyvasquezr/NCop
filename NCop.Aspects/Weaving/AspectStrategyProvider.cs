﻿using NCop.Aspects.Aspects;
using NCop.Aspects.Aspects.Builders;
using NCop.Core.Weaving;
using System.Linq;
using System.Reflection.Emit;
using NCop.Aspects.Extensions;
using NCop.Aspects.Framework;

namespace NCop.Aspects.Weaving
{
    public class AspectStrategyWeaver : IMethodWeaver
    {
        private IMethodWeaver _methodWeaver = null;
        private readonly IAspectDefinitionCollection _aspects = null;

        public AspectStrategyWeaver(IAspectBuilder aspectBuilder) {
            IAspectDefinition aspectDefinition = null;

            _aspects = aspectBuilder.Build();
            aspectDefinition = _aspects.First();

            if (aspectDefinition.Aspect.Is<IOnMethodBoundryAspect>()) {
                _methodWeaver = new FirstOnMethodBoundryAspectStrategy(_aspects);
            }
            else {
                _methodWeaver = new FirstMethodInterceptionAspectStartegy(_aspects);
            }
        }

        public IMethodEndWeaver MethodEndWeaver {
            get {
                return _methodWeaver.MethodEndWeaver;
            }
        }

        public IMethodScopeWeaver MethodScopeWeaver {
            get {
                return _methodWeaver.MethodScopeWeaver;
            }
        }

        public IMethodSignatureWeaver MethodDefintionWeaver {
            get {
                return _methodWeaver.MethodDefintionWeaver;
            }
        }

        public MethodBuilder DefineMethod() {
            return _methodWeaver.DefineMethod();
        }

        public void WeaveEndMethod(ILGenerator ilGenerator) {
            _methodWeaver.WeaveEndMethod(ilGenerator);
        }

        public ILGenerator WeaveMethodScope(ILGenerator ilGenerator, ITypeDefinition typeDefinition) {
            return _methodWeaver.WeaveMethodScope(ilGenerator, typeDefinition);
        }
    }
}
