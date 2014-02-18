using System;

namespace MS.QualityTools.UnitTestFramework.Specifications
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class SpecificationDescriptionAttribute : Attribute
	{
        public SpecificationDescriptionAttribute(string description)
        {
            Description = description;
        }
    
        public string Description { get; private set; }
    }
}
