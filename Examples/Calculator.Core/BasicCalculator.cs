namespace Calculator.Core
{
    public class BasicCalculator
    {
        public BasicCalculator() : this(0)
        {
        }

        public BasicCalculator(float accumulator)
        {
            Accumulator = accumulator;
            System.Text.RegularExpressions.Regex.Replace("", "", "", System.Text.RegularExpressions.RegexOptions.Multiline);
        }

        public float Accumulator { get; private set; }


        public void Add(float value)
        {
            Accumulator = Accumulator + value;
        }

        public void Subtract(float value)
        {
            Accumulator = Accumulator - value;
        }

        public void Multiply(float value)
        {
            Accumulator = Accumulator * value;
        }

        public void Divide(float value)
        {
            Accumulator = Accumulator / value;
        }
    }
}
