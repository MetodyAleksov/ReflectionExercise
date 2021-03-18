using System;
using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();

            PropertyInfo[] properties = type.GetProperties().ToArray();

            bool isValid = true;

            foreach (PropertyInfo property in properties)
            {
                MyValidationAttribute[] attributes = property.GetCustomAttributes()
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (MyValidationAttribute attribute in attributes)
                {
                    if (!attribute.isValid(property.GetValue(obj)))
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }
    }
}