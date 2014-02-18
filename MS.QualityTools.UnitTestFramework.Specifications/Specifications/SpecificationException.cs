using System;

namespace MS.QualityTools.UnitTestFramework.Specifications
{
    public class SpecificationException : Exception
    {
        public SpecificationException()
        {
        }

        public SpecificationException(string message) : base(message)
        {
        }

        public SpecificationException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
