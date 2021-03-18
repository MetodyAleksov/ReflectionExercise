using System.Data;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minvalue, int maxvalue)
        {
            minValue = minvalue;
            maxValue = maxvalue;
        }
        public override bool isValid(object obj)
        {
            int n = (int)obj;

            return n >= this.minValue && n <= this.maxValue;
        }
    }
}