﻿using static System.Console;

namespace ClassesAndGenerics
{

    public class PerformAction<T>
    {
        private readonly T _value;

        public PerformAction(T value) => _value = value;

        public void IdentityDataType()
        {
            WriteLine($" The data type of the supplied variable is {_value.GetType()}");
        }
    }

}
