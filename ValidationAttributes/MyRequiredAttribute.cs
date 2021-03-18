namespace ValidationAttributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {


        public override bool isValid(object obj)
        {
            string str = (string) obj;

            return !string.IsNullOrEmpty(str);
        }
    }
}