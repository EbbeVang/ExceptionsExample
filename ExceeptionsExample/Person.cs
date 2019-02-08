using System;

namespace ExceptionsExample
{
    class Person
    {
        private int _age;
        private String _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value.ToLower().Contains("shit")) throw new NameContentViolationException();
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                // THROW EXAMPLE:
                // This setter will throw an exception if you try to set the age less than 0
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                _age = value;
            }
        }
    }
    
}
