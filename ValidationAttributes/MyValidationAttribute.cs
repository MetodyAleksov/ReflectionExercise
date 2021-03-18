using System;

namespace ValidationAttributes
{
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool isValid(object obj);
    }
}