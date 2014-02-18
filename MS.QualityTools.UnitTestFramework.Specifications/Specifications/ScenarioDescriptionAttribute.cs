using System;

namespace MS.QualityTools.UnitTestFramework.Specifications
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class ScenarioDescriptionAttribute : Attribute
    {
        public ScenarioDescriptionAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }
    }
}
