﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace NCop.Core.Weaving
{
    public class MethodSignatureWeaver : IMethodSignatureWeaver
    {
        public MethodBuilder Weave(MethodInfo method) {
            throw new NotImplementedException();
        }
    }
}