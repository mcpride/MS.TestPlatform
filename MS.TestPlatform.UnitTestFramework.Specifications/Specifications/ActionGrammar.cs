using System;

namespace MS.TestPlatform.UnitTestFramework.Specifications
{
    public abstract class ActionGrammar : ExecutableGrammar<Action<SpecificationContext>>
    {
        protected ActionGrammar(SpecificationContext context, string description, Action<SpecificationContext> implementation) : base(context, description, implementation)
        {
        }

        public override void Execute()
        {
            Implementation(Context);
            Result = GrammarResult.Passed;
        }
    }
}
