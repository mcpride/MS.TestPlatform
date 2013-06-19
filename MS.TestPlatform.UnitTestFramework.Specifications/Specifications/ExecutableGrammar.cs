using System;

namespace MS.TestPlatform.UnitTestFramework.Specifications
{
    public abstract class ExecutableGrammar<T> : GrammarBase where T: class
    {
        public T Implementation { get; private set; }

        protected ExecutableGrammar(SpecificationContext context, string description, T implementation) : base(context, description)
        {
            Implementation = implementation;
        }

        public abstract void Execute();

        public override void Evaluate()
        {
            base.Evaluate();

            try
            {
                if (Implementation != null)
                {
                    Execute();
                }
                else
                {
                    Result = GrammarResult.NotImplemented;
                }
            }
            catch (Exception ex)
            {
                Exception = ex;
                Result = GrammarResult.Exception;
            }
        }
    }
}
