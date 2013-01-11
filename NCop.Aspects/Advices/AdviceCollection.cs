﻿using NCop.Aspects.Aspects;
using NCop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCop.Aspects.Advices
{
    public class AdviceCollection : Collection<IAdvice>, IAdviceCollection
    {
        public AdviceCollection() : base() { }
        public AdviceCollection(IEnumerable<IAdvice> source) : base(source) { }
    }
}