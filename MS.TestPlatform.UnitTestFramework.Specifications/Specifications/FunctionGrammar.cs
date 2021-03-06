﻿using System;

namespace MS.TestPlatform.UnitTestFramework.Specifications
{
    public class FunctionGrammar : ExecutableGrammar<Func<SpecificationContext, bool>>
    {
        public FunctionGrammar(SpecificationContext context, string description, Func<SpecificationContext, bool> implementation) : base(context, description, implementation)
        {
        }

        public override void Execute()
        {
            var implementationOutput = Implementation(Context);
            Result = implementationOutput ? GrammarResult.Passed : GrammarResult.Failed;
        }
    }
}
