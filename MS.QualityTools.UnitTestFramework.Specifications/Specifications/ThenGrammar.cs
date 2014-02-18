using System;

namespace MS.QualityTools.UnitTestFramework.Specifications
{
    public class ThenGrammar : FunctionGrammar
    {
        public ThenGrammarPrefix Prefix { get; private set; }

        public ThenGrammar(SpecificationContext context, string description, Func<SpecificationContext, bool> implementation, ThenGrammarPrefix prefix) : base(context, string.Format("{0} {1}", prefix, description), implementation)
        {
            Prefix = prefix;
        }
    }
}
